using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParser
{
    class BadCommand
    {
        private String command { get; set; }
        private String message { get; set; }

        public BadCommand() { } 

        public BadCommand(String command, String message)
        {
            this.command = command;
            this.message = message;
        }

        public override string ToString()
        {
            return "Command: " + command.ToString() + "; Message: " + message;
        }
    }
}