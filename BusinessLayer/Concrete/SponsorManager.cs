using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SponsorManager
    {
        Repository<Sponsor> repoSponsor = new Repository<Sponsor>();
        public List<Sponsor> GetAll()
        {
            return repoSponsor.List();
        }

        public int SponsorAddBl(Sponsor p)
        {
            if (p.SponsorName == "" || p.SponsorLink == "" || p.SponsorImage == "")
            {
                return -1;
            }
            return repoSponsor.Insert(p);

        }

        public int DeleteSponsorBL(int p)
        {
            Sponsor sponsor = repoSponsor.Find(x => x.SponsorID == p);
            return repoSponsor.Delete(sponsor);
        }
    }
}
