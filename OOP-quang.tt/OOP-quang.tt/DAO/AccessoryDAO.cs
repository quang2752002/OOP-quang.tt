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

		public override void Insert(Accessory row)
		{
			database.InsertTable("accessory", row);
		}

		
		public override void Update(Accessory row)
		{
			database.UpdateTable("accessory", row);
		}

		public override void Delete(Accessory row)
		{
			database.deleteTable("accessory", row);
		}

		public void Truncate()
		{
			database.TruncateTable("accessory");
		}

		public void InitDatabase()
		{
			Console.WriteLine("Initializing accessory table with 10 records...");
			for (int i = 1; i <= 10; i++)
			{
				Insert(new Accessory(i, $"Accessory {i}"));
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
