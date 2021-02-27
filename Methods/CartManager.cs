using System;

namespace Methods
{
	public class CartManager
	{
		public void AddToCart(Product product)
		{
			Console.WriteLine("Successfully added to Cart : " + product.Name);
		}

		public void AddToCart2(string productName, string description, double price, int stockQty)
		{
			Console.WriteLine("Successfully added to Cart : " + productName);
		}
	}
}