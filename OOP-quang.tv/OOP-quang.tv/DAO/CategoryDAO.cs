using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_quang.tv.DAO
{
	 class CategoryDAO
	{
		private Database db;

		public CategoryDAO()
		{
			db = new Database();
		}

		public bool Insert(Category row)
		{
			try
			{
				db.InsertTable("category", row);
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error inserting category: {ex.Message}");
				return false;
			}
		}
	}
}
