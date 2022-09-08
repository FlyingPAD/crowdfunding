using crowdfunding.api.Handlers;
using crowdfunding.api.Models;
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
        /* --------------------------------------------------------------------------------------- */
        // - PROPERTIES :
        /* --------------------------------------------------------------------------------------- */
            private readonly IProjectRepository<Project> _repository;
        /* --------------------------------------------------------------------------------------- */
        // - CONSTRUCTOR :
        /* --------------------------------------------------------------------------------------- */
            public ProjectController(IProjectRepository<Project> repository)
            {
                this._repository = repository;
            }
        /* --------------------------------------------------------------------------------------- */
        // - CREATE / POST api/<ProjectController>
        /* --------------------------------------------------------------------------------------- */
            [HttpPost]
            [ProducesResponseType(StatusCodes.Status201Created)]
            public ActionResult Post(ProjectInsert value)
            {
                int newId = _repository.Insert(value.ToProject());
                return CreatedAtAction(nameof(Get), new { id = newId }, newId);
            }
        /* --------------------------------------------------------------------------------------- */
        // - READ ALL / GET: api/<ProjectController>
        /* --------------------------------------------------------------------------------------- */
            [HttpGet]
            [ProducesResponseType(StatusCodes.Status200OK)]
            public ActionResult<IEnumerable<Project>> Get()
            {
                return Ok(_repository.Get());
            }
        /* --------------------------------------------------------------------------------------- */
        // - READ BY ID / GET api/<ProjectController>/5
        /* --------------------------------------------------------------------------------------- */
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
        /* --------------------------------------------------------------------------------------- */
        // - UPDATE / PUT api/<ProjectController>/5
        /* --------------------------------------------------------------------------------------- */
            [HttpPut("{id}")]
            [ProducesResponseType(StatusCodes.Status204NoContent)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            public ActionResult Put(int id, ProjectUpdate value)
            {
                try
                {
                    if (_repository.Get(id) is null) throw new Exception();
                    _repository.Update(id, value.ToProject());
                    return NoContent();
                }
                catch (Exception)
                {
                    return NotFound(new { id = id });
                }
            }
        /* --------------------------------------------------------------------------------------- */
        // - DELETE api/<ProjectController>/5
        /* --------------------------------------------------------------------------------------- */
            [HttpDelete("{id}")]
            [ProducesResponseType(StatusCodes.Status204NoContent)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            public ActionResult Delete(int id)
            {
                try
                {
                    if (_repository.Get(id) is null) throw new Exception();
                    _repository.Delete(id);
                    return NoContent();
                }
                catch (Exception)
                {
                    return NotFound(new { id = id });
                }
            }
    }
}