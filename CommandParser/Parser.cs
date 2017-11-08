using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParser 
{
    //Contains the parsing logic
    public class Parser
    { 
        private String command
          {get; set;}

        public Parser(){} 


        public Parser(String command)
        {
            this.command = command;
        }

        public List<Command> parseCommand()
        {
            List<Command> retVal = new List<Command>();

            string[] cmds = command.Split(',');

            for(int i = 0; i <= cmds.Length-1; i++)
            {
                StringBuilder sb = new StringBuilder();

                string direction = (string)(new String(cmds[i].Where(Char.IsLetter).ToArray()));

                if(!direction.Equals("left") && !direction.Equals("right") && !direction.Equals("up") 
                    && !direction.Equals("down"))
                {
                     if(direction.Equals("l"))
                        direction = "left";    
                    else if(direction.Equals("r"))
                        direction = "right";
                    else if(direction.Equals("u"))
                        direction = "up";
                    else if(direction.Equals("d"))
                        direction = "down";
                     else
                     {
                        retVal = null;
                        break;
                     }
                }
               
                foreach (char a in cmds[i]) {
  
                    if ((a >= '0' && a <= '9') || a == ' ' || a == '-') {
                        sb.Append(a);
                    }
                }

                int distance = Int32.Parse(sb.ToString());

                Command command = new Command(direction, distance);
                retVal.Add(command);

            }

            return retVal;
        }
    }
}
