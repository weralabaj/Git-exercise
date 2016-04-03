using Domain;

namespace Promotions
{
    public class BuyOneGetOneFree : IPromotion
    {
        public decimal ApplyPromotion(decimal productPrice, int productsQuantity)
        {
            return productPrice * (productsQuantity / 2 + productsQuantity % 2);
        }
    }
}
