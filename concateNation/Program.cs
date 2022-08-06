using System;


    namespace Concatenation
{
    class program
    {
        static void Main(string[] args)
        {
            //**********Concatenation(joining string values)*********//
            string a = "50";
            string b = "78";
            Console.WriteLine(a + b);
            Console.WriteLine("Hello" + " " + "String" + "!");
            //Interpolation ($ {})
            string author = "hector garcia";
            string book = "ikigai";
            string bookAuthor = $"{author} is the author of book {book}";
            Console.WriteLine(bookAuthor);

            //Inbuilt concatenate method
            

            string firstName = "umesh";
            string lastName = "sawant";
            Console.WriteLine(string.Concat(firstName, lastName));

        }
    }
}
