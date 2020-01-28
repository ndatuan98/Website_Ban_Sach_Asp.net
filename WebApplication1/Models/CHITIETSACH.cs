using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CHITIETSACH
    {
        private Int32 id;
        private String ngonngu;
        private String kichthuoc;
        private int sotrang;
        private String nguoidich;
        private float khoiluong;
        private string dinhdang;

        public int Id { get => id; set => id = value; }
        public string Ngonngu { get => ngonngu; set => ngonngu = value; }
        public string Kichthuoc { get => kichthuoc; set => kichthuoc = value; }
        public int Sotrang { get => sotrang; set => sotrang = value; }
        public string Nguoidich { get => nguoidich; set => nguoidich = value; }
        public float Khoiluong { get => khoiluong; set => khoiluong = value; }
        public string Dinhdang { get => dinhdang; set => dinhdang = value; }
    }
}