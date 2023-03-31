using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    /// Keegan De souza
    /// version 0.1
    ///</author> 
    public class NewsFeed
    {
        //Constant 
        public const string AUTHOR = "Keegan";
        private readonly List<Post> posts;

        ///<summary>
        /// Constructed a premade news feed.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();
            MessagePost post = new MessagePost(AUTHOR, "I love Visual studio 2022");
            AddMessagePost(post);

            PhotoPost photoPost = new PhotoPost(AUTHOR, "Photo1.jpg", "Visual Studio 2022");
            AddPhotoPost(photoPost);
        }


        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        ///<summary>
        ///Removes the post from the news feed.
        ///where it uses if statments to check if the post id exist 
        ///if it does not exist it outputs a prompt else if does exist it uses 
        ///the post id to remove the post and prompts the user that the post has been 
        ///removed afurthermore it also checks if its an message post or photo post and removes it from 
        ///news feed class.
        /// </summary>
        public void RemovePost(int id)
        {
            Post post = FindPost(id);
            if (post == null)
            {
                Console.WriteLine($" \nPost with ID = {id} does not exist!!\n");
            }
            else
            {
                Console.WriteLine($" \n The following Post = {id} has been removed!\n");

                if(post is MessagePost mp)
                {
                    mp.Display();
                }
                else if(post is PhotoPost pp)
                {
                    pp.Display();
                }
                posts.Remove(post);
                
            }
        }

        ///<summary>
        /// this is a public method used to find the posts 
        /// where "for each statments" and "if statments" are used to find the post via 
        /// the help of post id and return it to posts.
        /// </summary>
        public Post FindPost(int id) 
        {
            foreach(Post post in posts) 
            {
                if(post.PostId == id)
                {
                    return post;
                }
            }
            return null;
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal.
        ///</summary>
        public void Display()
        {
            ConsoleHelper.OutputTitle("Displaying All Posts");
            // display all text posts
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine();   // empty line between posts
            }
        }

        ///<summary>
        /// inputs the name of the authors and uses for each statments to get 
        /// Posts elements to get the authors name and display its post.
        ///</summary>
        public void Displayauthorsname(string author)
        {
            // display all text posts
            foreach (Post post in posts)
            {
                if (post.Username == author)
                post.Display();
                Console.WriteLine();
            }   
        }
        ///<summary>
        /// inputs the comment to a post and uses for each statments to get 
        /// Posts elements to get the posts id and adds comment to the post.
        ///</summary>
        public void Addpostcomment(int id)
        {
            // display comment
            foreach (Post post in posts)
            {
                if (post.PostId == id)
                {
                    Console.Write(" Add your comment here > ");
                    string comment = Console.ReadLine();
                    post.AddComment(comment);
                    Console.WriteLine();
                }
                
            }

        }    
    }
 }


