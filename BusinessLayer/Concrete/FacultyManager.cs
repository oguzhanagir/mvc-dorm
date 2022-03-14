using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FacultyManager
    {
        Repository<Faculty> repoFaculty = new Repository<Faculty>();

        public List<Faculty> GetAll()
        {
            return repoFaculty.List();
        }

        public int FacultyAddBl(Faculty p)
        {
            if (p.FacultyName == "" )
            {
                return -1;
            }
            return repoFaculty.Insert(p);

        }

        public int DeleteFacultyBL(int p)
        {
            Faculty faculty = repoFaculty.Find(x => x.FacultyID == p);
            return repoFaculty.Delete(faculty);
        }
    }
}
