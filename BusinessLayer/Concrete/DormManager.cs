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
    }
}
