// See https://aka.ms/new-console-template for more information
// void checker_for_negative(n){
//     Console.WriteLine("function called"+ n);
// }

static int FizzBuzz(int n){
    for (int i = 0; i < n + 1; i++){
        if (i == 0){
        Console.WriteLine(i);
        }
        else if (i%5 == 0 && i%3 == 0 ){
        Console.WriteLine("FizzBuzz");
        }
        else if (i%3 == 0){
        Console.WriteLine("Fizz");
        } 
        else if (i%5 == 0){
        Console.WriteLine("Buzz");
        }
        else{
        Console.WriteLine(i);
    }
    }
    return (n);}
// Prompt use to enter an int
//? Console.WriteLine("Enter a number to FizzBuzz from 0 to:");
//! if a string alert user to enter int only or negative
//coverts string into integer
//? int n = Convert.ToInt32(Console.ReadLine());
int n = 27;
// checker_for_negative(n);
// //!testing 
// Console.WriteLine("test: " + n);
FizzBuzz(n);












// for (int i = 0; i < n + 1; i++) 
// {
//     if (i == 0){
//     Console.WriteLine(i);
//     } 
//     else if (i%5 == 0 && i%3 == 0 ){
//     Console.WriteLine(i+" FizzBuzz");
//     }
//     else if (i%3 == 0){
//     Console.WriteLine(i+" Fizz");
//     } 
//     else if (i%5 == 0){
//     Console.WriteLine(i+" Buzz");
//     }
//     else{
//         Console.WriteLine(i);
//     }
// }

