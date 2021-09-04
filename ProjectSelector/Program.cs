namespace ProjectSelector
{
    using System;
    using System.Collections.Generic;
    using Common;
    using SampleProjectSolution;

    internal static class Program
    {
        private static List<IProject> projects = new List<IProject>()
        {
            new SampleProject(),
            new SampleProject("Challenge Project 2 - accumsan ante in lacus scelerisque"),
            new SampleProject("Challenge Project 3 - felis laoreet congue"),
            new SampleProject("Challenge Project 4 - sodales pharetra risus"),
            new SampleProject("Challenge Project 5 - dignissim blandit ornare"),
            new SampleProject("Challenge Project 6 - tempus sapien sed tellus"),
            new SampleProject("Challenge Project 7 - imperdiet tortor"),
        };

        private static void Main(string[] args)
        {
            LogWelcomeMessage();

            while (true)
            {
                LogMainOptions();
                RequestInstruction();

                var userInput = GetNumericInputFromUser();

                if (userInput == 1)
                {
                    LogProjects();
                }

                if (userInput == 0)
                {
                    break;
                }
            }

            Console.WriteLine("Bye!");
            Console.ReadLine();
        }

        private static void LogMainOptions()
        {
            var optionsList = new List<string>()
            {
                "1 - List all projects",
                "0 - Exit",
            };

            foreach (var option in optionsList)
            {
                Console.WriteLine(option);
            }
        }

        private static void RequestInstruction()
        {
            var rnd = new Random();

            var optionsList = new List<string>()
            {
                "What do you wish to do?",
                "Would you kindly tell me what to do?",
                "What's up doc? Select a number!",
                "What now?",
                "Hurry, select another one!",
                "Another one.",
                "Let's keep working, shall we?",
            };

            Console.WriteLine(optionsList[rnd.Next(0, optionsList.Count)]);
        }

        private static void LogWelcomeMessage()
        {
            Console.WriteLine("Welcome to Meldow's Project Euler console app.");
        }

        private static void LogProjects()
        {
            for (int i = 1; i < projects.Count; i++)
            {
                Console.WriteLine($"[{i}] {projects[i]}");
            }
        }

        private static int GetNumericInputFromUser()
        {
            while (true)
            {
                var inputCommand = Console.ReadLine();
                var parseSuccessful = int.TryParse(inputCommand, out var intCommand);

                if (parseSuccessful)
                {
                    return intCommand;
                }
                else
                {
                    Console.WriteLine("Invalid input command");
                }
            }
        }
    }
}