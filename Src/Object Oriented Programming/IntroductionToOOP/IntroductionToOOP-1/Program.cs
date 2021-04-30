using System;

namespace IntroductionToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post(); 

            post1.Author = "Mustafa Karacabey";
            post1.Description = "This Edcutaion Series is going to be perfect";
            post1.PublishDate = DateTime.Now;
            post1.ImageUrl = "https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2205232?start=15#overview";
            post1.Title = "C-Sharp-Tutorial";

            //post1.ShowPostProperties(post1);


            var post2 = new Post();

            post2.Author = "ZeynepKadir Karacabey";
            post2.Description = "This Edcutaion Series is going to be perfect";
            post2.PublishDate = DateTime.Now;
            post2.ImageUrl = "https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2205232?start=15#overview";
            post2.Title = "C-Sharp-Tutorial";

            //post2.ShowPostProperties(post1);

            Post[] Postlar = new Post[2] { post1, post2 };

            foreach (var post in Postlar)
            {
                Console.WriteLine(post.PublishDate+post.Description+post.ImageUrl+post.Title+post.Author);
                Console.WriteLine("------------------------------------");
            }
        }
    }
}
