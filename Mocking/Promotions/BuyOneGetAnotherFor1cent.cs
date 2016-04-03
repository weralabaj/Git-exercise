using System.Collections.Generic;
using Domain;

namespace Promotions
{
    public class BuyOneGetAnotherFor1Cent : IPromotion
    {
        public decimal ApplyPromotion(decimal productPrice, int productsQuantity)
        {
            return (productPrice * productsQuantity / 2) + (productsQuantity - productsQuantity/2 * 0.01m);
        }
    }
}
