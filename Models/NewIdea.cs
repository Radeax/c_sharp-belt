using System;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models{
    public class NewIdea{
        [Required]
        [MinLength(5, ErrorMessage="Idea must be at least 5 characters")]
        public string Content {get; set;}
    }
}