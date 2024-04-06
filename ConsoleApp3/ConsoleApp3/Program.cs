using Core;
using Core.Models;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Blog blog = new Blog();
            blog.Title= "Title1";
            blog.Description = "Description1";
            string answer;
            do
            {
                Console.WriteLine("1 Create comment\r\n" +
                    "2 See comments\r\n" +
                    "3 See comment\r\n" +
                    "4 Remove comment\r\n" +
                    "5 Update comment\r\n" +
                    "0. Proqramdan çıx");
                answer = Console.ReadLine();
                if(answer =="1")
                {
                    Console.WriteLine("Enter comment content:");
                    string Content= Console.ReadLine();
                    Comment comment = new Comment(Content);
                    blog.AddComment(comment);
                }
                else if(answer=="2")
                {
                   blog.GetAllComments();
                }
                else if(answer=="3")
                {
                    Console.WriteLine("Enter ID:");
                    int Id=Convert.ToInt32(Console.ReadLine());
                    blog.GetComment(Id);

                }
                else if(answer=="4")
                {
                    Console.WriteLine("Enter ID:");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    blog.RemoveComment(Id);
                }
                else if(answer=="5")
                {
                    Comment comment0 = new Comment();
                    Console.WriteLine("Enter comment content:");
                    comment0.Content = Console.ReadLine();
                    Console.WriteLine("Enter comment id:");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    blog.UpdateComment(Id,comment0);
                }
                Console.WriteLine("-------------------\n");
            } 
            while (answer!="0");

        }
    }
}
