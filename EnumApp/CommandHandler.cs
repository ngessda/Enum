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
            string userString = insertString.Trim(' ').ToLower();
            int[] values = GetValues();
            switch (userString)
            {
                case "stop":
                    return CommandType.Stop;
                case "insert":
                    return CommandType.Insert;
                case "update":
                    return CommandType.Update;
                case "delete":
                    return CommandType.Delete;
                case "get":
                    return CommandType.Get;
                case "getall":
                    return CommandType.GetAll;
                case "help":
                    return CommandType.Help;
                default:
                    return CommandType.None;
            }
        }
        private static int[] GetValues()
        {
            int[] values = new int[8];
            int counter = 0;
            foreach (int i in Enum.GetValues(typeof(CommandType)))
            {
                values[counter] = i;
                counter++;
            }
            return values;
        }
    }
}
