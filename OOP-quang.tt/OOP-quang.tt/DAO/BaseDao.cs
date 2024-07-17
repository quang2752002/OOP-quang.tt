using OOP_quang.tt;
using System;
using System.Collections.Generic;

namespace OOP_quang.tt.DAO
{
	public abstract class BaseDao<T> : IDao<T>
	{
		protected Database database;

		public BaseDao()
		{
			database = new Database();
		}
		public virtual void Insert(string name, T row)// 
		{
			database.InsertTable(name, row);
		}
		public virtual void Update(string name, T row)
		{
			database.UpdateTable(name, row);
		}

		public virtual void Delete(string name, T row)
		{
			database.deleteTable(name, row);
		}
		public void Truncate(string name)
		{
			database.TruncateTable(name);
		}

		public void SelectAll(string name)//lấy dữ liệu trong bảng product
		{
			database.Select(name);
		}

		public virtual T FindById(int id)
		{
			return default(T);
		}
	}
}
