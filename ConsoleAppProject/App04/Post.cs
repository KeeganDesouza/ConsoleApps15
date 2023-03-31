using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of like, unlike, author. 
    /// Other data, such as author and time, are also stored.
    ///</summary>
    /// <author>
    /// Keegan De souza
    /// @version 0.1
    /// </author>
    public class Post
	{
         public int PostId { get; }

         // username of the post's author
         public String Username { get; }
         public DateTime Timestamp { get; }

         private static int instances = 0;
         private int likes;
         //private int Unlikes;

         private readonly List<String> comments;

         /// <summary>
        /// Constructor for PostID, Timestamps, Likes, Dislike and comments
        /// </summary>
        public Post(string author)
        {
         instances++;
         PostId = instances;

         this.Username = author;
         Timestamp = DateTime.Now;

          likes = 0;
          comments = new List<String>();
        }

        /// <summary>
        /// Record one more 'Like' indication from a user.
        /// </summary>
        public void Like()
        {
          likes++;
        }

        ///<summary>
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
           if (likes > 0)
           {
            likes--;
           }
        }

        ///<summary>
        /// Add a comment to this post.
        /// </summary>
        /// <param name="text">
        /// The new comment to add.
        /// </param>        
        public void AddComment(String text)
        {
            comments.Add(text);
        }

        ///<summary>
        /// Display the details of this post.
        /// 
        /// (Currently: Print to the text terminal. This is simulating display 
        /// in a web browser for now.)
        ///</summary>
        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"    Post ID: {PostId}");
            Console.WriteLine($"    Author: {Username}");
            Console.WriteLine($"    Time Elpased: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine();

            if (likes > 0)
            {
                Console.WriteLine($"    Likes:  {likes}  people liked this.");
            }
            else
            {
                Console.WriteLine("     0 Likes on this post");
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("    No comments.");
            }
            else 
            {
                //Console.WriteLine($"     {comments.Count} Comment(s).");
                foreach (string comment in comments)
                {
                    Console.WriteLine($"    Comment: {comment}");
                }
                    
            }

        }

        ///<summary>
        /// Create a string describing a time point in the past in terms 
        /// relative to current time, such as "30 seconds ago" or "7 minutes ago".
        /// Currently, only seconds and minutes are used for the string.
        /// </summary>
        /// <param name="time">
        ///  The time value to convert (in system milliseconds)
        /// </param> 
        /// <returns>
        /// A relative time string for the given time
        /// </returns>      
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }

        /// <summary>
        /// Returns the number of posts.
        /// </summary>
        public static int GetNumberOfPosts()
        {
            return instances;
        }
    }
}
