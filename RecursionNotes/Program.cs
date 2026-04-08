using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Mr Jensen is not a huge fan of recursion, 
        // Alex (Teichert?) the other teacher loves it a lot

        // A method that calls itself repeatedly
        // I prefer loops

        //isn't hard, but it is foreign
        //Factorial -- 5!; 5*4*3*2*1
        Console.WriteLine(FactorialSolver(5));// solves all of FactorialSolver
                                        //and prints it out
    }

    static int FactorialSolver(int number)
    {
        //Exit case, base case (NEEDS AN EXIT CASE on top of it)
        if (number == 1)
        {
            return 1;
        }
        //recursive call
        return number * FactorialSolver(number - 1);
        //the method never quite finishes but the - 1 keeps going, until 
        // it gets to 1, and then returns anywat because that return is true

        //until it gets to true it goes, and then it quickly unwinds, 
        // now knowing what the answer is to each of them  
    }
    //call stack looks ike this 
    // 5 * Factorial Solver(4)
    // 5 * 4 * Factorial Solver(3)
    // 5 * 4 * 3 * Factorial Solver(2)
    // 5 * 4 * 3 * 2 Factorial Solver(1)
    // 5 * 4 * 3 * 2 * 1
}