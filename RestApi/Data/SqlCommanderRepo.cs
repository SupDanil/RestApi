using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }
        public IEnumerable<Command> GetAllCommand()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommanByID(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}
