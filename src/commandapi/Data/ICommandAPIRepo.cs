using System.Collections.Generic;
using commandapi.Models;

namespace commandapi.Data
{
 public interface IcommandapiRepo
 {
 bool SaveChanges();
 IEnumerable<Command> GetAllCommands();
 Command GetCommandById(int id);
 void CreateCommand(Command cmd);
 void UpdateCommand(Command cmd);
 void DeleteCommand(Command cmd);
 }
}