using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DormManager
    {
        Repository<Dorm> _repoDorm = new Repository<Dorm>();

        public List<Dorm> GetAll()
        {
            return _repoDorm.List();
        }

        public List<Dorm> DormByID(int id)
        {
            return _repoDorm.List(x => x.DormID == id);
        }



        public int DormAddBl(Dorm p)
        {
            if (p.DormName =="" || p.Bed == "" || p.Wifi=="" || p.Description =="" || p.Adress=="" || p.Phone =="")
            {
                return -1;
            }
            return _repoDorm.Insert(p);

        }

        public int DeleteDormBL(int p)
        {
            Dorm dorm = _repoDorm.Find(x => x.DormID == p);
            return _repoDorm.Delete(dorm);
        }
        public int UpdateDorm(Dorm p)
        {

            Dorm dorm = _repoDorm.Find(x => x.DormID == p.DormID);
            dorm.DormName = p.DormName;
            dorm.Bed = p.Bed;
            dorm.Wifi = p.Wifi;
            dorm.Meal = p.Meal;
            dorm.Type = p.Type;
            dorm.DormImage = p.DormImage;
            dorm.Description = p.Description;
            dorm.Adress = p.Adress;
            dorm.Website = p.Website;
            dorm.Advisior = p.Advisior;
            dorm.Phone = p.Phone;
            dorm.CityID = p.CityID;
            dorm.AuthorID = p.AuthorID;
          

            return _repoDorm.Update(dorm);
        }

        public Dorm FindDorm(int id)
        {
            return _repoDorm.Find(x => x.DormID == id);
        }

    }
}
