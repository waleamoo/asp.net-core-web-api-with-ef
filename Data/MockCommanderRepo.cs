using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        /*
        NB: FILES NOT USEFUL FOR DB CONTEXT

        */
    
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command> 
            {
                new Command{ Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle and Pan"},
                new Command{ Id = 1, HowTo = "Cut bread", Line = "Get a knife", Platform = "Knife and chopping bread"},
                new Command{ Id = 2, HowTo = "Make cup of tea", Line = "Place teabag in cup", Platform = "Kettle and Cup"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{ Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle and Pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}