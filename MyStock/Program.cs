using System;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Linq;
using System.Net;
using Microsoft.Data.Analysis;
using Microsoft.VisualBasic;
using MyStock.ConsoleInPut;
using MyStock.Data;
using MyStock.Logic;
using ServiceStack;

namespace MyStock
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.RunProgram();
        }
    }
}
