using System;
using System.Text;

namespace PasswordGenerator
{
    public class PasswordGenerator
    {
        // Define a set of characters that can be used in the password
        private static readonly string _characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_-+=<>?";

        // Function to generate a random password with a specified length
        public string GeneratePassword(int length = 12)
        {
            var random = new Random();  // Random number generator
            var password = new StringBuilder();  // To store the generated password

            // Loop to pick random characters and add them to the password
            for (int i = 0; i < length; i++)
            {
                // Randomly pick an index from the list of characters
                int index = random.Next(0, _characters.Length);
                password.Append(_characters[index]);
            }

            return password.ToString();  // Return the generated password as a string
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var passwordGen = new PasswordGenerator();  // Create an instance of the PasswordGenerator class
            string password = passwordGen.GeneratePassword(16);  // Generate a password of length 16
            Console.WriteLine($"Generated Password: {password}");  // Display the generated password
        }
    }
}
