using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class City
    {
        [Key]
        public int CityID { get; set; }

        [StringLength(25)]
        public string CityName { get; set; }

        [StringLength(100)]
        public string CityImage { get; set; }


        public ICollection<Dorm> Dorms { get; set; }
        public ICollection<District> Districts { get; set; }
        public ICollection<University> Universities { get; set; }

    }
}
