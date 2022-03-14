using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Dorm
    {
        [Key]
        public int DormID { get; set; }

        [StringLength(200)]
        public string DormName { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        [StringLength(15)]
        public string Bed { get; set; }

        [StringLength(15)]
        public string Wifi { get; set; }

        [StringLength(10)]
        public string Meal { get; set; }

        [StringLength(40)]
        public string Advisior { get; set; }

        [StringLength(600)]
        public string Description { get; set; }

        [StringLength(600)]
        public string Adress { get; set; }

        [StringLength(60)]
        public string Website { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        public string DormImage { get; set; }


        public int CityID { get; set; }
        public virtual City City { get; set; }

        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }

        public ICollection<Comment> Comments { get; set; }

    
    }

}
