using System.Data;
using System.Reflection.Metadata;

namespace ConsoleMenu;

class Program
{
    static void Main(string[] args)
    {
        const string CommandExitProgram = "/exit";
        const string CommandOutputDifferentText = "/text";
        const string CommandRandomNumber = "/random";
        const string CommandClearConsole = "/clear";

        const string CommandHelp = "/help"; 

        bool isProgramUsed = true;
        Console.WriteLine($"Welcome the program!\ncommands: {CommandExitProgram}\n{CommandHelp}\n{CommandOutputDifferentText}\n" + 
                            $"{CommandRandomNumber}\n{CommandClearConsole}");

        while(isProgramUsed)
        {
            switch (Console.ReadLine())
            {
                case CommandExitProgram:
                    Console.Clear();   
                    Console.WriteLine("Exiting the program");
                    isProgramUsed = false;
                    break;

                case CommandHelp:
                    Console.WriteLine($"commands: {CommandExitProgram}\n{CommandOutputDifferentText}\n" + 
                                        $"{CommandRandomNumber}\n{CommandClearConsole}");
                        break;

                case CommandOutputDifferentText:
                    Console.WriteLine("Друг мой, друг мой,\n" + 
                                        "Я очень и очень болен.\n" +
                                        "Сам не знаю, откуда взялась эта боль.\n" +
                                        "То ли ветер свистит\n" +
                                        "Над пустым и безлюдным полем,\n" +
                                        "То ль, как рощу в сентябрь,\n" +
                                        "Осыпает мозги алкоголь.");
                    break;

                case CommandRandomNumber:
                    Random random = new Random();
                    int randomNumber = random.Next();
                    Console.WriteLine(randomNumber);
                    break;

                case CommandClearConsole:
                    Console.Clear();
                    Console.WriteLine("Use command /help for show list commands");
                    break;

                default:
                    Console.WriteLine("Unknown command");
                    break;
            }
        }
        
    }
}
