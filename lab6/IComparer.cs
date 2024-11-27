using System;
using System.Collections.Generic;

public class ТваринаComparer : IComparer<Тварина>
{
    public int Compare(Тварина т1, Тварина т2)
    {
        if (т1 == null || т2 == null)
        {
            throw new ArgumentException("Об'єкти для порівняння не можуть бути null");
        }

        int вагаРезультат = т1.Вага.CompareTo(т2.Вага);
        if (вагаРезультат != 0)
            return вагаРезультат;

        return т1.Зріст.CompareTo(т2.Зріст);
    }
}
