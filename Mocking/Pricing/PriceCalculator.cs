using System.Collections.Generic;
using System.Linq;
using Domain;

namespace CreditScoring
{
    public class PriceCalculator
    {
        iPromotionsService _iPromotionsService;

        public PriceCalculator(iPromotionsService _iPromotionsService)
        {
            this._iPromotionsService = _iPromotionsService;
        }

        

        public decimal GetTotalPrice(List<LineItem> products)
        {
            var uniqueSKUs = products.Select(p => p.Product.SKU).Distinct();

            decimal totalPrice = 0.00m;
            foreach (var sku in uniqueSKUs)
            {
                var lineItem = products.Single(li => li.Product.SKU == sku);
                var promotion = _iPromotionsService.GetPromotionFor(sku);

                if (promotion != null)
                    totalPrice += promotion.ApplyPromotion(lineItem.Product.Price, lineItem.Quantity);
                else
                    totalPrice += lineItem.Product.Price*lineItem.Quantity;
            }

            return totalPrice;
        }
    }
}
