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

		public void SelectAll()
		{
			database.Select("category");
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
