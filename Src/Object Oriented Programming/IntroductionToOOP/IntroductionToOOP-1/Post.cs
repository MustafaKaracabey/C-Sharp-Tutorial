using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToOOP
{
    public class Post
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }


        public void ShowPostProperties(Post post)
        {
            Console.WriteLine($" Author: {post.Author} \n Title: {post.Title} \n Image: {post.ImageUrl} \n Description: {post.Description} \n DateTime: {post.PublishDate}");
        }
    }
}
