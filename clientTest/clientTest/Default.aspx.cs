using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;

namespace clientTest
{
    public class Product 
    {
        public Product()
        { }
        public int ProductId {get;set;}
        public string ProductSKU { get; set; }
        public string Description {get;set;}
        public string Brand {get;set;}
        public int QtyReceived {get;set;}
        public int QtyRemaining {get;set;}
        public String DateReceived { get; set; }
    }

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClientTestService.InformationServiceClient client = new ClientTestService.InformationServiceClient("BasicHttpBinding_IInformationService");
            var ser = new JavaScriptSerializer();

            String jsonString = client.GetInventoryData();

            List<Product> prodList = ser.Deserialize<List<Product>>(jsonString);

            grd_ProdData.DataSource = prodList;
            grd_ProdData.DataBind();

            Response.Write("<h2>Serialized String :</h2>"+jsonString+"<br/><br/>");

        }

        protected void grd_ProdData_OnRowDataBound(object sender, GridViewRowEventArgs e)
        { 
             foreach(TableCell cell in e.Row.Cells)
             {
                 cell.Width = new Unit("100px");
             }
        }
    }
}