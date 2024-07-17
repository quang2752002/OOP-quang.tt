using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_quang.tt.Entity;

namespace OOP_quang.tt.DAO
{
    public class AccessoryDAO : BaseDao<Accessory>
	{
		private const string accessory = "accessory";
		public AccessoryDAO() : base()
		{
		}
		public void InitDatabase()// thêm dữ lệu vào database
		{
			Console.WriteLine("Initializing accessory table with 10 records...");
			for (int i = 1; i <= 10; i++)
			{
				Insert(accessory, new Accessory(i, $"Accessory {i}"));
			}
		}
	}
}
