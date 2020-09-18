using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuizWebAPI.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string UserName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string PassWord { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        public ICollection<UserQuiz> UserQuizzes { get; set; }

    }
}
