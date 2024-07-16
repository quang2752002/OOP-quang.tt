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

		public void Insert(Product row)
        {
            database.InsertTable("product", row);
        }

        public override void Update(Product row)
        {
            database.UpdateTable("product", row);
        }

        public override void Delete(Product row)
        {
            database.deleteTable("product", row);
        }

        public void SelectAll()
        {
            database.Select("product");
        }
    }
}
