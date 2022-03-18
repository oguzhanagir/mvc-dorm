using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Image
    {
        public int ImageID { get; set; }
        public string ImagePath { get; set; }
        public int DormID { get; set; }
        public virtual Dorm Dorm { get; set; }

    }
}
