using System;
using TDSN2024;

class TrianguloIsosceles : Triangulo
{
    private double _base;
    private double _lado;

    public double Base
    {
        get => _base;
        set
        {
            if (value <= 0)
                throw new ArgumentException("A base deve ser maior que zero.");
            _base = value;
        }
    }

    public double Lado
    {
        get => _lado;
        set
        {
            if (value <= 0)
                throw new ArgumentException("O lado deve ser maior que zero.");
            _lado = value;
        }
    }

    public TrianguloIsosceles(double baseTriangulo, double ladoTriangulo)
    {
        Base = baseTriangulo;
        Lado = ladoTriangulo;
    }

    /// <exception cref="ArgumentException">Lançado se o teorema da desigualdade do triângulo for violado ou se os lados forem inválidos.</exception>
    public override double CalcularArea()
    {
        
        if (_lado <= 0 || _base <= 0 || (2 * _lado <= _base))
        {
            throw new ArgumentException("Valores inválidos para formar um triângulo isósceles.");
        }

        double altura = Math.Sqrt(_lado * _lado - (_base / 2) * (_base / 2));

        return (_base * altura) / 2;
    }

    public override double CalcularPerimetro()
    {
        return 2 * _lado + _base;
    }

    public double ObterLado()
    {
        return _lado;
    }

    public override string ToString()
    {
        return ($"TrianguloIsosceles (Base: {_base}, Lado: {_lado})").ToString();
    }
}
