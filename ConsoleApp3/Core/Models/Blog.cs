using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.Models
{
    public class Blog
    {
        public static int id { get; set; }
        public int Id { get; set; }
        private string _title;
        private string _description;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length > 5)
                {
                    _title = value;
                }
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value.Length > 8)
                {
                    _description = value;
                }
            }
        }
        Comment[] comments = {};
        public Blog()
        {
            comments = new Comment[0];
        }
        public Blog(string title, string description)
        {
            id++;
            Id = id;
            Title=title;
            Description=description;
        }
        public override string ToString()
        {
            return $"Title:{Title}, Description:{Description}";
        }
        public void AddComment(Comment comment)
        {
            Array.Resize(ref comments, comments.Length+1);
            comments[comments.Length-1] = comment;
        }
        public void GetAllComments()
        {
            for (int i = 0; i < comments.Length; i++) 
            {
                Console.WriteLine(comments[i].ToString());
            }
        }
        public void GetComment(int id) 
        {
            for (int i = 0; i < comments.Length; i++)
            {
                if (comments[i].Id == id)
                {
                    Console.WriteLine(comments[i].ToString());
                }
            }
        }
        public Comment[] RemoveComment(int id)
        {
            Comment[] rcomments = new Comment[0];
            for (int i = 0; i < comments.Length; i++)
            {
                if(comments[i].Id != id)
                {
                    Array.Resize(ref rcomments, rcomments.Length + 1);
                    rcomments[rcomments.Length - 1] = comments[i];
                    

                }
            }
            comments = rcomments;
            return rcomments;
        }
        public void UpdateComment(int id, Comment comment)
        {
            for(int i = 0;i < comments.Length;i++) 
            {
                //AddComment(comment);
               if( comment.Id == comments[i].Id);
                comments[i]= comment;
                break;
            }
            GetAllComments();
        }

    }
}
