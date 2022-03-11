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

        [StringLength(150)]
        public string DormName { get; set; }

        [StringLength(5)]
        public string Bed { get; set; }

        [StringLength(10)]
        public string Wifi { get; set; }

        [StringLength(10)]
        public string Meal { get; set; }

        [StringLength(30)]
        public string Advisior { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [StringLength(300)]
        public string Adress { get; set; }

        [StringLength(50)]
        public string Website { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }


        public int CityID { get; set; }
        public virtual City City { get; set; }

        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }

        public ICollection<Comment> Comments { get; set; }

    
    }

}
