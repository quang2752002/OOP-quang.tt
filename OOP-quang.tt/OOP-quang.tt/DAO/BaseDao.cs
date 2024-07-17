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
		public virtual void Insert(string name, T row)// thêm dữ liệu vào theo bảng theo tên trong database
		{
			database.InsertTable(name, row);
		}
		public virtual void Update(string name, T row) //cập dữ liệu vào theo bảng theo tên trong database
		{
			database.UpdateTable(name, row);
		}

		public virtual void Delete(string name, T row)//xóa dữ liệu vào theo bảng theo tên trong database
		{
			database.deleteTable(name, row);
		}
		public void Truncate(string name)// xóa toàn bộ  dữ liệu trong các bảng theo tên trong database
		{
			database.TruncateTable(name);
		}

		public void SelectAll(string name)//lấy dữ liệu trong bảng theo tên trong database
		{
			database.Select(name);
		}

		public virtual T FindById(int id) // tìm kiếm dữ liệu theo id
		{
			return default(T);
		}
	}
}
