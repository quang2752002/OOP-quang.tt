using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_quang.tt.DAO
{
	public class ProductDAO : BaseDao<Product>
	{
		public ProductDAO() : base()
		{

		}
        public void SelectAll()
        {
            database.Select("product");
        }
    }
}
