using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class News
    {
        [Key]
        public int NewsID { get; set; }

        [StringLength(50)]
        public string NewsTitle { get; set; }

        [StringLength(150)]
        public string NewsLink { get; set; }

       
    }
}
