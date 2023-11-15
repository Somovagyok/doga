using System;
public class NegyszogClass
{
    private double oldal1;
    private double oldal2;
    private double terulet;
    private double kerulet;

    public NegyszogClass()
    {

    }
    public NegyszogClass(double a)
    {
        SetOldal1(a);
        SetTerulet();
        SetKerulet();
    }
    public NegyszogClass(double a, double b)
    {
        SetOldal2(a, b);
        SetTerulet();
        SetKerulet();
    }

    public void SetOldal1(double a)
    {
        if (a <= 0)
        {
            throw new ArgumentException("Az oldal hossza nem lehet negatív vagy nulla.");
        }
        oldal1 = a;
    }
    public void SetOldal2(double a, double b)
    {
        if (a <= 0 || b <= 0)
        {
            throw new ArgumentException("Az oldal hossza nem lehet negatív vagy nulla.");
        }
        oldal1 = a;
        oldal2 = b;
    }
    public void SetTerulet()
    {
        terulet = oldal1 * oldal2;
    }
    public void SetKerulet()
    {
        kerulet = 2 * (oldal1 + oldal2);
    }
    public double GetTerulet()
    {
        return terulet;
    }
    public double GetKerulet()
    {
        return kerulet;
    }
}
