using NUnit.Framework;
using Promotions;
using Rhino.Mocks;

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
            var mock =
                MockRepository.GenerateStub<IPromotionsService>();
                    mock.Stub(x => x.GetPromotionFor(Arg<int>.Is.Anything))
                    .Return(new BuyOneGetOneFree());
        }

        //Given that Bread is on 'BuyOneGetOneFor1Cent' promotion
        //when I buy 2 breads for $1.00 each 
        //the total price is $1.01
        [Test]
        public void change_my_name_too()
        {
        }
    }

    public interface IPromotionsService
    {
        IPromotion GetPromotionFor(int SKU);
    }
}
