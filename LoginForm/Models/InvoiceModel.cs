using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginForm.Models
{
    public class Invoices
    {
        public string ConsigneeCity { get; set; }
        public string ConsigneeEmail { get; set; }
        public string ConsigneeGSTNo { get; set; }
        public string ConsigneeMobile { get; set; }
        public string ConsigneeName { get; set; }
        public string ConsigneeState { get; set; }
        public string ConsignerCity { get; set; }
        public string ConsignerEmail { get; set; }
        public string ConsignerGSTNo { get; set; }
        public string ConsignerMobile { get; set; }
        public string ConsignerName { get; set; }
        public string ConsignerState { get; set; }
        public string GSTType { get; set; }
        public string InvoiceNo { get; set; }
        public string LocationFrom { get; set; }
        public string LocationTo { get; set; }
        public string VehicalNo { get; set; }
        public DateTime? Date { get; set; }
        public string ConsigneeAddress { get; set; }
        public string ConsignerAddress { get; set; }
        public int? GRNo { get; set; }
        public int? InvoiceId { get; set; }
        public double? GoodsValue { get; set; }
    }
    public class InvoiceModel
    {
        public int GRNo { get; set; }
        public int Date { get; set; }
        public int vehicalNo { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public int ValueOfGoods { get; set; }
        public int InvoiceNo { get; set; }
        public int ConsignerName { get; set; }
        public int ConsignerGSTNo { get; set; }
        public int ConsignerMobile { get; set; }
        public int ConsignerEmail { get; set; }
        public int ConsignerAddress { get; set; }
        public int ConsigneeName { get; set; }
        public int ConsigneeGSTNo { get; set; }
        public int ConsigneeMobile { get; set; }
        public int ConsigneeEmail { get; set; }
        public int ConsigneeAddress { get; set; }
    }
}
