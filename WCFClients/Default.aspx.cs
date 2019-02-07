using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFClients
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btname_Click(object sender, EventArgs e)
        {
            MyWCFservice.Service1Client objclient = new MyWCFservice.Service1Client("BasicHttpBinding_IService1");
           string  result= objclient.GetData(1);

        }
    }
}