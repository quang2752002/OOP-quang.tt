using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_quang.tt.DAO
{
	public class AccessoryDAO : BaseDao<Accessory>
	{
		public AccessoryDAO() : base()
		{
		}
		public void InitDatabase()
		{
			Console.WriteLine("Initializing accessory table with 10 records...");
			for (int i = 1; i <= 10; i++)
			{
				Insert("accessory", new Accessory(i, $"Accessory {i}"));
			}
		}

		public void SelectAll()
		{
			database.Select("accessory");
		}

		public void PrintTable()
		{
			Console.WriteLine("Printing accessory table...");
			SelectAll();
		}
	}
}
