using System;

namespace Variables_Maey_Andrew
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console writes "favorite number"
            Console.WriteLine("Favorite Number");
            int favoriteNumber;
            // Not use bool
            bool isJumping = false, isRunning = false;
            float e;
            favoriteNumber = 64;
            e = 8.2f;
            // Your final grade is CONSTANT
            const double finalGrade = 72.2;
            // This is adding your
            Console.WriteLine(e + favoriteNumber);
            Console.WriteLine("=");
            Console.WriteLine(finalGrade + "%");
        }
    }
}