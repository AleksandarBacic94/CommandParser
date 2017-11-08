using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParser
{
    public class Program 
    {
        static void Main(string[] args)
        { 
            String a1 = "lx20,r32,d1,u12";
            String a2 = "22,r3,d11,u32";
            String a3 = "l10,r22,14,u11";
            String a4 = "x2z,r32,d1,u12";
            String a5 = "l24,r35,dx11y,u16";
            String a6 = "l20,rr32,d1,u12"; 
            String a7 = "lx20,r32,d1,tu12";
          

         
            List<String> commands = new List<String>
            {
                a1,a2,a3,a4,a5,a6,a7
            };

            List<BadCommand> badCommands = new List<BadCommand>();

          
            foreach(String s in commands){

                
                Parser parser = new Parser(s);
                List<Command> command = parser.parseCommand();

                if (!parser.badCmd)
                {
                    foreach (Command a in command)
                    {
                        Console.WriteLine(a.ToString());
                    }
                }
                else 
                {
                    BadCommand bc = new BadCommand(s, "Invalid Command");
                    badCommands.Add(bc);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to see bad commands!");
            Console.ReadLine();
            foreach(BadCommand bc in badCommands)
            {
                   Console.WriteLine(bc.ToString()); 
            }

            Console.ReadLine();

            
        }
    }
}
