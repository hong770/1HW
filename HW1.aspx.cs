using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1HW
{
    public partial class HW1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int a = 66;
            int num = 0;
            if (a == 1)
            {
                Response.Write(a + " 是質數" + "\n" + "Yes");
            }
            else
            {
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        num = 1;
                        break;
                    }
                    else
                    {
                        num = 0;

                    }
                }
                if (num == 1)
                {
                    Response.Write(a + " 不是質數" + "\n" + "No");
                }

                else
                {
                    Response.Write(a + " 是質數" + "\n" + "Yes");
                }
            }
        }
    }
    }
