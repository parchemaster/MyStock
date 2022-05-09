using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class OutPut
    {
        private static int width = Console.WindowWidth / 2;
        public static void PrintMenu()
        {
            String [] menuLine = {"1. Display specific stock"};
            ColorAndStyle.PrintSetedTextPosition(menuLine, width + menuLine.Length / 2, 20);
            Console.Write("Choose your action: ");
        }
    }
}
