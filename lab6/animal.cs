using System;

public class Тварина : IComparable<Тварина>
{
    public string Назва { get; set; }
    public double Вага { get; set; }
    public double Зріст { get; set; }

    public Тварина(string назва, double вага, double зріст)
    {
        Назва = назва;
        Вага = вага;
        Зріст = зріст;
    }
    public int CompareTo(Тварина інша)
    {
        if (інша == null) return 1;
        return Вага.CompareTo(інша.Вага);
    }

    public override string ToString()
    {
        return $"{Назва}: Вага = {Вага} кг, Зріст = {Зріст} м";
    }
}
