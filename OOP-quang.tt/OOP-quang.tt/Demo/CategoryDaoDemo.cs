using OOP_quang.tt.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_quang.tt.Demo
{
	public class CategoryDaoDemo
	{
		private Database database;
		private CategoryDAO categoryDAO;

		public CategoryDaoDemo()
		{
			database = new Database();
			categoryDAO = new CategoryDAO();
		}

		public void InsertTest()
		{
			Console.WriteLine("Inserting categories...");
			categoryDAO.Insert(new Category(1, "Category 1"));
			categoryDAO.Insert(new Category(2, "Category 2"));
			categoryDAO.Insert(new Category(3, "Category 3"));
		}

		public void FindAllTest()
		{
			Console.WriteLine("All categories...");
			database.Select("category");
		}

		public void UpdateTest()
		{
			Console.WriteLine("Update category...");
			database.UpdateTableById(2, new Category(2, "Updated Category 2"));
		}

		public void DeleteTest()
		{
			Console.WriteLine("Deleting category...");
			database.deleteTable("category", new Category(3, "Category 3"));
		}
	}
}