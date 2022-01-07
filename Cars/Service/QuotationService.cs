﻿using Cars.Consts;
using Cars.Models;
using Cars.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Service
{
    public class QuotationService
    {
        public CarsContext db { get; set; }
        public QuotationService(CarsContext carsContext)
        {
            db = carsContext;
        }
        public PagingViewModel<Quotation> getQuotations(int currentPage)
        {
            var quotations = db.Quotations.Include("Status").Where(c => c.StatusID == 2).Skip((currentPage - 1) * TablesMaxRows.IndexQuotationMaxRows).Take(TablesMaxRows.IndexQuotationMaxRows).ToList();
            PagingViewModel<Quotation> viewModel = new PagingViewModel<Quotation>();
            viewModel.items = quotations.ToList();
            var itemsCount = db.Quotations.Where(c => c.StatusID == 2).Count();
            double pageCount = (double)(itemsCount / Convert.ToDecimal(TablesMaxRows.IndexQuotationMaxRows));
            viewModel.PageCount = (int)Math.Ceiling(pageCount);
            viewModel.CurrentPageIndex = currentPage;
            viewModel.itemsCount = itemsCount;
            viewModel.Tablelength = TablesMaxRows.IndexQuotationMaxRows;
            return viewModel;
        }

        internal long getCountOrderLines()
        {
          return db.OrderDetails.Where(c => c.StatusID == 2 && c.WorkflowID == 4 && !c.QuotationID.HasValue).Count();
        }

        internal List<OrderDetails> getOrderLines()
        {
           return db.OrderDetails.Include(c=>c.Order).Include(c => c.Order.Customer).Include(c => c.Order.Customer.CustomerContacts).Where(c => c.StatusID == 2 && c.WorkflowID == 4 && !c.QuotationID.HasValue).ToList();

        }

        public PagingViewModel<Quotation> getQuotationsWithChangelength(int currentPageIndex, int length)
        {
            TablesMaxRows.IndexQuotationMaxRows = length;
            return getQuotations(currentPageIndex);
        }

        readonly object _object = new object();
        internal CreateQuotationViewModel CreateQuotation(List<long> ids)
        {
            try
            {
                lock (_object)
                {
                    var SelectedOrderLines = db.OrderDetails.Where(c => c.StatusID == 2 && c.WorkflowID == 4 && c.QuotationID.HasValue && ids.Contains(c.OrderDetailsID)).ToList();
                    if (SelectedOrderLines is not null && SelectedOrderLines.Count > 0)
                    {
                        CreateQuotationViewModel model = new CreateQuotationViewModel()
                        {
                            status = -2,
                            orderDetails = SelectedOrderLines,
                        };
                        return model;
                    }

                    Quotation quotation = new Quotation()
                    {
                        OrderDetails = db.OrderDetails.Where(c => c.StatusID == 2 && c.WorkflowID == 4 && !c.QuotationID.HasValue && ids.Contains(c.OrderDetailsID)).ToList(),
                        StatusID = 2,
                        DTsCreate = DateTime.Now,
                        SystemUserCreate = "1",
                    };
                    db.Quotations.Add(quotation);
                    db.SaveChanges();
                    QuotationStatusLogs log = new QuotationStatusLogs()
                    {
                        StatusID = 2,
                        QuotationID = quotation.QuotationID,
                        SystemUserID = "1",
                        DTsCreate = DateTime.Now,
                    };
                    db.QuotationStatusLogs.Add(log);
                    db.SaveChanges();
                    CreateQuotationViewModel model2 = new CreateQuotationViewModel()
                    {
                        status = 1,
                        Quotation = quotation,
                        QuotationId = quotation.QuotationID
                    };
                    return model2;

                }
            }
            catch (Exception)
            {

                CreateQuotationViewModel model = new CreateQuotationViewModel()
                {
                    status = -1,
                  
                };
                return model;
            }
           
        }

        internal int Confirmation(long quotationId)
        {
            Quotation quotation = db.Quotations.Include(c=>c.OrderDetails).FirstOrDefault(c => c.QuotationID == quotationId);
            if (quotation is not null)
            {
                quotation.Confirmed = true;
                quotation.SystemUserUpdate = "1";
                quotation.DTsUpdate = DateTime.Now;
                foreach (var orderDetails in quotation.OrderDetails)
                {
                    orderDetails.WorkflowID = orderDetails.Price.Value >= 1000 ? 5 : 6;
                    db.WorkflowOrderDetailsLogs.Add(new WorkflowOrderDetailsLog {
                        DTsCreate =DateTime.Now,
                        Active=true,
                        OrderDetailsID=orderDetails.OrderDetailsID,
                        SystemUserID="1",
                        WorkflowID=  4,                        
                    });
                }
                db.SaveChanges();
                return 1;
            }
            return -1;
        }

        internal Quotation getQuotationByQuotationID(long quotationID)
        {
          return db.Quotations.Include(c=>c.QuotationDocument).Include(c=>c.OrderDetails).FirstOrDefault(c => c.QuotationID == quotationID);
        }

        internal void CreateFilePath(string path ,long quotationID,string filename)
        {
            db.QuotationDocuments.Add(new QuotationDocument() { DTsCreate=DateTime.Now, Path = path ,QuotationID = quotationID ,SystemUserID = "1",Comment=filename});
            db.SaveChanges();
        }
    }
}
