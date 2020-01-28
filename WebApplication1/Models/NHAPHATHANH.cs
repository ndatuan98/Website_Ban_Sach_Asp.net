using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class NHAPHATHANH
    {
        private Int32 id;
        private String tennph;
        private String chitiet;
        private String logo;

        public int Id { get => id; set => id = value; }
        public string TenNPH { get => tennph; set => tennph = value; }
        public string Chitiet { get => chitiet; set => chitiet = value; }
        public string Logo { get => logo; set => logo = value; }
    }
}