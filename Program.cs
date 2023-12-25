﻿/*
Video: 67 => Array Introduction 
    In this video we have learned about the Push & Pop Array Methods. 

using System.Collections;

//char[] charsArray = { 'a', 'b', 'c', 'd' };

//Display Method
void display(char[] DisplayIt)
{
    foreach (char i in DisplayIt)
    {
        Console.WriteLine(i);
    }
}

//PUSH ELEMENTS METHODS
{
    //Pushes the item at the end of the array
    {
        //Method: 1
        char[] addElemensViaAppend(char[] charsArray)
        {
            return charsArray = charsArray.Append('e').ToArray();
        }
        //display(addElemensViaAppend(charsArray));


        //Method: 2
        char[] addElemensViaResize(char[] charsArray)
        {
            Array.Resize(ref charsArray, charsArray.Length + 1);

            charsArray[charsArray.Length - 1] = 'e';

            return charsArray;
        }
        //display(addElemensViaResize(charsArray));

        //Method: 3
        char[] addElementsInArrayViaList(char[] charsArray)
        {
            var charsList = charsArray.ToList();

            charsList.Add('e');

            return charsList.ToArray();
        }
        //display(addElementsInArrayViaList(charsArray));
    }

    //Pushes the item at the start index of the array
    {
        //Method: 1
        char[] addElementAtStartViaPrepend(char[] charsArray)
        {
            return charsArray.Prepend('e').ToArray();
        }
        //display(addElementAtStartViaPrepend(charsArray));
    }

    //Pushes the item at the specific index of the array
    {
        //Method: 1
        char[] addElementAtSpecificIndexViaListInsert(char[] charsArray)
        {
            var charList = charsArray.ToList();

            charList.Insert(2, 't');

            return charList.ToArray();

        }
        //display(addElementAtSpecificIndexViaListInsert(charsArray)); 

    }

}

//================================================================================================

//POP ELEMENTS METHODS
{
    //Pops the item from end of the array
    {
        //Method: 1
        char[] popElementViaSkipLast(char[] charsArray)
        {
            return charsArray = charsArray.SkipLast(1).ToArray();
        }
        //display(popElementViaSkipLast(charsArray));

        //Method: 2
        char[] popElementsViaTake(char[] charsArray)
        {
            return charsArray.Take(charsArray.Length - 1).ToArray();
        }
        //display(popElementsViaTake(charsArray));

        //Method: 3
        char[] popElementsViaToList(char[] charsArray)
        {
            List<char> list = new List<char>(charsArray);
            list.RemoveAt(charsArray.Length - 1);

            return charsArray = list.ToArray();
        }
        //display(popElementsViaToList(charsArray));

        //Method: 4
        char[] popElementsViaWhere(char[] charsArray)
        {
            return charsArray.Where((item, index) => index != charsArray.Length - 1).ToArray();
        }
        //display(popElementsViaWhere(charsArray));

        //Method: 5
        char[] popElementsViaArrayResize(char[] charsArray)
        {
            Array.Resize(ref charsArray, charsArray.Length - 1);

            return charsArray;
        }
        //display(popElementsViaArrayResize(charsArray));

        //Method: 6
        char[] popElementsViaReverseSkip(char[] charsArray)
        {
            return charsArray.Reverse().Skip(1).Reverse().ToArray();
        }
        //display(popElementsViaReverseSkip(charsArray));
    }
}

/*
Video: 68 => Static vs Dynamic Arrays
    In this video we have learned that
        Static Arrays has a fixed or set size.
            lookup & push func has time complexity of O(1).
            insert & delete func has time complexity of O(n).
        Dynamic Arrays are size independent & can set or fixed the array size as per data in it. 
            lookup func is O(1) but append func can be O(1) or O(n).
            insert & delete func has time complexity of O(n).
*/

//Video: 69 => Quick Note: Upcoming Video

/*
    Video: 70 => About
                    Reference type
                    Context
                    Instantiation
*/

