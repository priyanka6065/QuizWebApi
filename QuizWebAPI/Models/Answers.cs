using System;
using System.Collections.Generic;

namespace QuizWebAPI.Models
{
    public partial class Answers
    {
        public Answers()
        {
            UserQuizzes = new HashSet<UserQuizzes>();
        }

        public int AnswerId { get; set; }
        public string AnsOptions { get; set; }
        public bool IsCorrect { get; set; }
        public int QuestionId { get; set; }

        public virtual Questions Question { get; set; }
        public virtual ICollection<UserQuizzes> UserQuizzes { get; set; }
    }
}
