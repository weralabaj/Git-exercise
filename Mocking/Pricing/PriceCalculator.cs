using System.Collections.Generic;
using System.Linq;
using Domain;

namespace CreditScoring
{
    public class PriceCalculator
    {
        PromotionsService promotionsService;

        public PriceCalculator(PromotionsService promotionsService)
        {
            this.promotionsService = promotionsService;
        }

        public decimal GetTotalPrice(List<LineItem> products)
        {
            var uniqueSKUs = products.Select(p => p.Product.SKU).Distinct();

            decimal totalPrice = 0.00m;
            foreach (var sku in uniqueSKUs)
            {
                var lineItem = products.Single(li => li.Product.SKU == sku);
                var promotion = promotionsService.GetPromotionFor(sku);

                if (promotion != null)
                    totalPrice += promotion.ApplyPromotion(lineItem.Product.Price, lineItem.Quantity);
                else
                    totalPrice += lineItem.Product.Price*lineItem.Quantity;
            }

            return totalPrice;
        }
    }
}
