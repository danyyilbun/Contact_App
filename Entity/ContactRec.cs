using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ContactRec
    {

        public int id
        { get; set; }
        public string First_Name
        { get; set; }
        public string Last_Name { get; set; }
        public int Mobile_Phone_Num
        { get; set; }
        public int Home_Phone_Num
        { get; set; }
        public int Business_Phone_Num { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }

        public void setContactRec(ContactRec rc)

        {
            this.id = rc.id;
            this.First_Name = rc.First_Name;
            this.Last_Name = rc.Last_Name;
            this.Mobile_Phone_Num = rc.Mobile_Phone_Num;
            this.Home_Phone_Num = rc.Home_Phone_Num;
            this.Business_Phone_Num = rc.Business_Phone_Num;
            this.Address = rc.Address;
            this.Notes = rc.Notes;
            this.Active = rc.Active;
        }

    }
}
