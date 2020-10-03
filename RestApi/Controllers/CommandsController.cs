using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApi.Data;
using RestApi.Models;

namespace RestApi.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;
        private CommanderContext db;

        public CommandsController(ICommanderRepo repository, CommanderContext context)
        {
            _repository = repository;
            db = context;
        }

        //private readonly ICommanderRepo _repository = new MockCommanderRepo();
        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var CommandItems = _repository.GetAllCommand();
            return Ok(CommandItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var CommandItem = _repository.GetCommanByID(id);
            return Ok(CommandItem);
        }

    }
}
