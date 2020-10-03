using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommand()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Сварить яйцо", Line = "Вскепятить воду", Platform = "Кострюля" },
                new Command { Id = 1, HowTo = "Нарезать хлеб", Line = "Взять нож", Platform = "Разделочная доска" },
                new Command { Id = 2, HowTo = "Помыть пол", Line = "Налить воду", Platform = "Пол комнаты" },
            };
            return commands;
        }

        public Command GetCommanByID(int id)
        {
            return new Command { Id = 0, HowTo = "Сварить яйцо", Line = "Вскепятить воду", Platform = "Кострюля" };
        }
    }
}
