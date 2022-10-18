using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginForm.Models
{
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
