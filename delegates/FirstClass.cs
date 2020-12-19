// <copyright file="FirstClass.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Delegates
{
    using System;

    /// <summary>
    /// first class of task.
    /// </summary>
    public class FirstClass
    {
        /// <summary>
        /// Delegate for Pow funk.
        /// </summary>
        private Func<double, double, double> delegaDlyaPow;

        /// <summary>
        /// Initializes a new instance of the <see cref="FirstClass"/> class.
        /// </summary>
        public FirstClass()
        {
            this.delegaDlyaPow = this.Pow;
        }

        /// <summary>
        /// Gets delegate.
        /// </summary>
        public Func<double, double, double> DelegatDlyaPow => this.delegaDlyaPow;

        /// <summary>
        /// Gets or sets delegate.
        /// </summary>
        public Action<bool> Delegat { get; set; }

        /// <summary>
        /// multiply of x y.
        /// </summary>
        /// <param name="x">x.</param>
        /// <param name="y">y.</param>
        /// <returns>result.</returns>
        public double Pow(double x, double y)
        {
            var result = x * y;
            return result;
        }
    }
}
