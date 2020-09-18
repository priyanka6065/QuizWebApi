using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuizWebAPI.Models
{
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string AnsOptions { get; set; }

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public ICollection<UserQuiz> UserQuizzes { get; set; }
    }
}
