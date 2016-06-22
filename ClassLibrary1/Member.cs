using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Project;
using System.Configuration;
using System.Data;

namespace ClassLibrary1
{
    public class Member
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string  Address { get; set; }
        public string  City { get; set; }
        public string  PhoneNumber { get; set; }
        public string  UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public static Member Login(string UserName, string Password)
        {
            Member result = null;
            DAL d = new DAL(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            d.AddParam("UserName", UserName);
            d.AddParam("Password", Password);
            DataSet ds = d.ExecuteProcedure("spLogin");

            if (ds.Tables[0].Rows.Count == 1)
            {
                DataRow r = ds.Tables[0].Rows[0];
                result = new Member();
                result.MemberID = int.Parse(r["ClientID"].ToString());
                result.FirstName = r["FirstName"].ToString();
                result.LastName = r["LastName"].ToString();
                result.Address = r["Address"].ToString();
                result.City = r["City"].ToString();
                result.PhoneNumber = r["PhoneNumber"].ToString();
                result.UserName = r["UserName"].ToString();
                result.Password = r["Password"].ToString();

                result.IsAdmin = (bool)r["AccessLevel"];
            }
            return result;
        }
        
    }
}
