using System;
using System.Collections.Generic;

namespace QuizWebAPI.Models
{
    public partial class UserQuizzes
    {
        public int Id { get; set; }
        public int? QuizId { get; set; }
        public int? UserId { get; set; }
        public int? QuestionId { get; set; }
        public int? AnswerId { get; set; }

        public virtual Answers Answer { get; set; }
        public virtual Questions Question { get; set; }
        public virtual Users User { get; set; }
    }
}
