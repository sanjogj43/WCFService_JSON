using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace jsonExample
{
    class Product
    {
        public Product()
        { }
        public int ProductId;
        public string Description;
        public string SKU;
        public string Brand;
        public int? QtyReceived;
        public int? QtyRemaining;
        public string DateReceived;
    }

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> pds = new List<Product>();
            SampleDataContext sd = new SampleDataContext();

            List<Product1> prods = (from ps in sd.Product1s
                                    select ps).ToList();

            foreach (Product1 prod in prods)
            {
                Product temp = new Product();
                temp.ProductId = prod.ProductId;
                temp.Description = prod.Descr;
                temp.Brand = prod.Brand;
                temp.QtyReceived = prod.QtyRecieved;
                temp.QtyRemaining = prod.QtyRem;
                temp.DateReceived = prod.DateReceived.Value.ToShortDateString();
                pds.Add(temp);
            }

            var ser = new JavaScriptSerializer();
            
            //MemoryStream ms = new MemoryStream();
            //XmlDictionaryWriter writer = JsonReaderWriterFactory.CreateJsonWriter(ms); 
            
            
            string s = ser.Serialize(pds);

            LiteralControl script = new LiteralControl();
            script.Text = s;

            Controls.Add(script);
        }
    }
}