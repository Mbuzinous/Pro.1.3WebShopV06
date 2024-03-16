using System;
// ReSharper disable UnusedVariable
    #pragma warning disable 219

namespace WebShopV06
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            double netPriceBook = 30;
            double netPriceDVD = 50;
            double netPriceGame = 100;

            Console.WriteLine("How many books did you order?");
            int noOfBooksInOrder = int.Parse(Console.ReadLine());
            Console.WriteLine("How many DVDs did you order?");
            int noOfDVDsInOrder = int.Parse(Console.ReadLine());
            Console.WriteLine("How many games did you order?");
            int noOfGamesInOrder = int.Parse(Console.ReadLine());

            double totalNetPrice = netPriceBook * noOfBooksInOrder + netPriceDVD * noOfDVDsInOrder + netPriceGame * noOfGamesInOrder;


            // SO#1
            bool receiveSpecialOffer1 = (totalNetPrice > 1000);

            // SO#2
            bool receiveSpecialOffer2 = (noOfBooksInOrder > noOfGamesInOrder);

            // SO#3
            bool receiveSpecialOffer3 = (noOfBooksInOrder >= 10) || (noOfDVDsInOrder >= 10) || (noOfGamesInOrder >= 10);

            // SO#4
            bool receiveSpecialOffer4 = ((noOfDVDsInOrder >= 10) && (noOfDVDsInOrder <= 20)) || (noOfGamesInOrder >= 5);

            Console.WriteLine($"You ordered {noOfBooksInOrder} books, {noOfDVDsInOrder} DVDs and {noOfGamesInOrder} games");
            Console.WriteLine($"You qualify for special offer #1 : {receiveSpecialOffer1}");
            Console.WriteLine($"You qualify for special offer #2 : {receiveSpecialOffer2}");
            Console.WriteLine($"You qualify for special offer #3 : {receiveSpecialOffer3}");
            Console.WriteLine($"You qualify for special offer #4 : {receiveSpecialOffer4}");

            // The LAST line of code should be ABOVE this line
        }
    }
}