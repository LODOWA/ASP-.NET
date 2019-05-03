using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{

    public class User
    {

        public string nazwa;
        public DateTime data;
        public int przycisk;
        public int rysunek;
        public int aplikacje;

        public User(string nazwa)
        {
            this.nazwa = nazwa;
            this.data = DateTime.Now;
            this.przycisk = 0;
            this.rysunek = 0;
            this.aplikacje = 0;
        }

        public void IncRysunek()
        {
            rysunek++;
        }

        public void IncPrzycisk()
        {
            przycisk++;
        }
    }
}