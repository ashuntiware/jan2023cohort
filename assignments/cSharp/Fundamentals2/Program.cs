// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Three Basic Arrays
// Create an integer array with the values 0 through 9 inside.
int count = 0;
while(count < 10) {
    Console.WriteLine($"{count}");
    count ++;
}


// Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
string[] names = {"Tim", "Martin", "Nikki", "Sara"};


// Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code the values in!)
bool[] arr = new bool [10];
arr[0] = false;
arr[1] = true;
arr[2] = false;
arr[3] = true;
arr[4] = false;
arr[5] = true;
arr[6] = false;
arr[7] = true;
arr[8] = false;
arr[9] = true;


// List of Flavors
// Create a string List of ice cream flavor that holds at least 5 different flavors.
List <string> iceCreamFlavor = new List <string> ();
iceCreamFlavor.Add("Chocolate");
iceCreamFlavor.Add("Vanilla");
iceCreamFlavor.Add("Strawberry");
iceCreamFlavor.Add("Sherbert");
iceCreamFlavor.Add("Cookie Dough");

// Output the length of the list after you dded the flavors.
Console.WriteLine($"{iceCreamFlavor}");

// Output the third flavor in the list.
Console.WriteLine($"{iceCreamFlavor[2]}");

// Now remove the third flavor usings its index location.
iceCreamFlavor.RemoveAt(2);

// Output the length of the List again. It should now be one fewer.
Console.WriteLine($"{iceCreamFlavor}");



// User Dictionary
// Create a dictionary that will store string keys and string values.
Dictionary<string, string> namesList = new Dictionary<string, string>();

// Add key/value pairs to the dictionary where:
// Each key is a name from your names array (this can be done by hand or using logic)
// Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)
// Loop through the dictionary and print out each user's name and their associated ice cream flavor.

Random random = new Random ();
foreach(var name in names){
    int ran = random.Next(iceCreamFlavor.Count);
    namesList.Add(name, iceCreamFlavor[ran]);
    
}



