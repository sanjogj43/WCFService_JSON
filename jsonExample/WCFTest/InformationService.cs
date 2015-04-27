using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using System.Text;
using System.IO;


namespace WCFTest
{
    class product
    { 
        public product()
        { }
        public int ProductId {get;set;}
        public string ProductSKU {get;set;}
        public string Description {get;set;}
        public string Brand {get;set;}
        public int QtyReceived {get;set;}
        public int QtyRemaining{get;set;}
        public String DateReceived { get; set; }

        public void copyProduct(Product1 p)
        {
            ProductId = p.ProductId;
            ProductSKU = p.SKU;
            Brand = p.Brand;
            Description = p.Descr;
            QtyReceived = p.QtyRecieved.Value;
            QtyRemaining = p.QtyRem.Value;
            DateReceived = p.DateReceived.Value.ToShortDateString();
        }
    }
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "InformationService" in both code and config file together.
    public class InformationService : IInformationService
    {
        public string GetInventoryData()
        {
            SampleDataContext sd = new SampleDataContext();

            List<Product1> prods = (from ps in sd.Product1s
                                    select ps).ToList();

            List<product> pds = new List<product>();
            
            foreach (Product1 p in prods)
            {
                product p1 = new product();
                p1.copyProduct(p);
                pds.Add(p1);
            }

            var ser = new JavaScriptSerializer();
            string s = ser.Serialize(pds);

            return s;
        }
    }
}
