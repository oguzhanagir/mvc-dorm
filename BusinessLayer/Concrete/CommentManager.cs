using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager
    {
        Repository<Comment> repoComment = new Repository<Comment>();

        public List<Comment> GetAll()
        {
            return repoComment.List();
        }

        public List<Comment> CommentByDorm(int id)
        {
            return repoComment.List(x => x.DormID == id);
        }

        public int CommentAdd(Comment c)
        {
            if (c.CommentText =="" || c.CommentName=="")
            {
                return -1;
            }
            return repoComment.Insert(c);
        }

        public int DeleteCommentBL(int p)
        {
            Comment comment = repoComment.Find(x => x.CommentID == p);
            return repoComment.Delete(comment);
        }
    }
}
