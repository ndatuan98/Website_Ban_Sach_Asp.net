using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class GIOHANG
    {
        private Int32 id;
        private Int32 accountId;
        private Int32 masach;
        private int soluong;
        private DateTime ngaymua;
        private bool isConfirm;
        private Int32 confirmBy;
        private bool isFinish;
        private Int32 finishBy;

        public int Id { get => id; set => id = value; }
        public int AccountId { get => accountId; set => accountId = value; }
        public int Masach { get => masach; set => masach = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public DateTime Ngaymua { get => ngaymua; set => ngaymua = value; }
        public bool IsConfirm { get => isConfirm; set => isConfirm = value; }
        public int ConfirmBy { get => confirmBy; set => confirmBy = value; }
        public bool IsFinish { get => isFinish; set => isFinish = value; }
        public int FinishBy { get => finishBy; set => finishBy = value; }
    }
}