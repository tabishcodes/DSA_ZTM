/*
Video: 67 => Array Introduction 
    In this video we have learned about the Push & Pop Array Methods. 
*/
using System.Collections;

char[] charsArray = { 'a', 'b', 'c', 'd' };

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

/*================================================================================================*/

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

/*
Video: 69 => Quick Note: Upcoming Video
*/

/*
    Video: 69 =>
*/

int[] arr = new int[1];
int[] arr1 = new int[1];

if(arr == arr1){
    Console.WriteLine(true);
}
else
{
    Console.WriteLine();
}

public class Car{

    string color = "black";

    public static void Main(string[] args)
    {
        Car myObj = new Car();

        Console.WriteLine(myObj.color);
    }
}