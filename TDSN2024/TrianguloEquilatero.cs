using System;
using TDSN2024;

 class TrianguloEquilatero : Triangulo
{
    private double _lado;

    public double Lado
    {
        get => _lado;
        set => _lado = value;
    }

    public override double CalcularArea()
    {
        return (Math.Sqrt(3) / 4) * _lado * _lado;
    }

    public override double CalcularPerimetro()
    {
        return 3 * _lado;
    }

    public double CalcularHipotenusa()
    {
        return _lado; 
    }

    public override string ToString()
    {
        return ($"TrianguloEquilatero: (Lado: {_lado})").ToString();
    }
}
