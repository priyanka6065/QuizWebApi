using System;
using System.Collections.Generic;

namespace QuizWebAPI.Models
{
    public partial class Users
    {
        public Users()
        {
            UserQuizzes = new HashSet<UserQuizzes>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Roll { get; set; }

        public virtual ICollection<UserQuizzes> UserQuizzes { get; set; }
    }
}
