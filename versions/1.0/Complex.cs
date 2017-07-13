using System;
namespace System
{
    public class complex
    {
        private double _real, _imaginary;

        public complex() { }

        public complex(double re)
        {
            _real = re;
            _imaginary = 0;
        }

        public complex(double re, double im)
        {
            _real = re;
            _imaginary = im;
        }

        public double real()
        {
            return this._real;
        }

        public double imaginary()
        {
            return this._imaginary;
        }

        public double norm()
        {
            return Math.Sqrt(Math.Pow(_real, 2) + Math.Pow(_imaginary, 2));
        }

        public static complex operator +(complex c1, complex c2)
        {
            complex cmplx = new complex();
            cmplx._real = c1._real + c2._real;
            cmplx._imaginary = c1._imaginary + c2._imaginary;
            return cmplx;
        }

        public static complex operator -(complex c1, complex c2)
        {
            complex cmplx = new complex();
            cmplx._real = c1._real - c2._real;
            cmplx._imaginary = c1._imaginary - c2._imaginary;
            return cmplx;
        }

        public static complex operator *(complex c1, complex c2)
        {
            complex cmplx = new complex();
            cmplx._real = c1._real * c2._real - c1._imaginary * c2._imaginary;
            cmplx._imaginary = c1._imaginary * c2._real + c1._real * c2._imaginary;
            return cmplx;
        }

        public static complex operator /(complex c1, complex c2)
        {
            complex cmplx = new complex();
            cmplx._real = (c1._real * c2._real + c1._imaginary * c2._imaginary) / (Math.Pow(c2._real, 2) + Math.Pow(c2._imaginary, 2));
            cmplx._imaginary = (c1._imaginary * c2._real - c1._real * c2._imaginary) / (Math.Pow(c2._real, 2) + Math.Pow(c2._imaginary, 2));
            return cmplx;
        }

        public complex conjugate()
        {
            complex cmplx = new complex();
            cmplx._real = this._real;
            cmplx._imaginary = (-1) * this._imaginary;
            return cmplx;
        }

        public double angle()
        {
            return Math.Atan(this._imaginary / this._real);
        }

        public complex pow(uint pow)
        {
            complex cmplx = new complex();
            cmplx._real = Math.Pow(this.norm(), pow) * Math.Cos(pow * this.angle());
            cmplx._imaginary = Math.Pow(this.norm(), pow) * Math.Sin(pow * this.angle());
            return cmplx;
        }
    }
}