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
		
		private CategoryDAO categoryDAO;

		public CategoryDaoDemo()
		{
			
			categoryDAO = new CategoryDAO();
		}

		public void InsertTest()
		{
			Console.WriteLine("Inserting categories...");
			categoryDAO.Insert("category", new Category(1, "Category 1"));
			categoryDAO.Insert("category", new Category(2, "Category 2"));
			categoryDAO.Insert("category", new Category(3, "Category 3"));
		}

		public void FindAllTest()
		{
			Console.WriteLine("All categories...");
			categoryDAO.SelectAll();
		}

		public void UpdateTest()
		{
			Console.WriteLine("Update category...");
			categoryDAO.Update("category", new Category(2, "Updated Category 2"));
		}

		public void DeleteTest()
		{
			Console.WriteLine("Deleting category...");
			categoryDAO.Delete("category", new Category(3, "Category 3"));
		}
	}
}