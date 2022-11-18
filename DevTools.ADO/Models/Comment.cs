using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTools.ADO.Models
{
    internal class Comment : BaseModel
    {
        public int ContactId { get; set; }
        public string Content { get; set; } 
    }
}
