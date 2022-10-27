using LoginForm.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginForm.Controllers
{
    [Route("Invoice")]
    public class InvoiceController:Controller
    {
        [Route("Save")]
        [HttpPost]
        public IActionResult SaveInvoice()
        {

            return View();
        }
    }
}
