// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// // Create a loop that prints all values from 1 - 255]
// for(int i = 1; i <= 255; i++)
//  {
//     Console.WriteLine(i);
// }

// // Create a new loop tht generates 5 random numbers between 10 and 20.
// Random rand = new Random();
// for(int y = 1; y <= 5; y++) {
//     Console.WriteLine(rand.Next(10,21));
// }

// Modify the previous loop to add the random values together and print the sum after the loop finishes

rand = 0
sum = 0

for(int y = 0; y < 5; y++) {
    rand = randNext(10,21);
    Console.WriteLine(rand);
    sum += rand;

}



int sum = 0;
int newRandomNumber = 0;
for(int j = 0; j < 5; j++){
    newRandomNumber = rand.Next(10, 21);
    //Console.WriteLine(newRandomNumber);
    sum += newRandomNumber;
    //Console.WriteLine("Sum is currently: " + sum);
}


//Create a new loop that prints all values from 1 to 100 that are divisible by 3 or 5, but not both.
//  for(int i = 1; i <= 100; i++) 
//  {
//     if(i % 3 == 0 && i % 5 == 0) 
//   {
//     continue;
//   }
 
//     if(i % 3 == 0 || i % 5 == 0)
//     {
//         Console.WriteLine(i);
//     }
//     }

// Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for numbers that are multiples of both 3 and 5. 
for (int i = 1; i <= 100; i++)  
{  
        if (i % 3 == 0 && i % 5 == 0)  
        {  
            Console.WriteLine("FizzBuzz");  
        }  
        else if (i % 3 == 0)  
        {  
           Console.WriteLine("Fizz");  
        }  
        else if (i % 5 == 0)  
        {  
           Console.WriteLine("Buzz");  
        }  
        else  
        {  
            Console.WriteLine(i);  
        }  
}  
//Modify the previous loop once more to now also print "FizzBuzz" for numbers that are multiples of both 3 and 5. 
for (int i = 1; i <= 100; i++)  
{  
        if (i % 3 == 0 && i % 5 == 0)  
        {  
            Console.WriteLine("FizzBuzz");  
        }  
        else if (i % 3 == 0)  
        {  
           Console.WriteLine("FizzBuzz");  
        }  
        else if (i % 5 == 0)  
        {  
           Console.WriteLine("FizzBuzz");  
        }  
        else  
        {  
            Console.WriteLine(i);  
        }  
}  