using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DAL
{
    public class ContactDAL
    {
        public static int LastId = 0;

        public static List<ContactRec> recordList = new List<ContactRec>();
    }
}
