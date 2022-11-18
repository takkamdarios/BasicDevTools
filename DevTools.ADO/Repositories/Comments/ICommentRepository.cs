using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevTools.ADO.Models; 

namespace DevTools.ADO.Repositories.Comments
{
    internal interface ICommentRepository : IBaseRepository<Comment>
    {
        ICollection<Comment> GetAllByContact(int contactid);
    }
}
