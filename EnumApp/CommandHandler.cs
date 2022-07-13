using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumApp
{
    public static class CommandHandler
    {
        public enum CommandType
        {
            None = 0,
            Stop = 10,
            Insert = 20,
            Update = 30,
            Delete = 40,
            Get = 50,
            GetAll = 60,
            Help = 70
        }
        public static int GetCommandType(string insertString)
        {
            string userString = insertString.Trim(' ').ToLower();
            int[] values = GetValues();
            switch (userString)
            {
                case "stop":
                    return values[1];
                case "insert":
                    return values[2];
                case "update":
                    return values[3];
                case "delete":
                    return values[4];
                case "get":
                    return values[5];
                case "getall":
                    return values[6];
                case "help":
                    return values[7];
                default:
                    return values[0];
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
