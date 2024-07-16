using OOP_quang.tt;
using System;
using System.Collections.Generic;

namespace OOP_quang.tt.DAO
{
	public class CategoryDAO : BaseDao<Category>
	{
		public CategoryDAO() : base()
		{
		}

		public override void Insert(Category row)
		{
			 database.InsertTable("category", row);
		}


		public override void Update(Category row)
		{
			database.UpdateTable("category", row);
		}

		public override void Delete(Category row)
		{
			database.deleteTable("category", row);
		}

		public override List<Category> FindAll()
		{
			List<Category> categories = new List<Category>();

			foreach (var item in database.categoryTable)
			{
				if (item != null)
				{
					categories.Add(item);
				}
			}

			return categories;
		}


		public override Category FindById(int id)
		{
			foreach (var item in database.categoryTable)
			{
				if (item != null && item.id == id)
				{
					return item;
				}
			}

			return null;
		}
	}
}
