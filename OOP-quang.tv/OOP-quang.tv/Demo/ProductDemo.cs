using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_quang.tv.Demo
{
	public class ProductDemo
	{
		public void CreateProductTest()
		{
			Console.WriteLine("=== Create Product Test ===");

			
			Product product1 = new Product(1, "Product A", 1);
			Product product2 = new Product(1, "Product B", 1);

			
			PrintProduct(product1);
			PrintProduct(product2);
		}

		public void PrintProduct(Product product)
		{
			Console.WriteLine($"Product ID: {product.id}");
			Console.WriteLine($"Name: {product.name}");
			Console.WriteLine($"categoryId: {product.categoryId}");
			Console.WriteLine();
		}
	}

}
