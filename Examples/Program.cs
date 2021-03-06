﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples.Plot2D;
using MatplotlibCS;

namespace Examples
{
    /// <summary>
    /// Sample programm which creates several charts and save them in png
    /// </summary>
    class Program
    {
        /// <summary>
        /// Path to python.exe, must be initialized in Main
        /// </summary>
        private static string _pythonExePath;

        /// <summary>
        /// Path to dasPlot.py, script which finally builds plots
        /// </summary>
        private static string _matplotlibPyPath;

        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("You must specify path to python.exe and to matplotlib_cs.py in command line arguments");
                Console.ReadKey();
                return;
            }

            _pythonExePath = args[0];
            _matplotlibPyPath = args[1];

            //ExampleSin.Run(_pythonExePath, _matplotlibPyPath);
            ExampleArс.Run(_pythonExePath, _matplotlibPyPath);
            //ExampleVisibility.Run(_pythonExePath, _matplotlibPyPath);
            //ExampleHistogram.Run(_pythonExePath, _matplotlibPyPath);
            //ExampleTimeAxis.Run(_pythonExePath, _matplotlibPyPath);
            //ExamplePoint2D.Run(_pythonExePath, _matplotlibPyPath);
        }
    }
}
