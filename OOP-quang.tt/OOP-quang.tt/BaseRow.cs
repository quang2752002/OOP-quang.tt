using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_quang.tt
{
	public abstract class BaseRow
	{
		public int id { get; set; }
		public string name { get; set; }

		public BaseRow(int id, string name)
		{
			this.id = id;
			this.name = name;
		}

		
	}
}
