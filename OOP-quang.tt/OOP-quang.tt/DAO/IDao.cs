using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_quang.tt.DAO
{
    public interface IDao<T>
	{
		void Insert(string name,T row);
		void Update(string name, T row);
		void Delete(string name, T row);
		void Truncate(string name);
		void SelectAll(string name);
		T FindById(int id);
	}
}
