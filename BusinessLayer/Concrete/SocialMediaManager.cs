using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SocialMediaManager
    {
        Repository<SocialMedia> repoSocial = new Repository<SocialMedia>();

        public List<SocialMedia> GetAll()
        {
            return repoSocial.List();
        }

        public int SocialMediaAddBl(SocialMedia p)
        {
            if (p.SocialMediaName == "" || p.SocialMediaLink == "")
            {
                return -1;
            }
            return repoSocial.Insert(p);

        }

        public int DeleteSocialMediaBL(int p)
        {
            SocialMedia socialMedia = repoSocial.Find(x => x.SocialMediaID == p);
            return repoSocial.Delete(socialMedia);
        }
    }
}
