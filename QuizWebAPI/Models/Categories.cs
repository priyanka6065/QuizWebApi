using System;
using System.Collections.Generic;

namespace QuizWebAPI.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Questions = new HashSet<Questions>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Questions> Questions { get; set; }
    }
}
