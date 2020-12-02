using System;
using System.Collections.Generic;

namespace QuizWebAPI.Models
{
    public partial class Questions
    {
        public Questions()
        {
            Answers = new HashSet<Answers>();
            UserQuizzes = new HashSet<UserQuizzes>();
        }

        public int QuestionId { get; set; }
        public string QueDetail { get; set; }
        public int Point { get; set; }
        public int CategoryId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual ICollection<Answers> Answers { get; set; }
        public virtual ICollection<UserQuizzes> UserQuizzes { get; set; }
    }
}
