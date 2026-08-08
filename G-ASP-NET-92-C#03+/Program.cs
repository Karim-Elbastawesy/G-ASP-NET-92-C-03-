namespace G_ASP_NET_92_C_03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Question01
            //// ---------
            //// Q: Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75.
            //// Print the second price (index 1).
            //// ---------

            //double[] prices = { 25.5, 40.0, 33.75 };

            //Console.WriteLine(prices[1]);

            //#endregion

            //#region Question02
            //// ---------
            //// Q: Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            //// shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.
            //// ---------

            //int[,] shelfCopies =
            //{
            //    { 3, 5 },
            //    { 1, 4 }
            //};

            //Console.WriteLine(shelfCopies[1, 0]);

            //#endregion

            //#region Question03
            //// ---------
            //// Q: Write a method called PrintWelcomeMessage that takes no parameters and prints
            //// "Welcome to the Library!". Call it from Main.
            //// ---------

            //PrintWelcomeMessage();

            //#endregion

            //#region Question04
            //// ---------
            //// Q: Write a method PrintBookTitle(string title) that prints "Book title: " + title.
            //// Call it with "Clean Code".
            //// ---------

            //PrintBookTitle("Clean Code");

            //#endregion

            //#region Question05
            //// ---------
            //// Q: Write a method AddBonusPages(int pages) that adds 50 to pages.
            //// Call it with a variable int pages = 400; and print pages afterward.
            //// What do you expect to see, and why?
            //// ---------

            //int pages = 400;

            //AddBonusPages(pages);

            //Console.WriteLine(pages);

            //// int > value type
            //// "pages" gives a copy of its a value as the method changes it to 450
            //// keeping the original "pages" at 400 still

            //#endregion

            //#region Question06
            //// ---------
            //// Q: Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0].
            //// Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.
            //// What do you expect to see, and why?
            //// ---------

            //double[] prices = { 25.5, 40.0 };

            //ApplyDiscount(prices);

            //Console.WriteLine(prices[0]);

            //// method subtracts 5 from prices[0] changing 25.5 to 20.5
            //#endregion

            //#region Question07
            //// ---------
            //// Q: Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            //// Call it and print pages afterward. How is the result different from question 5?
            //// ---------

            //int pages = 400;

            //AddBonusPagesByRef(ref pages);

            //Console.WriteLine(pages);


            //// in question05, the method got a copy of 400
            //// while ref works with the orginial variable
            //#endregion

            //#region Question08
            //// ---------
            //// Q: Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
            //// new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length afterward.
            //// ---------

            //double[] prices = { 25.5, 40.0, 33.75 };

            //ReplaceArray(ref prices);

            //Console.WriteLine(prices.Length);

            //#endregion

            //#region Question09
            //// ---------
            //// Q: Write a method bool TryGetPrice(string title, out double price) that returns true and sets
            //// price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.
            //// Call it and print the price if found.
            //// ---------

            //double price;

            //bool found = TryGetPrice("Clean Code", out price);

            //if (found)
            //{
            //    Console.WriteLine(price);
            //}

            //#endregion

            #region Question10
            // ---------
            // Q: Write a method PrintBookInfo(string title, int pages = 300) where pages is optional.
            // Call it once with only a title, and once passing both a title and pages.
            // ---------

            PrintBookInfo("Clean Code");

            PrintBookInfo("The Pragmatic Programmer", 352);

            #endregion
        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }
        static void AddBonusPages(int pages)
        {
            pages = pages + 50;
        }
        static void ApplyDiscount(double[] prices)
        {
            prices[0] = prices[0] - 5;
        }
        static void AddBonusPagesByRef(ref int pages)
        {
            pages = pages + 50;
        }
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }

            price = 0;
            return false;
        }

        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Pages: " + pages);
        }
    }
}
