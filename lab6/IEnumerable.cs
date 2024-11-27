using System.Collections;
using System.Collections.Generic;

public class Зоопарк : IEnumerable<Тварина>
{
    private List<Тварина> тварини = new List<Тварина>();

    public void ДодатиТварину(Тварина тварина)
    {
        тварини.Add(тварина);
    }

    public IEnumerator<Тварина> GetEnumerator()
    {
        return тварини.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
