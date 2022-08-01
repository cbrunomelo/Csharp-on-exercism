using System;
using System.Collections.Generic;
using System.Linq;
public enum Allergen
{
    Eggs = 1 << 0, //1
    Peanuts = 1 << 1, //2
    Shellfish = 1 << 2, //4
    Strawberries = 1 << 3, //8
    Tomatoes = 1 << 4, //16
    Chocolate = 1 << 5, //32
    Pollen = 1 << 6, //64
    Cats = 1 << 7 //128
}
public class Allergies
{
    private readonly int _score;

    public Allergies(int mask)
    {
        _score = mask;
    }
    public bool IsAllergicTo(Allergen allergen)
    {
        return ((_score & (int)allergen) == (int)allergen);
    }
    public Allergen[] List()
    {
        /*List<Allergen> AList = new List<Allergen>();
		foreach(Allergen value in Enum.GetValues(typeof(Allergen)))
		{
			if (IsAllergicTo(value))
			{
				AList.Add(value);
			}
		}
		return AList.ToArray();*/

        return (Enum.GetValues(typeof(Allergen)))
        .Cast<Allergen>()
        .Where(value => IsAllergicTo(value))
        .ToArray();
    }
}