using System.Collections.Generic;
using System.Net.Http.Headers;
using CreditScoring;
using Domain;
using NUnit.Framework;
using Promotions;
using Rhino.Mocks.Constraints;

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

            
            Product breed = new Product() {SKU = 5,Name = "Chleb",Price = 2};
           
            LineItem lItem = new LineItem() {Product = breed,Quantity = 2};
            var list = new List<LineItem>
            {
                lItem
            };


            PriceCalculator pCalculator =  new PriceCalculator(new MyPromotionService());
            var startPrice = pCalculator.GetTotalPrice(list);
            
            Assert.AreEqual(2m,startPrice);
            

        }

        class MyPromotionService : PromotionsService
        {
            public override IPromotion GetPromotionFor(int SKU)
            {


                return new BuyOneGetOneFree();


            }


        }

        class MySecondPromotionService : PromotionsService
        {
            public override IPromotion GetPromotionFor(int SKU)
            {


                return new BuyOneGetOneFree();


            }


        }

        //Given that Bread is on 'BuyOneGetOneFor1Cent' promotion
        //when I buy 2 breads for $1.00 each 
        //the total price is $1.01
        [Test]
        public void change_my_name_too()
        {
            Product breed = new Product() { SKU = 5, Name = "Chleb", Price = 2 };
            LineItem lItem = new LineItem() { Product = breed, Quantity = 2 };
            var list = new List<LineItem>
            {
                lItem
            };


            PriceCalculator pCalculator = new PriceCalculator(new MyPromotionService());
            var startPrice = pCalculator.GetTotalPrice(list);

            Assert.AreEqual(2.01m, startPrice);

        }
    }
}
