using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumApp
{
    public static class CommandHandler
    {
        public static CommandType GetCommandType(string insertString)
        {
            string userString = insertString.Trim().ToLower();
            CommandType commandType = CommandType.None;
            switch (userString)
            {
                case "stop":
                    commandType = CommandType.Stop;
                    break;
                case "insert":
                    commandType = CommandType.Insert;
                    break;
                case "update":
                    commandType = CommandType.Update;
                    break;
                case "delete":
                    commandType = CommandType.Delete;
                    break;
                case "get":
                    commandType = CommandType.Get;
                    break;
                case "getall":
                    commandType = CommandType.GetAll;
                    break;
                case "help":
                    commandType = CommandType.Help;
                    break;
                default:
                    break;
            }
            return commandType;
        }
    }
}
