﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Roboto_VideoMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = new UserInput();
            var textRobot = new TextRobot(userInput);
            Console.ReadKey();
        }
    }
}
