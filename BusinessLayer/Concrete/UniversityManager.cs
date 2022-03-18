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

        public List<University> UniversityByID(int id)
        {
            return repoUni.List(x => x.UniversityID == id);
        }

        public int DeleteUniversityBL(int p)
        {
            University university = repoUni.Find(x => x.UniversityID == p);
            return repoUni.Delete(university);
        }

        public List<University> UniversityByName(string name)
        {
            //Sorgu Tam Ad Şeklinde kontrolü gerçekleşiyor kısmen tanımlama olarak değiştirelecektir {Oğuzhan}
            return repoUni.List(x => x.UniversityName == name);
        }
    }
}
