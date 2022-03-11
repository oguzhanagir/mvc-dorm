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
        public int DistrictAddBl(District p)
        {
            if (p.DistrictName == "")
            {
                return -1;
            }
            return repoDistrict.Insert(p);

        }
    }
}
