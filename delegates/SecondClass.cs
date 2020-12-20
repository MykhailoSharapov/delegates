// <copyright file="SecondClass.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Delegates
{
    using System;

    /// <summary>
    /// second class of task.
    /// </summary>
    public class SecondClass
    {
        private double powResult;

        /// <summary>
        /// Calculating funk from task.
        /// </summary>
        /// <param name="deleg">Delegate.</param>
        /// <param name="x">x.</param>
        /// <param name="y">y.</param>
        /// <returns>result.</returns>
        public Predicate<double> Calc(Func<double, double, double> deleg, double x, double y)
        {
            this.powResult = deleg(x, y);
            return this.Result;
        }

        private bool Result(double x)
        {
            return this.powResult % x == 0;
        }
    }
}
