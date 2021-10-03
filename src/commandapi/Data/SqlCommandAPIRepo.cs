using System.Collections.Generic;
using commandapi.Models;
using System.Linq;
namespace commandapi.Data
{
    public class SqlCommandAPIRepo : IcommandapiRepo
    {
        private readonly CommandContext _context;
    public SqlCommandAPIRepo(CommandContext context)
    {
        _context = context;
    }
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
            return _context.CommandItems.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.CommandItems.FirstOrDefault(p=>p.Id == id);
          
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