using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_quang.tv
{
	public class Product
	{
		public int id { get; set; }
		public string name { get; set; }
		public int categoryId { get; set; }
		public Product(int id, string name, int categoryId)
		{
			this.id = id;
			this.name = name;
			this.categoryId = categoryId;
		}
	}
}
