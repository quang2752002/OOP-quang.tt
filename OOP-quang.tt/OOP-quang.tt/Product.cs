using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_quang.tt
{
	public class Product : BaseRow
	{
		public int categoryId { get; set; }

		public Product(int id, string name, int categoryId)
			: base(id, name)
		{
			this.categoryId = categoryId;
		}

		public override string ToString()
		{
			return $"Product ID: {id}, Name: {name}, categoryId: {categoryId}";
		}
	}
}
