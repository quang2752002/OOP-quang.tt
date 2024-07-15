using OOP_quang.tv.DAO;
using OOP_quang.tv;
using System;

namespace dao
{
	class Program
	{
		static void TestInsertCategory()
		{
			CategoryDAO categoryDAO = new CategoryDAO();


			Category category1 = new Category(1, "Category A");
			bool success1 = categoryDAO.Insert(category1);
			Console.WriteLine($"Insert category1 result: {success1}");


			Category category2 = new Category(2, "Category B");
			bool success2 = categoryDAO.Insert(category2);
			Console.WriteLine($"Insert category2 result: {success2}");
		}
		static void Main(string[] args)
		{
			TestInsertCategory();
			DatabaseDemo demo = new DatabaseDemo();

			demo.InitDatabase();
			demo.InsertTableTest();
			demo.SelectTableTest();
			demo.UpdateTableTest();
			demo.DeleteTableTest();
			demo.TruncateTableTest();
		}

		
	}
}