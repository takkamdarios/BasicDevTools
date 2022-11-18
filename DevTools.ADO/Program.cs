using DevTools.ADO.Models;
using DevTools.ADO.Repositories.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTools.ADO
{
    internal class Program
    {
        private static readonly CommentRepository _commentRepository = new CommentRepository();
        static void Main(string[] args)
        {
            _commentRepository.Add(new Comment() { Content="my second msg", ContactId = 1});
        }
    }
}
