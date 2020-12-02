using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using QuizWebAPI.Models;

namespace QuizWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserQuizzesController : ControllerBase
    {
        private readonly QuizDbContext _context;

        public UserQuizzesController(QuizDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserQuiz>>> GetUserQuizzes()
        {
            return await _context.UserQuizzes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserQuiz>> GetUserQuiz(int id)
        {
            var userquiz = await _context.UserQuizzes.FindAsync();

            if (userquiz == null)
            {
                return NotFound();
            }
            return userquiz;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserQuiz(int id, UserQuiz userQuiz)
        {
            if (id != userQuiz.Id)
            {
                return BadRequest();
            }

            _context.Entry(userQuiz).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserQuizExita(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();

        }

        [HttpPost]
        public async Task<ActionResult<UserQuiz>> PostUserQuiz(UserQuiz[] userQuizzes)
        {

            for (int i = 0; i < userQuizzes.Length; i++)
            {
                UserQuiz userQuiz = userQuizzes[i];
                _context.UserQuizzes.Add(userQuiz);
                await _context.SaveChangesAsync();
            }


            return CreatedAtAction("GetUserQuizzes", null);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<UserQuiz>> DeleteUserQuiz(int id)
        {
            var userquiz = await _context.UserQuizzes.FindAsync(id);
            if (userquiz == null)
            {
                return NotFound();
            }

            _context.UserQuizzes.Remove(userquiz);
            await _context.SaveChangesAsync();

            return userquiz;
        }

        private bool UserQuizExita(int id)
        {
            return _context.UserQuizzes.Any(e => e.Id == id);
        }

        [HttpGet("{userId}")]
        [Route("GetResultsByUserId/{userId}")]
        public async Task<IEnumerable<UserResult>> GetResultsByUserId(int userId)
        {
            var param = new SqlParameter("@UserId", 2);

            var students =  await _context.Results.FromSqlRaw("EXEC GetResultsByUserId @UserId={0}", userId).ToListAsync();
            //if (students == null)
            //{
            //    return NotFound();
            //}
            return students;
        }
    }
}

