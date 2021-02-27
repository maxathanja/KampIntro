using System;

namespace Methods
{
	class Program
	{
		static void Main(string[] args)
		{
			Product product1 = new Product();
			product1.Name = "Elma";
			product1.Price = 15;
			product1.Description = "Amasya Elması";

			Product product2 = new Product();
			product2.Name = "Karpuz";
			product2.Price = 80;
			product2.Description = "Diyarbakır karpuzu";

			Product[] products = new Product[] {product1, product2};

			// type-safe
			foreach (var product in products)
			{
				Console.WriteLine(product.Name);
				Console.WriteLine(product.Price);
				Console.WriteLine(product.Description);
				Console.WriteLine("---------------");
			}

			Console.WriteLine("---------- Methods ----------");

			// Instance
			// Encapsulation

			CartManager cartManager = new CartManager();
			cartManager.AddToCart(product1);
			cartManager.AddToCart(product2);

			cartManager.AddToCart2("Armut", "Yeşil Armut", 12, 10);
			cartManager.AddToCart2("Elma", "Yeşil Elma", 12, 9);
			cartManager.AddToCart2("Karpuz", "Diyarbakır Karpuzu", 12, 8);
		}
	}
}

// DRY - CLean Code - Best Practice