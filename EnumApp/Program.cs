using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumApp
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
    public class Program
    {
        static void Main(string[] args)
        {
            GetCommand();
            Console.ReadKey();
        }

        static void GetCommand()
        {
            var counter = true;
            while (counter)
            {
                Console.Write("Введите команду: ");
                string test = Console.ReadLine();
                var ch = CommandHandler.GetCommandType(test);
                if (ch == CommandType.Stop)
                    counter = false;
                Console.WriteLine(ch);
            }
        }
    }
}
