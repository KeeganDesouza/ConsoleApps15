using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The Network class manages the input, ouput and reads out the data added via the classes
    ///</summary>
    ///<author>
    ///  Keegan De souza
    ///  version 0.1
    ///</author> 
    public class NetworkApp
    {   
        private NewsFeed news = new NewsFeed();

        public NewsFeed NewsFeed
        {
            get => default;
            set
            {
            }
        }

        ////<summary>
        ///This is a MainMenu list that displays and
        ///Outputs the heading along with my name
        ///it also holds the if statments to allow the user to choose from.
        ///<summary>
        public void DisplayMenu()
        {
            //choices to choose from the list
            string[] choices = new string[]
            {
                "Post Message", "Post Image","Remove Post", 
                "Display All Posts", "Display By Author", 
                "Add Comment", "Like Posts", "Unlike Posts", "Quit"
            };

            bool wantToQuit = false;

            do
            {
                ConsoleHelper.OutputHeading(" Keegan's News Feed");
                int choice = ConsoleHelper.SelectChoice(choices);

                //choices to choose from based on the numbers
                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: RemovePost(); break;
                    case 4: DisplayAll(); break;
                    case 5: DisplayByAuthor(); break;
                    case 6: AddComment(); break;
                    case 7: LikePosts(); break;
                    case 8: UnlikePosts(); break;
                    case 9: wantToQuit = true; break;
                }

            } while (!wantToQuit);
        }
        ////<summary>
        ///This is a private method that is called out to like users posts through the help of the post ID 
        ///and then display the liked posts to the user.
        ///<summary>
        private void LikePosts()
        {
            ConsoleHelper.OutputTitle("Liked a Post");
            int id = (int)ConsoleHelper.InputNumber(" Please enter the Post ID that you would prefer to Like > ", 
                                                                                   1, Post.GetNumberOfPosts());

            Post post = news.FindPost(id);
            post.Like();

            ConsoleHelper.OutputTitle(" The Post has been Liked");

            post.Display();
        }
        ////<summary>
        ///This is a private method that is called out to Dislike users posts through the help of the post ID 
        ///and then display the Diliked posts to the user.
        ///<summary>
        private void UnlikePosts()
        {
            ConsoleHelper.OutputTitle("Disliked a Post");
            int id = (int)ConsoleHelper.InputNumber(" Please enter the Post ID that you would like to Dislike > ",
                                                                                      1, Post.GetNumberOfPosts());

            Post post = news.FindPost(id);
            post.Unlike();

            ConsoleHelper.OutputTitle(" The Post has been Disliked");
            post.Display();

        }

        /// <summary>
        /// This is a private method used to input comments to a particular post via the help of the post ID.
        /// </summary>
        private void AddComment()
        {
            int id = (int)ConsoleHelper.InputNumber(" Please enter the Post ID that you would like to Comment on > ", 
                                                                                         1, Post.GetNumberOfPosts());
            news.Addpostcomment(id);
        }

        /// <summary>
        /// This is a private method used to input authors name and then output a particular authors posts.
        /// </summary>
        private void DisplayByAuthor()
        {
            ConsoleHelper.OutputTitle($"Displaying By Author");

            Console.Write(" Please enter author name > ");
            string author = Console.ReadLine();
            
            news.Displayauthorsname(author);
        }

        /// <summary>
        /// This is a private method used to remove a post via the help of the post ID.
        /// </summary>
        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($"Removing a Post");

            int id = (int)ConsoleHelper.InputNumber(" Please enter the Post ID you would like to Remove > ",
                                                       1, Post.GetNumberOfPosts());
            news.RemovePost(id);
        }

        /// <summary>
        /// This is a private method used to display all posts that has been stored 
        /// in the news feed class and also whatever input the user adds to the posts.
        /// </summary>
        private void DisplayAll()
        {
            news.Display();
        }

        /// <summary>
        /// This is a private method used to post images
        /// This method outputs the title and asks the user to input the authors name,
        /// filename and caption for the post which is then stored in the news feed post list class
        /// which is then transfer to add photo post method.
        /// </summary>
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
        /// <summary>
        /// This is a private method used to post messages
        /// This method outputs the title and asks the user to input the authors name,
        /// and message post which is then stored in the news feed post list class
        /// which is then transfer to add message posts.
        /// </summary>
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
        /// This private method is used to input name 
        /// where it outputs the authors name and returns it to the author.
        /// </summary>
        private string InputName()
        {
            Console.Write(" Please enter your name > ");
            string author = Console.ReadLine();
            return author;
        }
    }
}

