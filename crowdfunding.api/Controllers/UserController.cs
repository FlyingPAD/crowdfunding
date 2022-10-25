using crowdfunding.api.Handlers;
using crowdfunding.api.Models;
using crowdfunding.bll.Entities;
using crowdfunding.cmn.Services;
using Microsoft.AspNetCore.Mvc;

namespace crowdfunding.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// PROPERTIES :
        /// </summary>
        private readonly IUserRepository<User> _repository;
        /* --------------------------------------------------------------------------------------- */
        /// <summary>
        /// CONSTRUCTOR :
        /// </summary>
        /// <param name="repository"></param>
        public UserController(IUserRepository<User> repository)
        {
            this._repository = repository;
        }
        /* --------------------------------------------------------------------------------------- */
        /// <summary>
        /// METHOD : LOGIN
        /// </summary>
        /// <param name="form"></param>
        /// <returns>User</returns>
        [HttpPost("Login")]
        public ActionResult<User> Login([FromBody] UserLogin form)
        {
            try
            {
                User? currentUser = _repository.Login(form.Email, form.Password);
                if (currentUser is null) return NoContent();
                return Ok(currentUser);
            }
            catch (Exception e)
            {
                return BadRequest(new { Message = e.Message });
            }
        }
        /* --------------------------------------------------------------------------------------- */
        /// <summary>
        /// METHOD : REGISTER
        /// </summary>
        /// <param name="form"></param>
        /// <returns>User</returns>
        [HttpPost("Register")]
        public ActionResult<User> Register([FromBody] UserRegister form)
        {
            try
            {
                User? user = _repository.Register(form.ToUser());
                if (user is null) return NoContent();
                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(new { Message = e.Message });
            }
        }
    }
}