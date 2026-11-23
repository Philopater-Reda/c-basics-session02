using System;

    // Book class used in Q01 and Q02
    class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Q01. Create a Book class with a Title (string) and Pages (int).
            // Create a Book object and store it in a variable of type object. Print it.
            Console.WriteLine("=== Q01 ===");
            object book = new Book { Title = "Clean Code", Pages = 464 };
            Console.WriteLine(book);
            Console.WriteLine();

            // Q02. Print the result of calling ToString(), Equals() (compare book with itself),
            // GetHashCode(), and GetType() on book.
            Console.WriteLine("=== Q02 ===");
            Console.WriteLine($"ToString(): {book.ToString()}");
            Console.WriteLine($"Equals(book): {book.Equals(book)}");
            Console.WriteLine($"GetHashCode(): {book.GetHashCode()}");
            Console.WriteLine($"GetType(): {book.GetType()}");
            Console.WriteLine();

            // Q03. Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            // int pages = "464";
            Console.WriteLine("=== Q03 ===");
            // Answer: It is a Compile-Time Error (Cannot implicitly convert type 'string' to 'int').
            int pagesQ03 = 464; // Fixed by removing quotes to assign an integer literal
            Console.WriteLine($"Fixed pages value: {pagesQ03}");
            Console.WriteLine();

            // Q04. Write code that divides 10 by 0 inside a try block, catches the exception,
            // prints "Cannot divide by zero", and then prints "Done" in a finally block.
            Console.WriteLine("=== Q04 ===");
            try
            {
                int numerator = 10;
                int denominator = 0;
                int result = numerator / denominator;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            Console.WriteLine();

            // Q05. Declare an int pages = 300; then store it in a double variable without using a cast.
            Console.WriteLine("=== Q05 ===");
            int pagesQ05 = 300;
            double pagesDouble = pagesQ05; // Implicit casting
            Console.WriteLine($"Double pages: {pagesDouble}");
            Console.WriteLine();

            // Q06. Declare a double price = 49.99; then convert it into an int using a cast.
            Console.WriteLine("=== Q06 ===");
            double price = 49.99;
            int priceInt = (int)price; // Explicit casting
            Console.WriteLine($"Casted int price: {priceInt}");
            Console.WriteLine();

            // Q07. Given string pagesText = "464"; convert it into an int using the Convert class.
            Console.WriteLine("=== Q07 ===");
            string pagesText = "464";
            int convertedPages = Convert.ToInt32(pagesText);
            Console.WriteLine($"Converted pages: {convertedPages}");
            Console.WriteLine();

            // Q08. Given string yearText = "2023";, convert it using int.Parse().
            // Then given string badText = "abc";, use int.TryParse() to safely try converting it,
            // and print "Invalid number" if it fails.
            Console.WriteLine("=== Q08 ===");
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine($"Parsed year: {year}");

            string badText = "abc";
            if (int.TryParse(badText, out int parsedBad))
            {
                Console.WriteLine($"Parsed number: {parsedBad}");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            Console.WriteLine();

            // Q09. Given int pages = 464; convert it into a string using ToString()
            // and print its type using GetType() to prove it's now a string.
            Console.WriteLine("=== Q09 ===");
            int pagesQ09 = 464;
            string pagesAsString = pagesQ09.ToString();
            Console.WriteLine($"Value: {pagesAsString}, Type: {pagesAsString.GetType()}");
            Console.WriteLine();

            // Q10. Declare int copies = 100;. Box it into an object variable,
            // then unbox it back into a new int variable, and print both.
            Console.WriteLine("=== Q10 ===");
            int copies = 100;
            object boxedCopies = copies;       // Boxing
            int unboxedCopies = (int)boxedCopies; // Unboxing
            Console.WriteLine($"Boxed copies: {boxedCopies}");
            Console.WriteLine($"Unboxed copies: {unboxedCopies}");
        }
    }