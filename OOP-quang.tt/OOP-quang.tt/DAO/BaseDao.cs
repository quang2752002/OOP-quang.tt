using OOP_quang.tt;
using System;
using System.Collections.Generic;

namespace OOP_quang.tt.DAO
{
	public abstract class BaseDao<T>
	{
		protected Database database;

		public BaseDao()
		{
			database = new Database();
		}

		public virtual void Insert(T row)
		{
			Console.WriteLine("Insert method not implemented in BaseDao.");
			
		}

		public virtual void Update(T row)
		{
			Console.WriteLine("Update method not implemented in BaseDao.");
		}

		public virtual void Delete(T row)
		{
			Console.WriteLine("Delete method not implemented in BaseDao.");
		}

		public virtual List<T> FindAll()
		{
			Console.WriteLine("FindAll method not implemented in BaseDao.");
			return null;
		}

		public virtual T FindById(int id)
		{
			Console.WriteLine("FindById method not implemented in BaseDao.");
			return default(T);
		}
	}
}
