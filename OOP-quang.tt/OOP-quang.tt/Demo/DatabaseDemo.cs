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
		private const string product = "product";
		private const string category = "category";
		private const string accessory = "accessory";
		public DatabaseDemo()
		{
			database = new Database();
		}

		public void InsertTableTest()// thêm dữ liệu vào database
		{
			for (int i = 1; i <= 10; i++)
			{
				database.InsertTable(product, new Product ( i, "Product "+1 ,1));
				database.InsertTable(category, new Category (  i,  "Category " + i ));
				database.InsertTable(accessory, new Accessory (i,  "Accessory " + i ));
			}
		}

		public void SelectTableTest()//lấy dữ liệu từ database
		{
			Console.WriteLine("Products:");
			database.Select(product);
			Console.WriteLine("Categories:");
			database.Select(category);
			Console.WriteLine("Accessories:");
			database.Select(accessory);
		}

		public void UpdateTableTest()//update lại dữ liệu
		{
			database.UpdateTable(product, new Product(1, "Updated Product " + 1, 1));
			database.UpdateTable(category, new Category(1, "Updated Category " + 1));
			database.UpdateTable(accessory, new Accessory(1, "Updated Accessory " + 1));
		}

		public void DeleteTableTest()//xóa 1 row của các bảng trong database
		{
			database.deleteTable(product, new Product(1, " Product " + 1, 1));
			database.deleteTable(category, new Category(1, " Category " + 1));
			database.deleteTable(accessory, new Accessory(1, " Accessory " + 1));
		}

		public void TruncateTableTest()// xóa toàn bộ database
		{
			
			database.TruncateTable(product);
			database.TruncateTable(category);
			database.TruncateTable(accessory);
			Console.WriteLine("All tables truncated.");
		}

		public void InitDatabase()// thêm dữ liệu test vào database
		{
			for (int i = 1; i <= 10; i++)
			{
				database.InsertTable(product, new Product(i, "Product " + 1, 1));
				database.InsertTable(category, new Category(i, "Category " + i));
				database.InsertTable(accessory, new Accessory(i, "Accessory " + i));
			}
		}

		public void PrintTableTest(string name)// in dữ liệu trong bảng
		{
			database.Select(name);
		}

		
	}
	
}
