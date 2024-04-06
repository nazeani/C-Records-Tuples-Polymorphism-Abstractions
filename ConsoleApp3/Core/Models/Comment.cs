using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Comment
    {
        public static int id { get; set; }
        public int Id {  get; set; }
        public string Content;
        public override string ToString()
        {
            return $"Id:{Id}, Content:{Content}" ;
        }
        public Comment()
        {
            
        }
        public Comment(string content)
        {
            id++;
            Id=id;
            Content = content;
        }
    }
}
