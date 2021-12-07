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
        public double Re { get; set; }
        public double Im { get; set; }

        public Complex(double re, double im)
        {
            this.Re = re;
            this.Im = im;
        }

        public Complex Plus(Complex a) => new Complex(this.Re + a.Re, this.Im + a.Im);

        public Complex Minus(Complex a) => new Complex(this.Re - a.Re, this.Im - a.Im);

        public double Modulus => Math.Sqrt(Math.Pow(this.Re, 2) + Math.Pow(this.Im, 2));

        public double Phase => Math.Acos(this.Re);
    }
}