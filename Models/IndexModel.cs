using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models{
    public class IndexModel{
        public List<Idea> Ideas {get;set;}
        public Idea NewIdea {get;set;}
    }
}