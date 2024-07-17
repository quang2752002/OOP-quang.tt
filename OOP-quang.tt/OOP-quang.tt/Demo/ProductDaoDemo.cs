using OOP_quang.tt.DAO;
using OOP_quang.tt.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_quang.tt.Demo
{
    public class ProductDaoDemo
	{
		
		private ProductDAO productDAO;
		private const string product = "product";
		public ProductDaoDemo()
		{
			
			productDAO = new ProductDAO();
		}

		public void InsertTest()// thêm dữ liệu test vào database
		{
			Console.WriteLine("Inserting products...");
			productDAO.Insert(product, new Product(1, "Product 1", 1));
			productDAO.Insert(product, new Product(2, "Product 2", 2));
			productDAO.Insert(product, new Product(3, "Product 3", 1));
		}

		public void UpdateTest()// cập nhật lại 1 row trong bảng product
		{
			Console.WriteLine("Updating product...");
			productDAO.Update(product,new Product(2, "Updated Product 2", 2));
		}

		public void DeleteTest()//xóa 1 row trong bảng product
		{
			Console.WriteLine("Deleting product...");
			productDAO.Delete(product, new Product(3, "Product 3", 1));
		}

		public void SelectAllTest()// lấy dữ liệu trong bảng product
		{
			Console.WriteLine("Selecting all products...");
			productDAO.SelectAll(product);
		}
	}
}
