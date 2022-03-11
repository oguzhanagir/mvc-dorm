using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager
    {
        Repository<About> repoAbout = new Repository<About>();

        public List<About> GetAll()
        {
            return repoAbout.List();
        }

        public int UpdateAbout(About p)
        {

            About about = repoAbout.Find(x => x.AboutID == p.AboutID);
            about.AboutContent = p.AboutContent;
            about.AboutTitle = p.AboutTitle;
            about.AboutImage = p.AboutImage;
           
       
            return repoAbout.Update(about);
        }
        public About FindAbout(int id)
        {
            return repoAbout.Find(x => x.AboutID == id);
        }

    }
}
