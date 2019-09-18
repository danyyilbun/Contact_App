using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
namespace BLL
{
    public class ContactBAL
    {
        public void Add(ContactRec cr)
        {
           cr.id = ContactDAL.LastId++;

            ContactDAL.recordList.Add(cr);
        }

        public List<ContactRec> GetAll()
        {
            return ContactDAL.recordList;
        }

        public void Delete(int id)
        {
            ContactDAL.recordList.Remove(Details(id));
        }

        public ContactRec Details(int id)
        {
            return ContactDAL.recordList.Where(x => x.id == id).Single();
        }

        public void Update(ContactRec rc)
        {
         ContactDAL.recordList.Where(x => x.id == rc.id).Single().setContactRec(rc); 
        }
    }
}
