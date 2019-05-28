﻿using System;

namespace _14_ChainOfResponsibility
{
    public class FileLogger : AbstractLogger
    {

        public FileLogger(int level)
        {
            this.level = level;
        }


        protected override void write(string message)
        {
            Console.WriteLine("File::Logger: " + message);
        }
    }
}
