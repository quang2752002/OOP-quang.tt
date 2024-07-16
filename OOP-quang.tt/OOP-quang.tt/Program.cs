
using OOP_quang.tt.DAO;
using OOP_quang.tt;
using OOP_quang.tt.Demo;
using System;

namespace dao
{
	class Program
	{
		public static void TestInsertCategory()
		{
			CategoryDAO categoryDAO = new CategoryDAO();

			Category category1 = new Category(1, "Category A");
			categoryDAO.Insert(category1);
	
			Category category2 = new Category(2, "Category B");
			categoryDAO.Insert(category2);			
		}

		public static void Main(string[] args)
		{
			//TestInsertCategory();


			DatabaseDemo demo = new DatabaseDemo();

			Console.WriteLine("Inserting records...");
			demo.InsertTableTest();

			Console.WriteLine("Selecting records...");
			demo.SelectTableTest();

			Console.WriteLine("Updating records...");
			demo.UpdateTableTest();

			Console.WriteLine("Selecting records after update...");
			demo.SelectTableTest();

			Console.WriteLine("Deleting records...");
			demo.DeleteTableTest();

			Console.WriteLine("Selecting records after delete...");
			demo.SelectTableTest();

			Console.WriteLine("Truncating tables...");
			demo.TruncateTableTest();

			//Console.WriteLine("Initializing database...");
			//demo.InitDatabase();

			Console.WriteLine("Selecting records after initialization...");
			demo.SelectTableTest();


			ProductDaoDemo productDaoDemo = new ProductDaoDemo();

			Console.WriteLine("insert test:");
			productDaoDemo.InsertTest();
			productDaoDemo.SelectAllTest();

			Console.WriteLine("\nupdate test:");
			productDaoDemo.UpdateTest();
			productDaoDemo.SelectAllTest();

			Console.WriteLine("\ndelete test:");
			productDaoDemo.DeleteTest();
			productDaoDemo.SelectAllTest();
		}


	}
}