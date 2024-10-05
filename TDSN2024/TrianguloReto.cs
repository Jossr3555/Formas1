using System;

namespace TDSN2024
{
    class TrianguloReto : Triangulo
    {
        private double _baseTriangulo;
        private double _altura;

        public double BaseTriangulo
        {
            get => _baseTriangulo;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("A base deve ser maior que zero.");
                _baseTriangulo = value;
            }
        }

        public double Altura
        {
            get => _altura;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("A altura deve ser maior que zero.");
                _altura = value;
            }
        }

        public override double CalcularArea()
        {
            return (_baseTriangulo * _altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return _baseTriangulo + _altura + CalcularHipotenusa();
        }

        public  double CalcularHipotenusa()
        {
            return Math.Sqrt(_baseTriangulo * _baseTriangulo + _altura * _altura);
        }

        public override string ToString()
        {
            return ($"TrianguloReto: (Base: {_baseTriangulo:F2}, Altura: {_altura:F2})").ToString();
        }
    }
}
