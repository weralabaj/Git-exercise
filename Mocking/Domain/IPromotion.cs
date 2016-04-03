using System.Collections.Generic;

namespace Domain
{
    public interface IPromotion
    {
        decimal ApplyPromotion(decimal productPrice, int productsQuantity);
    }
}
