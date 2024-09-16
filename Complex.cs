using System;

public readonly struct Complex
{
    private readonly double real;
    private readonly double imaginary;

    public Complex(double real = 0, double imaginary = 0)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public static Complex operator +(Complex a, Complex b) => new Complex(a.real + b.real,
                                                                          a.imaginary + b.imaginary);

    public static Complex operator -(Complex a, Complex b) => new Complex(a.real - b.real,
                                                                          a.imaginary - b.imaginary);

    public static Complex operator *(Complex a, Complex b) => new Complex(
        a.real * b.real - a.imaginary * b.imaginary, a.real * b.imaginary - a.real * b.imaginary);

    public static Complex operator /(Complex a, Complex b) => new Complex(
        (a.real * b.real + a.imaginary * b.imaginary) / (a.real * b.real + a.imaginary * b.imaginary),
        (a.real * b.imaginary - a.real * b.imaginary) /
            (a.real * b.real + a.imaginary * b.imaginary));

    public double Abs() => Math.Sqrt(real * real + imaginary * imaginary);

    public double Arg() => Math.Atan(imaginary / real);

    public double Im() => imaginary;

    public double Re() => real;

    public void Print() =>
        Console.WriteLine($"{real} {(imaginary >= 0 ? '+' : '-')} i{Math.Abs(imaginary)}");
}