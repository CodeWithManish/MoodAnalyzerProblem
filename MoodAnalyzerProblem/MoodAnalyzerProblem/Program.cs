﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Anayzer Program");
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Sad mood");
            Console.WriteLine("Mood is: " + moodAnalyser.AnalyseMood());
            Console.ReadLine();
        }
    }
}
