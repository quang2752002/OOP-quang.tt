using OOP_quang.tt.DAO;
using OOP_quang.tt.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_quang.tt.Demo
{
	public class AccessoryDaoDemo
	{
		private AccessoryDAO accessoryDAO;
		private const string accessory = "accessory";
		public AccessoryDaoDemo()
		{

			accessoryDAO = new AccessoryDAO();
		}

		public void InsertTest()// thêm dữ liệu vào bảng accessory
		{
			Console.WriteLine("Inserting products...");
			accessoryDAO.Insert(accessory, new Accessory(1, "Product 1"));
			accessoryDAO.Insert(accessory, new Accessory(2, "Product 2"));
			accessoryDAO.Insert(accessory, new Accessory(3, "Product 3"));
		}

		public void UpdateTest()// cập nhật dữ liệu trong bảng accessory
		{
			Console.WriteLine("Updating Accessory...");
			accessoryDAO.Update(accessory, new Accessory(2, "Updated Accessory 2"));
		}

		public void DeleteTest() // xóa dữ liệu trong bảng accessory
		{
			Console.WriteLine("Deleting Accessory...");
			accessoryDAO.Delete(accessory, new Accessory(3, "Product 3"));
		}

		public void SelectAllTest()// lấy dữ liệu trong bảng accessory
		{
			Console.WriteLine("Selecting all accessory...");
			accessoryDAO.SelectAll(accessory);
		}
	}
}
