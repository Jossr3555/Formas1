using System;

namespace TDSN2024
{
    class Circunferencia : FormaGeometrica
    {
        private double _raio;

        public double Raio
        {
            get => _raio;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("O raio deve ser maior que zero.");
                _raio = value;
            }
        }

        public override double CalcularArea()
        {
            return Math.PI * _raio * _raio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * _raio;
        }

        public override string ToString()
        {
            double area = CalcularArea();
            double perimetro = CalcularPerimetro();
            return ($"Circunferencia: (Raio: {_raio:F2})").ToString(); ;
        }
    }
}
