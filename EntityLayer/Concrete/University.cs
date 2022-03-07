using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class University
    {
        [Key]
        public int UniversityID { get; set; }

        [StringLength(80)]
        public string UniversityName { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        [StringLength(50)]
        public string Website { get; set; }



        public int CityID { get; set; }
        public virtual City City { get; set; }

        public int DistrictID { get; set; }
        public virtual District District { get; set; }

        public ICollection<Faculty> Faculties { get; set; }
    }
}
