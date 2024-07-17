using OOP_quang.tt.DAO;
using OOP_quang.tt.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_quang.tt.Demo
{
    public class DatabaseDemo
	{
		private Database database;

		public DatabaseDemo()
		{
			database = new Database();
		}

		public void InsertTableTest()
		{
			for (int i = 1; i <= 10; i++)
			{
				database.InsertTable("product", new Product ( i, "Product "+1 ,1));
				database.InsertTable("category", new Category (  i,  "Category " + i ));
				database.InsertTable("accessory", new Accessory (i,  "Accessory " + i ));
			}
		}

		public void SelectTableTest()
		{
			Console.WriteLine("Products:");
			database.Select("product");
			Console.WriteLine("Categories:");
			database.Select("category");
			Console.WriteLine("Accessories:");
			database.Select("accessory");
		}

		public void UpdateTableTest()
		{
			database.UpdateTable("product", new Product(1, "Updated Product " + 1, 1));
			database.UpdateTable("category", new Category(1, "Updated Category " + 1));
			database.UpdateTable("accessory", new Accessory(1, "Updated Accessory " + 1));
		}

		public void DeleteTableTest()
		{
			database.deleteTable("product", new Product(1, " Product " + 1, 1));
			database.deleteTable("category", new Category(1, " Category " + 1));
			database.deleteTable("accessory", new Accessory(1, " Accessory " + 1));
		}

		public void TruncateTableTest()
		{
			database.productTable = new Product[100];
			database.categoryTable = new Category[100];
			database.accessoryTable = new Accessory[100];
			Console.WriteLine("All tables truncated.");
		}

		public void InitDatabase()
		{
			for (int i = 1; i <= 10; i++)
			{
				database.InsertTable("product", new Product(i, "Product " + 1, 1));
				database.InsertTable("category", new Category(i, "Category " + i));
				database.InsertTable("accessory", new Accessory(i, "Accessory " + i));
			}
		}

		public void PrintTableTest(string name)
		{
			database.Select(name);
		}

		
	}

	

	

	
}
