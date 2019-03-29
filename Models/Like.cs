using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BrightIdeas.Models
{
    public class Like
    {
        // auto-implemented properties need to match the columns in your table
        // the [Key] attribute is used to mark the Model property being used for your table's Primary Key
        [Key]
        public int LikeId { get; set; }
        public int UserId {get;set;}
        public int IdeaId {get;set;}
        public User User {get;set;}
        public Idea Idea {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public Like()
        {
        }
        public Like(int user, int ideaid)
        {
            UserId = user;
            IdeaId = ideaid;
        }
    }
}