using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            // Righ-click on Dependencies in your .Tests project and set your reference // DONE



        // Create an Add method that passes 3 integers// done

        public int AddNum(int a, int b, int c )
        {
            int sum = 0;
            sum = a +  b + c;
            return sum;
        }

        // Create a Subtract method that passes 2 integers
            // Keep track of which number is getting passed as minuend and subtrahend
         public int Sub(int minuend, int subtrahend)
        {
            int ans = 0;
            ans = minuend - subtrahend;
            return ans;
             
        }

        // Create a Multiply method that passes 2 integers
        public int Mult(int a, int b)
        {
            int ans = 0;
            ans = a * b;
            return ans;
        }
        // Create a Divide method that passes 2 integers// Done

        public int Div(int num1, int num2)
        {
            int ans = 0;
            ans = num1 / num2;
            return ans;
        }

        // Create 2 methods that will utilize the [Fact] tests you wrote
        
        //Amethod that returns 6
        public int Add3And3()
        {
            int ans = 0;
            ans = 3+ 3;
            return ans;
        }

        public string GetHey()
        {
            return "Hey!";
        }
        
    }
}
