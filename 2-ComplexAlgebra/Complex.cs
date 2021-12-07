using System;

namespace ComplexAlgebra
{
    /// <summary>
    /// A type for representing Complex numbers.
    /// </summary>
    ///
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * instantiating complex numbers
    /// TODO: * accessing a complex number's real, and imaginary parts
    /// TODO: * accessing a complex number's modulus, and phase
    /// TODO: * complementing a complex number
    /// TODO: * summing up or subtracting two complex numbers
    /// TODO: * representing a complex number as a string or the form Re +/- iIm
    /// TODO:     - e.g. via the ToString() method
    /// TODO: * checking whether two complex numbers are equal or not
    /// TODO:     - e.g. via the Equals(object) method
    public class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public Complex(double real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public Complex Plus(Complex a) => new Complex(this.Real + a.Real, this.Imaginary + a.Imaginary);

        public Complex Minus(Complex a) => new Complex(this.Real - a.Real, this.Imaginary - a.Imaginary);

        public double Modulus => Math.Sqrt(Math.Pow(this.Real, 2) + Math.Pow(this.Imaginary, 2));

        public double Phase => Math.Acos(this.Real);

        public Complex Complement() => new Complex(this.Real, -this.Imaginary);

        public override string ToString()
        {
            return this.Imaginary == 0
                ? this.Real.ToString()
                : (Real == 0 ? "" : Real.ToString()) 
                  + (Real != 0 && Imaginary > 0 ? "+" : "") 
                  + (Imaginary == 1 ? "" : (Imaginary == -1 ? "-" : Imaginary.ToString())) + "i";
        }
    }
}