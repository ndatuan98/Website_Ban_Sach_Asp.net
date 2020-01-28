using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class SACH
    {
        private Int32 id;
        private String tensach;
        private float dongia;
        private String donvitinh;
        private String mota;
        private int soluong;
        private String hinhminhhoa;
        private DateTime ngaytao;
        private Int32 matacgia;
        private Int32 machude;
        private Int32 maNXB;
        private Int32 maNPH;
        private Int32 idDetail;

        public int Id { get => id; set => id = value; }
        public string Tensach { get => tensach; set => tensach = value; }
        public float Dongia { get => dongia; set => dongia = value; }
        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
        public string Mota { get => mota; set => mota = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Hinhminhhoa { get => hinhminhhoa; set => hinhminhhoa = value; }
        public DateTime Ngaytao { get => ngaytao; set => ngaytao = value; }
        public int Matacgia { get => matacgia; set => matacgia = value; }
        public int Machude { get => machude; set => machude = value; }
        public int MaNXB { get => maNXB; set => maNXB = value; }
        public int MaNPH { get => maNPH; set => maNPH = value; }
        public int IdDetail { get => idDetail; set => idDetail = value; }
    }
}