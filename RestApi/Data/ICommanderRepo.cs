using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Data
{
    interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommand();
        Command GetCommanByID(int id);
    }
}
