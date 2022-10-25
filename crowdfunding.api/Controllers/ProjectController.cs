using crowdfunding.bll.Entities;
using crowdfunding.cmn.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace crowdfunding.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        /// <summary>
        /// PROPERTIES
        /// </summary>
        private readonly IProjectRepository<int, Project> _repository;
        /* --------------------------------------------------------------------------------------- */
        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="repository"></param>
        public ProjectController(IProjectRepository<int, Project> repository)
        {
            this._repository = repository;
        }
        /* --------------------------------------------------------------------------------------- */
        /// <summary>
        /// METHOD : GET ALL PROJECTS
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Project>> Get()
        {
            return Ok(_repository.Get());
        }
        /* --------------------------------------------------------------------------------------- */
        /// <summary>
        /// METHOD : GET PROJECT BY ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Project> Get(int id)
        {
            try
            {
                Project? currentProject = _repository.Get(id);
                if (currentProject == null) throw new Exception();
                return Ok(currentProject);
            }
            catch (Exception)
            {
                return NotFound(new { Id = id });
            }
        }
    }
}