﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizWebAPI.Models
{
    public class UserQuiz
    {
        [Key]
        public int Id { get; set; }

        public int QuizId { get; set; }

        public int UserId { get; set; }

        public int QuestionId { get; set; }

        public int AnswerId { get; set; }

        public virtual User User { get; set; }

        public virtual Question Question { get; set; }

        public virtual Answer Answer { get; set; }
    }
}
