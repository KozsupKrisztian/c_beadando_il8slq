using System;
using System.Collections.Generic;

public class TupleCollectionExample
{
    // Különálló osztály adattagja
    private List<(string Name, int Age)> persons;

    public TupleCollectionExample()
    {
        // Tuple gyűjtemény inicializálása
        persons = new List<(string Name, int Age)>
        {
            ("Alice", 30),
            ("Bob", 25),
            ("Charlie", 35),
            ("David", 40),
            ("Eva", 28),
            ("Frank", 33),
            ("Grace", 22),
            ("Helen", 29),
            ("Ivy", 27),
            ("Jack", 32),
            ("Karen", 31),
            ("Liam", 24),
            ("Mia", 26),
            ("Nina", 34),
            ("Oliver", 37),
            ("Pam", 36),
            ("Quinn", 23),
            ("Rachel", 38),
            ("Steve", 39),
            ("Tina", 21)
        };
    }

    // 1. Count tulajdonság
    // Kiírja a gyűjteményben lévő személyek számát
    public void PrintCount()
    {
        Console.WriteLine($"személyek száma: {persons.Count}");
    }

    // 2. Add metódus
    // Hozzáad egy új személyt a gyűjteményhez
    public void AddPerson((string Name, int Age) person)
    {
        persons.Add(person);
    }

    // 3. Remove metódus
    // Eltávolít egy személyt a gyűjteményből
    public void RemovePerson((string Name, int Age) person)
    {
        persons.Remove(person);
    }

    // 4. Contains metódus
    // Ellenőrzi, hogy egy adott személy létezik-e a gyűjteményben
    public void CheckPersonExists((string Name, int Age) person)
    {
        if (persons.Contains(person))
        {
            Console.WriteLine($"{person.Name} benne van a gyűjteményben.");
        }
        else
        {
            Console.WriteLine($"{person.Name} nincs benne a gyűjteméyybe.");
        }
    }

    // 5. FindAll metódus
    // Megkeresi és kiírja azokat a személyeket, akik 30 évnél idősebbek
    public void FindAllPersonsOver30()
    {
        var personsOver30 = persons.FindAll(p => p.Age > 30);
        Console.WriteLine("Személyek 30 fölött:");
        foreach (var person in personsOver30)
        {
            Console.WriteLine($"{person.Name}, {person.Age}");
        }
    }

    // 6. Sort metódus
    // Rendezve kiírja a személyeket név szerint
    public void SortPersonsByName()
    {
        persons.Sort((x, y) => x.Name.CompareTo(y.Name));
        Console.WriteLine("Személyek neve szerint rendezve:");
        foreach (var person in persons)
        {
            Console.WriteLine($"{person.Name}, {person.Age}");
        }
    }

    // Generikus metódus: Keresés név alapján
    // Megkeresi és kiírja a keresett névvel rendelkező személyt
    public void FindPersonByName<T>(T name)
    {
        var person = persons.Find(p => p.Name.Equals(name.ToString(), StringComparison.OrdinalIgnoreCase));
        if (person.Equals(default((string, int))))
        {
            Console.WriteLine();
            Console.WriteLine($"Személy neve nem található: '{name}'.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("A személy neve megtalálható a listában:");
            Console.WriteLine($"{person.Name}, {person.Age}");
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TupleCollectionExample example = new TupleCollectionExample();

        example.PrintCount(); // Személyek számának kiírása
        Console.WriteLine();
        example.AddPerson(("Sam", 29)); // Új személy hozzáadása
        example.PrintCount(); // Személyek számának kiírása
        Console.WriteLine();
        example.RemovePerson(("Eva", 28)); // Személy eltávolítása
        example.PrintCount(); // Személyek számának kiírása
        Console.WriteLine();
        example.CheckPersonExists(("Bob", 25)); // Személy létezésének ellenőrzése
        example.CheckPersonExists(("Lucy", 26)); // Személy létezésének ellenőrzése
        Console.WriteLine();
        example.FindAllPersonsOver30(); // 30 év feletti személyek keresése és kiírása
        Console.WriteLine();
        example.SortPersonsByName(); // Személyek rendezése név szerint és kiírása
        Console.WriteLine();
        example.FindPersonByName("Alice"); // Alice személy keresése és adatainak kiírása
        example.FindPersonByName("Lucy"); // Lucy személy keresése és adatainak kiírása
    }
}
