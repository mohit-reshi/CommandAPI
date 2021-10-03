using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using commandapi.Data;
using commandapi.Models;

namespace commandapi.Controllers
{
    [Route("api/[controller]")]
 [ApiController]
 public class CommandsController : ControllerBase
 {
private readonly IcommandapiRepo _repository;
 public CommandsController(IcommandapiRepo repository)
 {
 _repository = repository;
 }


 [HttpGet]
 public ActionResult<IEnumerable<Command>> GetAllCommands()
 {
     var commandItems = _repository.GetAllCommands();
     return Ok(commandItems);
 }
[HttpGet("{id}")]
public ActionResult<Command> GetCommandById(int id)
{
 var commandItem = _repository.GetCommandById(id);
 if (commandItem == null)
 {
 return NotFound();
 }
 return Ok(commandItem);
}

 //[HttpGet]
 //public ActionResult<IEnumerable<string>> Get()
 //{
 //return new string[] {"this", "is", "hard", "coded"};
 //}
 }
}