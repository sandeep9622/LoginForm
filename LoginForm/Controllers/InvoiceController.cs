using Dapper;
using LoginForm.Models;
using LoginForm.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LoginForm.Controllers
{
    [Route("Invoice")]
    public class InvoiceController:Controller
    {
        private readonly IDapperService _dapper;
        public InvoiceController(IDapperService dapper)
        {
            _dapper = dapper;
        }

        [Route("Save")]
        [HttpPost]
        public IActionResult SaveInvoice(Invoices invoice)
        {
            string query = @"insert into 
            Invoices(
                 VehicalNo,LocationFrom,LocationTo,GoodsValue,InvoiceNo,GSTType,ConsignerName,
                 ConsignerGSTNo,ConsignerMobile,ConsignerEmail,ConsignerState,ConsignerCity,ConsignerAddress,ConsigneeName,
                 ConsigneeGSTNo,ConsigneeMobile,ConsigneeEmail,ConsigneeState,ConsigneeCity,ConsigneeAddress)
             values(
                 @VehicalNo,@LocationFrom,@LocationTo,@GoodsValue,@InvoiceNo,@GSTType,@ConsignerName,
                 @ConsignerGSTNo,@ConsignerMobile,@ConsignerEmail,@ConsignerState,@ConsignerCity,@ConsignerAddress,@ConsigneeName,
                 @ConsigneeGSTNo,@ConsigneeMobile,@ConsigneeEmail,@ConsigneeState,@ConsigneeCity,@ConsigneeAddress)";

            var dbparams = new DynamicParameters();

            dbparams.Add("VehicalNo", invoice.VehicalNo, DbType.String);
            dbparams.Add("LocationFrom", invoice.LocationFrom, DbType.String);
            dbparams.Add("LocationTo", invoice.LocationTo, DbType.String);
            dbparams.Add("GoodsValue", invoice.GoodsValue, DbType.Double);
            dbparams.Add("InvoiceNo", invoice.InvoiceNo, DbType.String);
            dbparams.Add("GSTType", invoice.GSTType, DbType.String);

            dbparams.Add("ConsignerName", invoice.ConsignerName, DbType.String);
            dbparams.Add("ConsignerGSTNo", invoice.ConsignerGSTNo, DbType.String);
            dbparams.Add("ConsignerMobile", invoice.ConsignerMobile, DbType.String);
            dbparams.Add("ConsignerEmail", invoice.ConsignerEmail   , DbType.String);
            dbparams.Add("ConsignerState", invoice.ConsignerState, DbType.String);
            dbparams.Add("ConsignerCity", invoice.ConsignerCity, DbType.String);
            dbparams.Add("ConsignerAddress", invoice.ConsignerAddress, DbType.String);

            dbparams.Add("ConsigneeName", invoice.ConsigneeName, DbType.String);
            dbparams.Add("ConsigneeGSTNo", invoice.ConsigneeGSTNo, DbType.String);
            dbparams.Add("ConsigneeMobile", invoice.ConsigneeMobile, DbType.String);
            dbparams.Add("ConsigneeEmail", invoice.ConsigneeEmail, DbType.String);
            dbparams.Add("ConsigneeState", invoice.ConsigneeState, DbType.String);
            dbparams.Add("ConsigneeCity", invoice.ConsigneeCity, DbType.String);
            dbparams.Add("ConsigneeAddress", invoice.ConsigneeAddress, DbType.String);

            var result = _dapper.Insert<Invoices>(query, dbparams, System.Data.CommandType.Text);
            return View();
        }


        [Route("")]
        [Route("invoices")]
        //[Route("/")]
        public IActionResult Index()
        {
            string query = @"select * from Invoices";
            List<Invoices> result = _dapper.GetAll<Invoices>(query,null,CommandType.Text);
            return View(result);
        }

        [Route("invoiceById")]
        public IActionResult InvoiceById(int id)
        {
            string query = @"select * from Invoices where InvoiceNo = @InvoiceNo";

            var dbparams = new DynamicParameters();

            dbparams.Add("InvoiceNo", id, DbType.String);
            Invoices result = _dapper.Get<Invoices>(query, dbparams, CommandType.Text);

            return View(result);
        }
    }
}
