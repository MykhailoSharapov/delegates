// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Delegates
{
    using System;

    /// <summary>
    /// Main class of console.
    /// </summary>
    public class Program
    {
        private static void Main(string[] args)
        {
            double multiplierOne = 5;
            double multiplierTwo = 5;
            double ostatOkotDelenia = 5;
            FirstClass fc = new FirstClass();
            SecondClass sc = new SecondClass();
            fc.Delegat = Show;
            fc.Delegat.Invoke(sc.Calc(fc.DelegatDlyaPow, multiplierOne, multiplierTwo).Invoke(ostatOkotDelenia));
        }

        private static void Show(bool res)
        {
            Console.WriteLine(res);
        }
    }
}
