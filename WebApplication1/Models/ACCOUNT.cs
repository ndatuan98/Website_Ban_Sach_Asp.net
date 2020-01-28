using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ACCOUNT
    {
        private Int32 ID;
        private String USERNAME;
        private String PASSWORD;
        private String AVATAR;
        private String FULLNAME;
        private String ADDRESS;
        private String EMAIL;
        private String PHONE;
        private DateTime BIRTHDATE;
        private int ROLE;
        private bool ISDELETE;

        public int Id { get => ID; set => ID = value; }
        public string Username { get => USERNAME; set => USERNAME = value; }
        public string Password { get => PASSWORD; set => PASSWORD = value; }
        public string Avatar { get => AVATAR; set => AVATAR = value; }
        public string Fullname { get => FULLNAME; set => FULLNAME = value; }
        public string Address { get => ADDRESS; set => ADDRESS = value; }
        public string Email { get => EMAIL; set => EMAIL = value; }
        public string Phone { get => PHONE; set => PHONE = value; }
        public DateTime Birthdate { get => BIRTHDATE; set => BIRTHDATE = value; }
        public int Role { get => ROLE; set => ROLE = value; }
        public bool IsDelete { get => ISDELETE; set => ISDELETE = value; }
    }
}