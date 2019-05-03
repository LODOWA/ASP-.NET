using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {


        List<User> uzytkownicy = new List<User>();
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)(Session["uzytkownik"]);
          //  HttpContext.Current.Session["uzytkownik"] = null;
        }

        //     public static ArrayList uzytkownicy = new ArrayList();
        public static int i = 1, b;
        Random rnd = new Random();
        protected void przypadek(int a)
        {
            switch (a)
            {
                case 1:
                    ImageButton1.Visible = true;
                    ImageButton2.Visible = false;
                    ImageButton3.Visible = false;
                    ImageButton4.Visible = false;
                    break;
                case 2:
                    ImageButton1.Visible = false;
                    ImageButton2.Visible = true;
                    ImageButton3.Visible = false;
                    ImageButton4.Visible = false;
                    break;
                case 3:
                    ImageButton1.Visible = false;
                    ImageButton2.Visible = false;
                    ImageButton3.Visible = true;
                    ImageButton4.Visible = false;
                    break;
                case 4:
                    ImageButton1.Visible = false;
                    ImageButton2.Visible = false;
                    ImageButton3.Visible = false;
                    ImageButton4.Visible = true;
                    break;
            }
        }



        protected void Button_Click2(Object sender, EventArgs e)
        {
            User user = (User)(Session["uzytkownik"]);
            i++;
            if (i > 4) { i = 1; }
            przypadek(i);
            user.rysunek++;
            Up();
           // (Session["uzytkownik"] as User).IncRysunek();
        }
        protected void Button_Click(Object sender, EventArgs e)
        {
            User user = (User)(Session["uzytkownik"]);
            i = rnd.Next(1, 5);
            while (i == b) { i = rnd.Next(1, 5); }
            b = i;
            przypadek(i);
            user.przycisk++;
            Up();
          //  (Session["uzytkownik"] as User).IncPrzycisk();
        }

        //przycisk zarejestruj
        protected void Button_Click3(Object sender, EventArgs e)
        {

            if (Page.IsValid) { 
            string uzytkownik = text1.Text;
            List<User> nowa = new List<User>();

                User user = new User(text1.Text);
                Session["uzytkownik"] = user;
                Global.Zarejestrowani.Add(user);

                ImieNazw.Text = uzytkownik;

                List<ListItem> users = new List<ListItem>();
                foreach (User item in Global.Zarejestrowani)
                {
                    users.Add(new ListItem(item.nazwa));
                }

                DropDownList1.DataSource = users;
                DropDownList1.DataBind();

                DropDownList1.SelectedIndex = DropDownList1.Items.IndexOf(DropDownList1.Items.FindByText(user.nazwa));
                Logo.Visible = false;
                Apka.Visible = true;
                DataUr.Text = user.data.ToString("dd-MM-yyyy");
                GodzUr.Text = user.data.ToShortTimeString();
                LPrz.Text = user.przycisk.ToString();
                LRys.Text = user.rysunek.ToString();
                Lapk.Text = Global.Lsesji.ToString();
            
            }

        }
        protected void Up_list()
        {
            List<ListItem> users = new List<ListItem>();
            int index = DropDownList1.SelectedIndex;

            foreach (User item in Global.Zarejestrowani)
            {
                users.Add(new ListItem(item.nazwa));
            }

            DropDownList1.DataSource = users;
            DropDownList1.DataBind();

            DropDownList1.SelectedIndex = index;            
        }

        protected void CustomValidator1(object source, ServerValidateEventArgs e)
        {
            foreach (User item in Global.Zarejestrowani)
            {
                if (item.nazwa == text1.Text)
                {
                    e.IsValid = false;
                }
            }

        }

        protected void Selection_Change(object sender, EventArgs e)
        {
            Session["Wuzytkownik"] = DropDownList1.SelectedItem.Text.ToString(); 
             var tmp = (String)Session["Wuzytkownik"];
            foreach (User item in Global.Zarejestrowani)
            {
                if (item.nazwa == tmp)
                {
                    DataUr.Text = item.data.ToString("dd-MM-yyyy");
                    GodzUr.Text = item.data.ToShortTimeString();
                    LPrz.Text = item.przycisk.ToString();
                    LRys.Text = item.rysunek.ToString();
                    Lapk.Text = Global.Lsesji.ToString();
                }
                   
            }

        }



        protected void Up()
        {
            var user = (User)(Session["uzytkownik"]);
            string tmp = DropDownList1.SelectedItem.Text.ToString();
            if (user.nazwa == tmp)
            {
                DataUr.Text = user.data.ToString("dd-MM-yyyy");
                GodzUr.Text = user.data.ToShortTimeString();
                LPrz.Text = user.przycisk.ToString();
                LRys.Text = user.rysunek.ToString();
                Lapk.Text = Global.Lsesji.ToString();
            }
            
          


        }

        
        protected void Unnamed1_Tick(object sender, EventArgs e)
        {

            if(DropDownList1.SelectedItem.Text.ToString() != null)
            { 
            Up_list();
                var user = (User)(Session["uzytkownik"]);
                string tmp = DropDownList1.SelectedItem.Text.ToString();
                if (user.nazwa == tmp)
                {
                    DataUr.Text = user.data.ToString("dd-MM-yyyy");
                    GodzUr.Text = user.data.ToShortTimeString();
                    LPrz.Text = user.przycisk.ToString();
                    LRys.Text = user.rysunek.ToString();
                    Lapk.Text = Global.Lsesji.ToString();
                }
                else
                {
                    foreach (User item in Global.Zarejestrowani)
                    {
                        if (item.nazwa == tmp)
                        {
                            DataUr.Text = item.data.ToString("dd-MM-yyyy");
                            GodzUr.Text = item.data.ToShortTimeString();
                            LPrz.Text = item.przycisk.ToString();
                            LRys.Text = item.rysunek.ToString();
                            Lapk.Text = Global.Lsesji.ToString();
                        }
                    }


                }
            }
        }
    }

}