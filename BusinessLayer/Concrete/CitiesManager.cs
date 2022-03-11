using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CitiesManager
    {
        Repository<City> repoCities = new Repository<City>();

        public List<City> GetAll()
        {
            return repoCities.List();
        }

        public int CityAddBl(City p)
        {
            if (p.CityName == "" || p.CityImage == "" )
            {
                return -1;
            }
            return repoCities.Insert(p);

        }

        public int DeleteCityBL(int p)
        {
            City city = repoCities.Find(x => x.CityID == p);
            return repoCities.Delete(city);
        }
    }
}