//Reference Type
/*
int[] integer = new int[1];
int[] integer1 = new int[1];

void refType()
{
    if (integer == integer1)
    {
        Console.WriteLine(true);
    }
    else
    {
        Console.WriteLine(false);
    }
}


//refType();

//Context

//Instantiation

//If you want to run the below class, Comment out the above code lines or delete it
public class Player
{
    string name;
    string type;
    public Player(string name, string type)
    {
        this.name = name;
        this.type = type;
    }

    public static void Main(string[] args)
    {
        Player player = new Player("tabish", "healer");

        Console.WriteLine(player.name);
    }
}
*/

//Video: 70 => Implementing an array

//Learning About Constructors
/*
class Dog
{
    //Instance Variable
    string name, breed, color;
    int age;

    //Consructor Decleration of the class
    public Dog(string name, string breed, string color, int age)
    {
        this.name = name;
        this.breed = breed;
        this.color = color;
        this.age = age;
    }

    //Property 1
    public string GetName()
    {
        return name;
    }

    //Property 2
    public string GetBreed()
    {
        return breed;
    }

    //Property 3
    public string GetColor()
    {
        return color;
    }

    //Property 4
    public int GetAge()
    {
        return age;
    }

    //Method 1
    public string ToString()
    {
        return($"Hi my name is {this.GetName()}.\nMy Bread is {this.breed} ");
    }

    //Main Method
    public static void Main(string[] args)
    {
        //creating object
        Dog tuffy = new Dog ("tuffy", "Labra", "Black", 4);
        Console.WriteLine(tuffy.ToString());
    }


}
*/

/*
class Geeks
{
    private string month;
    private int year;

    // declaring Copy constructor
    public Geeks(Geeks s)
    {
        month = s.month;
        year = s.year;
    }

    // Instance constructor
    public Geeks(string month, int year)
    {
        this.month = month;
        this.year = year;
    }

    // Get details of Geeks
    public string Details
    {
        get
        {
            return "Month: " + month.ToString() +
                     "\nYear: " + year.ToString();
        }
    }

    // Main Method
    public static void Main()
    {

        // Create a new Geeks object.
        Geeks g1 = new Geeks("June", 2018);

        // here is g1 details is copied to g2.
        Geeks g2 = new Geeks(g1);

        Console.WriteLine(g2.Details);
    }
}
*/

class MyArray
{
    public int length;
    private Object[] data;
    //creating constructors
    public MyArray()
    {
        this.length = 0;
        this.data = new object[1];
    }

    public Object get(int index)
    {
        return data[index];
    }

    //pushing items at last index
    public Object[] push(Object item)
    {
        if (this.data.Length == this.length)
        {
            Object[] temp = new object[this.length]; // creates a temp array
            Array.Copy(this.data, temp, length); //copies all data to temp array
            this.data = new object[length + 1]; //increases size of the this.data array
            Array.Copy(temp, this.data, length);
        }
        this.data[this.length] = item; // insert item to last index
        this.length++; //increasing the length by 1

        return this.data; // returning the array this.data
    }

    public Object pop()
    {
        Object poped = data[this.length - 1];
        this.data[this.length - 1] = null; //nulling out the last item
        this.length--; //deceasing the length by 1

        return poped; // returning the poped array
    }

    public Object delete(int index)
    {
        Object itemToDelete = data[index];
        shiftItems(index);

        return itemToDelete;
    }

    private void shiftItems(int index)
    {
        for (int i = index; i < length - 1; i++)
        {
            data[i] = data[i + 1];
        }
        data[length - 1] = null;
        length--;
    }

    public void displayData(int arrayLength)
    {
        for (int i = 0; i < arrayLength; i++)
        {
            Console.WriteLine(get(i));
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        MyArray myArray = new MyArray();
        myArray.push("Hello ");
        myArray.push("\"Beautiful\"");
        myArray.displayData(myArray.length);
        myArray.pop();
        myArray.displayData(myArray.length);
        myArray.push("\"Beautiful\" ");
        myArray.displayData(myArray.length);
        myArray.delete(0);
        myArray.displayData(myArray.length);

    }
}

