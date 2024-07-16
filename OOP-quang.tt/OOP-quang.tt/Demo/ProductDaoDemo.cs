﻿using OOP_quang.tt.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_quang.tt.Demo
{
    public class ProductDaoDemo
	{
		private Database database;
		private ProductDAO productDAO;

		public ProductDaoDemo()
		{
			database = new Database();
			productDAO = new ProductDAO();
		}

		public void InsertTest()
		{
			Console.WriteLine("Inserting products...");
			productDAO.Insert(new Product(1, "Product 1", 1));
			productDAO.Insert(new Product(2, "Product 2", 2));
			productDAO.Insert(new Product(3, "Product 3", 1));
		}

		public void UpdateTest()
		{
			Console.WriteLine("Updating product...");
			productDAO.Update(new Product(2, "Updated Product 2", 2));
		}

		public void DeleteTest()
		{
			Console.WriteLine("Deleting product...");
			productDAO.Delete(new Product(3, "Product 3", 1));
		}

		public void SelectAllTest()
		{
			Console.WriteLine("Selecting all products...");
			productDAO.SelectAll();
		}
	}
}