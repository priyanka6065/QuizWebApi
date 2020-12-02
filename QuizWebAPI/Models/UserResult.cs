using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizWebAPI.Models
{
    public class UserResult
    {
        [Key]
        public Int64 Id { get; set; }
        public int QuizId { get; set; }

        public string CategoryName { get; set; }

        public int TotalPoint { get; set; }

        public int Results { get; set; }
    }
}
