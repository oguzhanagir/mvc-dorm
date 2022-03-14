using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsManager
    {
        Repository<News> repoNew = new Repository<News>();
        public List<News> GetAll()
        {
            return repoNew.List();
        }

        public int NewsAddBl(News p)
        {
            if (p.NewsTitle == "" || p.NewsLink == "" )
            {
                return -1;
            }
            return repoNew.Insert(p);

        }

        public int DeleteNewsBL(int p)
        {
            News news = repoNew.Find(x => x.NewsID == p);
            return repoNew.Delete(news);
        }
    }
}
