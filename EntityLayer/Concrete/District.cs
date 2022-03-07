using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class District
    {
        [Key]
        public int DiscritID { get; set; }

        [StringLength(25)]
        public string DistrictName { get; set; }


        public int CityID { get; set; }
        public virtual City City { get; set; }

        public ICollection<University> Universities { get; set; }
    }
}
