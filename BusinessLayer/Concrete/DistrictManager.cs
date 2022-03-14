using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DistrictManager
    {
        Repository<District> repoDistrict = new Repository<District>();
        public List<District> GetAll()
        {
            return repoDistrict.List();
        }

        public int DistrictAddBl(District p)
        {
            if (p.DistrictName == "")
            {
                return -1;
            }
            return repoDistrict.Insert(p);

        }

        public int DeleteDistrictBL(int p)
        {
            District district = repoDistrict.Find(x => x.DiscritID == p);
            return repoDistrict.Delete(district);
        }
    }
}
