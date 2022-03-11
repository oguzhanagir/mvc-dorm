using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   
    public class UniversityManager
    {
        Repository<University> repoUni = new Repository<University>();

        public List<University> GetAll()
        {
            return repoUni.List();
        }

        public int UniversityAddBl(University p)
        {
            if (p.UniversityName == "" )
            {
                return -1;
            }
            return repoUni.Insert(p);

        }

        public int DeleteUniversityBL(int p)
        {
            University university = repoUni.Find(x => x.UniversityID == p);
            return repoUni.Delete(university);
        }
    }
}
