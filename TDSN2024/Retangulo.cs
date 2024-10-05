using TDSN2024;

 class Retangulo : FormaGeometrica
{
    private double _largura;
    private double _altura;

    public double Largura
    {
        get => _largura;
        set => _largura = value;
    }

    public double Altura
    {
        get => _altura;
        set => _altura = value;
    }

    public override double CalcularArea()
    {
        return _largura * _altura;
    }

    public override double CalcularPerimetro()
    {
        return 2 * (_largura + _altura);
    }

    public override string ToString()
    {
        return base.ToString() + $" (Largura: {_largura}, Altura: {_altura})";
    }
}
