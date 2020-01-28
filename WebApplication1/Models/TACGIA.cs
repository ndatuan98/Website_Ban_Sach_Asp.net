using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class TACGIA
    {
        private Int32 id;
        private String tenTG;
        private String chitiet;
        private String image;

        public int Id { get => id; set => id = value; }
        public string TenTG { get => tenTG; set => tenTG = value; }
        public string Chitiet { get => chitiet; set => chitiet = value; }
        public string Image { get => image; set => image = value; }
    }
}