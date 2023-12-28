/*
// Video: 67 => Array Introduction: In this video we have learned about the Push & Pop Array Methods. 

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
*/

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

//Video: 70 => About Reference type, Context, & Instantiation


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
*/

//refType();

//Context

//Instantiation

//If you want to run the below class, Comment out the above code lines or delete it
/*
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

//Video: 71 => Implementing an array

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

/*
class MyArray
{   
    //Class Variables
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
*/


//Video: 72 => Just an intro of Strings and Arrays

//Video: 73 => Exercise: Reverse A String

//Video: 74 => Exercise Solution: Reverse A String

/*
class ReverseString
{
    void reverseString(string str)
    {
        string result = string.Empty;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            result += str[i];
        }

        Console.Write(result);
    }

    public static void Main(string[] args)
    {
        ReverseString reverseString = new ReverseString();
        string str = "h";

        if (str.Length < 2 || str == string.Empty || str.Length == 0)
        {
            Console.WriteLine("Please Enter the Correct String");
        }
        else
        {
            reverseString.reverseString(str);
        }
    }
}
*/

//Video: 75 => Exercise: Merge the Sorted Array

//Video: 76 => Exercise Solution:  Merge the Sorted Array

/*
class MergeSortedArrays
{
    public static void Main(string[] args)
    {
        //Stopwatch Starts Here
        var watch = System.Diagnostics.Stopwatch.StartNew();
        //Creating an object for the class methods to run
        MergeSortedArrays mergeSortedArrays = new MergeSortedArrays();
        int[] arr1 = { 1, 3, 5, 7 };
        int n1 = arr1.Length;

        int[] arr2 = { 2, 4, 6, 8, 10, 12 };
        int n2 = arr2.Length;

        int[] arr3 = new int[n1 + n2];

        //Merge Method Called
        mergeSortedArrays.mergeTheArrays(arr1, arr2, n1, n2, arr3);

        //Printing the Sorted array
        Console.Write("Array after merging\n");
        for (int i = 0; i < n1 + n2; i++)
        {
            Console.Write(arr3[i] + " ");
        }

        //Watch stops here 
        watch.Stop();
        var elapsedMs = watch.ElapsedMilliseconds;
        //Printing the time required to execute the program
        Console.WriteLine($"\n{elapsedMs}ms");
    }

    void mergeTheArrays(int[] arr1, int[] arr2, int n1, int n2, int[] arr3)
    {
        int i = 0, j = 0, z = 0;

        while (i < n1 && j < n2)
        {   
            if (arr1[i] < arr2[j])
            {
                arr3[z++] = arr1[i++];
            }
            else
            {
                arr3[z++] = arr2[j++];
            }
        }

        while (i < n1)
        {
            arr3[z++] = arr1[i++];
        }

        while (j < n2)
        {
            arr3[z++] = arr2[j++];
        }
    }
}
*/

//Video: 77 => Solving Leetcode Excercise Questions

//1. Two Sum
/*
int[] TwoSum(int[] nums, int target)
{

    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                int[] sumarrnew = new int[] { i, j };
                return sumarrnew;
            }
        }
    }
    //If the specific argument is not passed this will throw an error
    throw new ArgumentException("No solution found");
}
//string result = string.Join(",", TwoSum([1,2,3,4,6], 10));
//Console.WriteLine($"[{result}]");
*/

//53. Maximum Subarray
/*
int MaxSubArray(int[] nums)
{
    int sum = 0;
    int maxSum = nums[0];

    for (int i = 0; i < nums.Length; i++)
    {
        sum += nums[i];

        if (nums[i] > sum)
        {
            sum = nums[i];
        }
        if (sum > maxSum)
        {
            maxSum = sum;
        }
    }
    return maxSum;
}
//Console.WriteLine(MaxSubArray([-2, 1, -3, 4, -1, 2, 1, -5, 4]));
*/

//283. Moves Zeroes
/*
void MoveZeroes(int[] nums)
{

    int l = 0;

    for (int r = 0; r < nums.Length; r++)
    {
        if (nums[r] != 0)
        {
            int temp = nums[r];
            nums[r] = nums[l];
            nums[l] = temp;
            l++;
        }
    }
    string result = string.Join(",", nums);
    Console.WriteLine($"[{result}]");
}
//MoveZeroes([1,2,0,0,5,4]);
*/

//217. Contains Duplicate
/*
bool ContainsDuplicate(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] == nums[j])
            {
                return true;
            }
        }
    }
    return false;
}
//Console.WriteLine(ContainsDuplicate([1,2,3,4,1]));
*/
