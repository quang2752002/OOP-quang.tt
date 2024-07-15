using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_quang.tv.DAO
{
	public class DatabaseDemo
	{
		private Database db;

		public DatabaseDemo()
		{
			db = new Database();
		}

		public void InsertTableTest()
		{
			Console.WriteLine("=== Insert Table Test ===");
			db.InsertTable("product", new { id = 11, name = "Product A", categoryId = 1 });
			db.InsertTable("product", new { id = 12, name = "Product B", categoryId = 1 });
			PrintTableTest("product");
			Console.WriteLine();
		}

		public void SelectTableTest()
		{
			Console.WriteLine("=== Select Table Test ===");
			var products = db.SelectTable("product");
			PrintTableTest("product", products);
			Console.WriteLine();
		}

		public void UpdateTableTest()
		{
			Console.WriteLine("=== Update Table Test ===");
			db.UpdateTable("product", new { id = 1, name = "Updated Product A", categoryId = 2 });
			PrintTableTest("product");
			Console.WriteLine();
		}

		public void UpdateTableByIdTest()
		{
			Console.WriteLine("=== Update Table By Id Test ===");
			db.UpdateTableById("product", 2, new { id = 2, name = "Updated Product B", categoryId = 1 });
			PrintTableTest("product");
			Console.WriteLine();
		}

		public void DeleteTableTest()
		{
			Console.WriteLine("=== Delete Table Test ===");
			db.DeleteTable("product", new { id = 2, name = "Product B", categoryId = 1 });
			PrintTableTest("product");
			Console.WriteLine();
		}

		public void TruncateTableTest()
		{
			Console.WriteLine("=== Truncate Table Test ===");
			db.TruncateTable("product");
			PrintTableTest("product");
			Console.WriteLine();
		}

		public void InitDatabase()
		{
			Console.WriteLine("=== Initialize Database ===");
			// Insert 10 records into 'product' table
			for (int i = 1; i <= 10; i++)
			{
				db.InsertTable("product", new { id = i, name = $"Product {i}", categoryId = 1 });
			}
			PrintTableTest("product");
			Console.WriteLine();
		}

		public void PrintTableTest(string tableName, dynamic table = null)
		{
			Console.WriteLine($"=== Printing Table: {tableName} ===");
			if (table == null)
			{
				table = db.SelectTable(tableName);
			}
			foreach (var row in table)
			{
				Console.WriteLine($"ID: {row.GetType().GetProperty("id").GetValue(row)}, Name: {row.GetType().GetProperty("name").GetValue(row)}, categoryId: {row.GetType().GetProperty("categoryId").GetValue(row)}");
			}
			Console.WriteLine();
		}

		//public static void Main(string[] args)
		//{
		//	DatabaseDemo demo = new DatabaseDemo();

		//	demo.InitDatabase();

		//	demo.InsertTableTest();
		//	demo.SelectTableTest();
		//	demo.UpdateTableTest();
		//	demo.UpdateTableByIdTest(); 
		//	demo.DeleteTableTest();
		//	demo.TruncateTableTest();
		//}
	}
}