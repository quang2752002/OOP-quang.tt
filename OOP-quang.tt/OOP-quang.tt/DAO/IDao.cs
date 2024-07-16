using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_quang.tt.DAO
{
    public interface IDao<T>
	{
		void Insert(T row);
		void Update(T row);
		void Delete(T row);
		List<T> FindAll();
		T FindById(int id);
	}
}
