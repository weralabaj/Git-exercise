using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using CreditScoring;
using Domain;
using NUnit.Framework;

namespace Tests
{
    public class TotalPriceCalculation // Test method GetTotalPrice()
    {
        //Given that Bread is on 'BuyOneGetOneForFree' promotion
        //when I buy 2 breads for $1.00 each 
        //the total price is $1.00
        [Test]
        public void change_my_name()
        {
            var hlep = new Product()
            {SKU = 1, Name = "bread", Price = 1.0m};
            var lineItem = new LineItem();
            lineItem.Product = hlep;
            lineItem.Quantity = 2;

            var PriceCalculator = new PriceCalculator(new PromotionsService());
            var List = new List<LineItem>() {lineItem};
            var total = PriceCalculator.GetTotalPrice(List);

            Assert.AreEqual(1m, total);
           
           
        }

        //Given that Bread is on 'BuyOneGetOneFor1Cent' promotion
        //when I buy 2 breads for $1.00 each 
        //the total price is $1.01
        [Test]
        public void change_my_name_too()
        {
            var hlep = new Product()
            { SKU = 1, Name = "bread", Price = 1.0m };
            var lineItem = new LineItem();
            lineItem.Product = hlep;
            lineItem.Quantity = 2;

            var PriceCalculator = new PriceCalculator(new PromotionsService());
            var List = new List<LineItem>() { lineItem };
            var total = PriceCalculator.GetTotalPrice(List);

            Assert.AreEqual(1.01m, total);
        }
    }
}
