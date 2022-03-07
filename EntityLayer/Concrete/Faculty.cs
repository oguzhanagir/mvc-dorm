using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Faculty
    {
        [Key]
        public int FacultyID { get; set; }

        [StringLength(150)]
        public string FacultyName { get; set; }

        public int UniversityID { get; set; }
        public virtual University University { get; set; }
    }
}
