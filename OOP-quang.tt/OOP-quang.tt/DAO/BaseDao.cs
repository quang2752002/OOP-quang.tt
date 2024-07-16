using OOP_quang.tt;
using System;
using System.Collections.Generic;

namespace OOP_quang.tt.DAO
{
	public abstract class BaseDao<T>:IDao<T>
	{
		protected Database database;

		public BaseDao()
		{
			database = new Database();
		}

		public virtual void Insert(T row){	}

		public virtual void Update(T row){  }

		public virtual void Delete(T row){ }

		public virtual List<T> FindAll()
		{	
			return null;
		}

		public virtual T FindById(int id)
		{	
			return default(T);
		}
	}
}
