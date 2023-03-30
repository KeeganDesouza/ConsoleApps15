using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {   
        private NewsFeed news = new NewsFeed();
        /// <summary>
        /// 
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading(" Keegan's News Feed");
            string[] choices = new string[]
            {
                "Post Message", "Post Image","Remove Post", 
                "Display All Posts", "Display By Author", 
                "Display By Date", "Add Comment", "Like Posts", "Quit"
            };

            bool wantToQuit = false;

            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: RemovePost(); break;
                    case 4: DisplayAll(); break;
                    case 5: DisplayByAuthor(); break;
                    case 6: DisplayByDate(); break;
                    case 7: AddComment(); break;
                    case 8: LikePosts(); break;
                    case 9: wantToQuit = true; break;
                }

            } while (!wantToQuit);
        }

        private void LikePosts()
        {
            ConsoleHelper.OutputTitle("Liked a Post");
            int id = (int)ConsoleHelper.InputNumber("please enter the post id > ", 1, Post.GetNumberOfPosts());

            Post post = news.FindPost(id);
            post.Like();

            ConsoleHelper.OutputTitle("The post has been liked");

            post.Display();
        }

        private void UnlikePosts()
        {
            ConsoleHelper.OutputTitle("Disliked a Post");
            int id = (int)ConsoleHelper.InputNumber("please enter the post id > ", 0, Post.GetNumberOfPosts());

            Post post = news.FindPost(id);
            post.Unlike();

            ConsoleHelper.OutputTitle("The post has been Disliked");
            post.Display();

        }

        private void AddComment()
        {
            int id = (int)ConsoleHelper.InputNumber(" please enter the post id > ",
                                                       1, Post.GetNumberOfPosts());

            news.Addpostcomment(id);
        }

        private void DisplayByDate()
        {
            throw new NotImplementedException();
        }

        private void DisplayByAuthor()
        {
            ConsoleHelper.OutputTitle($"Displaying By Author");

            Console.Write(" Please enter author name > ");
            string author = Console.ReadLine();
            
            news.Displayauthorsname(author);
        }

        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($"Removing a Post");

            int id = (int)ConsoleHelper.InputNumber(" please enter the post id > ",
                                                       1, Post.GetNumberOfPosts());
            news.RemovePost(id);
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void PostImage()
        {
            ConsoleHelper.OutputTitle("Posting an image/photo");
            string author = InputName();

            Console.Write(" Please enter your image filename > ");
            string filename = Console.ReadLine();

            Console.Write(" Please enter your image caption > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OutputTitle("You have just posted this image:");
            post.Display();
        }

        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Posting an Message");
            string author = InputName();

            Console.Write(" Please enter your message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            ConsoleHelper.OutputTitle(" You have just posted this message:");
            post.Display();
        }

        /// <summary>
        /// 
        /// </summary>
        private string InputName()
        {
            Console.Write(" Please enter your name > ");
            string author = Console.ReadLine();
            return author;
        }
    }
}

