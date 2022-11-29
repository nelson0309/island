using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using WebApplication1.Dtos;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTable1Controller : ControllerBase
    {
        private readonly IslandContext _islandContext;

        public UserTable1Controller(IslandContext islandContext)
        {
            _islandContext = islandContext;
        }

        [HttpGet]
        public IEnumerable<UserTable1> Get(string? name, int? UserId, DateTime? ChangeTime)
        {
            var result = _islandContext.UserTable1s
                .Select(a => new UserTable1
                {
                    UserId = a.UserId,
                    UserName = a.UserName,
                    UserSex = a.UserSex,
                    Email = a.Email,
                    Phone = a.Phone,
                    CellPhone = a.CellPhone,
                    Area = a.Area,
                    Ability = a.Ability,
                    UseState=a.UseState,
                    CreateTime=a.CreateTime,
                    Modifier=a.Modifier,
                    ChangeTime=a.ChangeTime
                });

            if (!string.IsNullOrWhiteSpace(name))
            {
                result = result.Where(a => a.UserName.Contains(name));
            }
            if (UserId != null)
            {
                result = result.Where(a => a.UserId == UserId);
            }

            if (ChangeTime != null)
            {
                result = result.Where(a => a.ChangeTime.Date == ChangeTime);
            }

            return result;
        }

        // POST api/<UserTable1Controller>
        [HttpPost]
        public ActionResult<UserTable1> Post([FromBody] UserTable1 usertable1)
        {
            _islandContext.UserTable1s.Add(usertable1);
            _islandContext.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = usertable1.UserId }, usertable1);
        }

        // PUT api/<UserTable1Controller>/
        [HttpPut("{UserId}")]
        public IActionResult Put(int UserId, [FromBody] UserTable1 usertable1)
        {
            if (UserId != usertable1.UserId)
            {
                return BadRequest();
            }

            _islandContext.Entry(usertable1).State = EntityState.Modified;

            try
            {
                _islandContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_islandContext.UserTable1s.Any(e => e.UserId == UserId))
                {
                    return NotFound();
                }
                else
                {
                    return StatusCode(500, "存取發生錯誤");
                }
            }
            return Ok();

        }

        // DELETE api/<UserTable1Controller>/5
        [HttpDelete("{UserId}")]
        public IActionResult Delete(int UserId)
        {
            var result = _islandContext.UserTable1s.Find(UserId);

            if (result == null)
            {
                return NotFound();
            }

            _islandContext.UserTable1s.Remove(result);
            _islandContext.SaveChanges();

            return NoContent();

        }




    }
}
