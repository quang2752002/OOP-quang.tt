using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP_quang.tv.DAO
{
	 class Database
	{
		

		private Dictionary<string, List<object>> tables;

		public Database()
		{
			tables = new Dictionary<string, List<object>>();
		}

		public void InsertTable(string name, object row)
		{
			if (!tables.ContainsKey(name))
			{
				tables[name] = new List<object>();
			}
			tables[name].Add(row);
		}

		  public List<object> SelectTable(string name, Func<object, bool> where = null)
        {
            if (tables.ContainsKey(name))
            {
                if (where != null)
                {
                    return tables[name].Where(where).ToList();
                }
                else
                {
                    return tables[name];
                }
            }
            return new List<object>();
        }

		public bool UpdateTable(string name, object row)
		{
			if (tables.ContainsKey(name))
			{
				var index = tables[name].FindIndex(r => (int)r.GetType().GetProperty("id").GetValue(r) == (int)row.GetType().GetProperty("id").GetValue(row));
				if (index != -1)
				{
					tables[name][index] = row;
					return true;
				}
			}
			return false;
		}

		public bool UpdateTableById(string name, int id, object row)
		{
			if (tables.ContainsKey(name))
			{
				var index = tables[name].FindIndex(r => (int)r.GetType().GetProperty("id").GetValue(r) == id);
				if (index != -1)
				{
					tables[name][index] = row;
					return true;
				}
			}
			return false;
		}

		public bool DeleteTable(string name, object row)
		{
			if (tables.ContainsKey(name))
			{
				var index = tables[name].FindIndex(r => (int)r.GetType().GetProperty("id").GetValue(r) == (int)row.GetType().GetProperty("id").GetValue(row));
				if (index != -1)
				{
					tables[name].RemoveAt(index);
					return true;
				}
			}
			return false;
		}

		public void TruncateTable(string name)
		{
			if (tables.ContainsKey(name))
			{
				tables[name].Clear();
			}
		}
	}
}