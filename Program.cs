using System;

//Задача 3. Создайте класс "StringCollection", представляющий коллекцию строк. 
//Реализуйте индексатор, который позволяет получать и задавать элементы коллекции по индексу. 
//Создайте объект типа "StringCollection" и добавьте несколько строк. 
//Затем выведите некоторые строки, используя индексатор.

StringCollection collection = new StringCollection();

collection.Add("Two households, both alike in dignity,");
collection.Add("In fair Verona, where we lay our scene,");
collection.Add("From ancient grudge break to new mutiny,");
collection.Add("Where civil blood makes civil hands unclean.");
collection.Add("From forth the fatal loins of these two foes");
collection.Add("A pair of star-cross’d lovers take their life;");
collection.Add("Whose misadventured piteous overthrows");
collection.Add("Do with their death bury their parents’ strife.");
collection.Add("The fearful passage of their death-mark’d love,");
collection.Add("And the continuance of their parents’ rage,");
collection.Add("Which, but their children’s end, nought could remove,");
collection.Add("Is now the two hours’ traffic of our stage;");
collection.Add("The which if you with patient ears attend,");
collection.Add("What here shall miss, our toil shall strive to mend.");

Console.WriteLine("Некоторые строки:");
Console.WriteLine(collection[0]);
Console.WriteLine(collection[1]);
Console.WriteLine(collection[2]);
   

public class StringCollection
{
    public string[] strings;

    public int Count { get;  set; }

    public StringCollection()
    {
        strings = new string[100];
        Count = 0;
    }

    public string this[int index]
    {
        get { return strings[index]; }
        set { strings[index] = value; }
    }

    public void Add(string value)
    {
        strings[Count] = value;
        Count++;
    }
}