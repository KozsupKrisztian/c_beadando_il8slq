using C__beadando;
using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        Tuple_osztaly tupleCollection = new Tuple_osztaly();
        tupleCollection.FillData();

        // Teszteljük a TupleCollection osztály metódusait és tulajdonságait
        Console.WriteLine($"Tuple gyűjtemény hossza: {tupleCollection.Count}");
        Console.WriteLine($"Első tuple értékei: {tupleCollection.GetFirstTupleValues()}");
        Console.WriteLine($"Utolsó tuple értékei: {tupleCollection.GetLastTupleValues()}");
        Console.WriteLine($"Második tuple harmadik eleme: {tupleCollection.GetThirdElementOfSecondTuple()}");
        Console.WriteLine($"Ötödik tuple második eleme: {tupleCollection[4].Item2}");
        Console.WriteLine($"Van-e 'apple' az adatok között: {tupleCollection.ContainsItem("apple")}");
        Console.WriteLine($"Legnagyobb érték: {tupleCollection.GetMaxValue()}");
        tupleCollection.ProcessTuple(tupleCollection[1]);

    }
}
