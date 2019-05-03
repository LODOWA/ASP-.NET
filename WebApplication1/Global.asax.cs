using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Collections;


namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {

        public static int Lsesji;
        public static List<User> Zarejestrowani = new List<User>();

        protected void Application_Start(object sender, EventArgs e)
        {
            Lsesji = 0;
            Application["UsersOnline"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Lsesji++;
            Application["UsersOnline"] = (int)Application["UsersOnline"] + 1;
            Application.UnLock();
            Session.Timeout = 3;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Lsesji--;
            Application["UsersOnline"] = (int)Application["UsersOnline"] - 1;
            User x = (User)Session["uzytkownik"];
            Console.Out.WriteLine("qpa");
            Zarejestrowani.Remove(x);
            Application.UnLock();

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}