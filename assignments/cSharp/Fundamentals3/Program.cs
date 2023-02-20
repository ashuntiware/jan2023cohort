// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// // 1. Iterate and print values Function Works
// // Given a List of strings, iterate through the List and print out all the values. 
// // Bonus: How many different ways can you find to print out the contents of a List? 
// // (There are at least 3! Check Google!)

List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};

// static void PrintList(List<string> MyList)
// {
//    for(int i = 0; i < MyList.Count; i++)
//    {
//     Console.WriteLine(MyList[i]);
//    }
// }

// PrintList(TestStringList);



// // 2. Print Sum Function Works
// // Given a List of integers, calculate and print the sum of the values.
// List<int> TestIntList = new List<int>() {2,7,12,9,3};

// static void SumOfNumbers(List<int> IntList)
// {
//    int sum = 0;
//    sum = IntList.Sum();
//    Console.WriteLine(sum);
// }

// // You should get back 33 in this example
// SumOfNumbers(TestIntList);






// // 3. Find Max Function Works
// // Given a List of integers, find and return the largest value in the List.
// List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};

// static int FindMax(List<int> IntList)
// {
//     int max = IntList.Max();
//     Console.WriteLine(IntList.Max());
//     {
//         return FindMax(IntList);
//     }

// }

// // You should get back 17 in this example
// FindMax(TestIntList2);







// 4. Square the Values Function Works
// Given a List of integers, return the List with all the values squared.

List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// static List<int> SquareValues(List<int> IntList)
// {
//     int square = 0; 
//     for(int i = 0; i < IntList.Count; i++){
//         square = IntList[i] * IntList[i];
//         IntList[i] = square;
//         Console.WriteLine(IntList[i]);
//     }{
//         return IntList;
//     }
    
    
    // }

// // You should get back [1,4,9,16,25], think about how you will show that this worked
// Console.WriteLine(SquareValues(TestIntList3));



// 5. Replace Negative Numbers with 0 Function Works

// Given an array of integers, return the array with all values below 0 replaced with 0.
// int[] TestIntArray = new int[] {-1,2,3,-4,5};
// static int[] NonNegatives(int[] IntArray)
// {
//     for (int i =0; i < IntArray.Length; i++){

//     if (IntArray[i] < 0) 
//     {
//         IntArray[i] =0;
//     }
    
//         Console.WriteLine(IntArray[i]); 
    
// }
// return IntArray;
// }

// // You should get back [0,2,3,0,5], think about how you will show that this worked
// NonNegatives(TestIntArray);


// // You should get back [0,2,3,0,5], think about how you will show that this worked
// NonNegatives(TestIntArray);



// // 6. Print Dictionary Function Works\
// // Given a dictionary, print the contents of the said dictionary.
Dictionary<string,string> TestDict = new Dictionary<string,string>();

// static void PrintDictionary(Dictionary<string,string> MyDictionary)
// {
//     foreach(KeyValuePair<string, string> dict in MyDictionary)
//     {
//         Console.WriteLine(dict.Value.ToString());
//     }
// }

// TestDict.Add("HeroName", "Iron Man");
// TestDict.Add("RealName", "Tony Stark");
// TestDict.Add("Powers", "Money and intelligence");
// PrintDictionary(TestDict);







// // 7. Find Key Function Works
// // Given a search term, return true or false whether the given term is a key in a dictionary.

// static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
// {
//   if (MyDictionary.ContainsKey(SearchTerm))
// {
//   return true;
// } 
// else 
// {
//   return false;
// }
//     }

// // Use the TestDict from the earlier example or make your own
// // This should print true
// Console.WriteLine(FindKey(TestDict, "RealName"));
// // This should print false
// Console.WriteLine(FindKey(TestDict, "Name"));



// // 8. Generate a Dictionary

// // Given a List of names and a List of integers, create a dictionary where the key is a name from the List of names and the value is a number from the List of numbers. Assume that the two Lists will be of the same length. Don't forget to print your results to make sure it worked.

// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
// 	"Julie": 6,
// 	"Harold": 12,
// 	"James": 7,
// 	"Monica": 10
// } 
List<string> TestStringList2 = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
List<int> TestIntList2 = new List<int>() {2,7,12,9};

static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> CreateDictionary = new Dictionary<string, int>();
    for (int i = 0; i < Names.Count; i++){
        CreateDictionary.Add(Names[i], Numbers[i]); 
        
    }
    foreach(KeyValuePair<string, int> value in CreateDictionary) {
        Console.WriteLine("{0}'s number is {1}", value.Key, value.Value);
    }
    return CreateDictionary; 
}

GenerateDictionary(TestStringList2, TestIntList2);
Console.WriteLine(GenerateDictionary);
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here




