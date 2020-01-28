using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class NHAXUATBAN
    {
        private Int32 ID;
        private String TENNXB;
        private String DIACHI;
        private String SDT;
        private String EMAIL;

        public int Id { get => ID; set => ID = value; }
        public string TrnNXB { get => TENNXB; set => TENNXB = value; }
        public string Diachi { get => DIACHI; set => DIACHI = value; }
        public string Sdt { get => SDT; set => SDT = value; }
        public string Email { get => EMAIL; set => EMAIL = value; }
    }
}