using OOP_quang.tt.Entity;
using System;
using System.Reflection.Emit;

namespace OOP_quang.tt.DAO
{
    public class Database
	{
		public Product[] productTable;
		public Category[] categoryTable;
		public Accessory[] accessoryTable;
		public Database instants;

		private const string product = "product";
		private const string category = "category";
		private const string accessory = "accessory";
		public Database()
		{
			this.productTable = new Product[100];
			this.categoryTable = new Category[100];
			this.accessoryTable = new Accessory[100];
		}

		public void InsertTable(string name, dynamic row)
		{
			if (name == product)
			{
				AddToTable(productTable, row);
			}
			else if (name == category)
			{
				AddToTable(categoryTable, row);
			}
			else if (name == accessory)
			{
				AddToTable(accessoryTable, row);
			}
			else
			{
				Console.WriteLine("Invalid table name.");
			}
		}
		public void UpdateTable(string name, dynamic row)
		{

			if (name == product)
			{
				for (int i = 0; i < productTable.Length; i++)
				{
					if (productTable[i] != null && productTable[i].id == row.id)
					{
						productTable[i] = row;
						Console.WriteLine($"product id {row.id} updated.");		
					}
				}		
			}
			else if (name == category)
			{
				for (int i = 0; i < categoryTable.Length; i++)
				{
					if (categoryTable[i] != null && categoryTable[i].id == row.id)
					{
						categoryTable[i] = row;
						Console.WriteLine($" category id {row.id} updated.");						
					}					
				}		
			}
			else if (name ==accessory)
			{
				for (int i = 0; i < accessoryTable.Length; i++)
				{
					if (accessoryTable[i] != null && accessoryTable[i].id == row.id)
					{
						accessoryTable[i] = row;
						Console.WriteLine($"accessory id {row.id} updated.");
					}				
				}
			}
			else
			{
				Console.WriteLine("Invalid table name.");
			}
		}
		public void UpdateTableById(int id, dynamic row)
		{
			if (row == null)
			{
				Console.WriteLine("Row is null.");
				return;
			}

			bool updated = false;

			for (int i = 0; i < productTable.Length; i++)
			{
				if (productTable[i] != null && productTable[i].id == id)
				{
					productTable[i] = row;
					Console.WriteLine($"Product id {id} updated.");
					updated = true;
					break;
				}
			}

			for (int i = 0; i < categoryTable.Length; i++)
			{
				if (categoryTable[i] != null && categoryTable[i].id == id)
				{
					categoryTable[i] = row;
					Console.WriteLine($"Category id {id} updated.");
					updated = true;
					break;
				}
			}

			for (int i = 0; i < accessoryTable.Length; i++)
			{
				if (accessoryTable[i] != null && accessoryTable[i].id == id)
				{
					accessoryTable[i] = row;
					Console.WriteLine($"Accessory id {id} updated.");
					updated = true;
					break;
				}
			}

			if (!updated)
			{
				Console.WriteLine($"ID {id} not found in any table.");
			}
		}
		public void TruncateTable(string name)
		{
			if (name == product)
			{
				productTable = new Product[100];
				Console.WriteLine("Product table truncated.");
			}
			else if (name == category)
			{
				categoryTable = new Category[100];
				Console.WriteLine("Category table truncated.");
			}
			else if (name == accessory)
			{
				accessoryTable = new Accessory[100];
				Console.WriteLine("Accessory table truncated.");
			}
			else
			{
				Console.WriteLine("Invalid table name.");
			}
		}
		public void deleteTable(string name,dynamic row)
		{
			if (row == null || row.id == null)
			{
				Console.WriteLine("Row or ID is null.");
				return;
			}

			if (name ==product)
			{
				for (int i = 0; i < productTable.Length; i++)
				{
					if (productTable[i] != null && productTable[i].id == row.id)
					{
						productTable[i] = null;
						Console.WriteLine($"Product  deleted from  table.");
						return;
					}
				}
			}
			else if (name == category)
			{
				for (int i = 0; i < categoryTable.Length; i++)
				{
					if (categoryTable[i] != null && categoryTable[i].id == row.id)
					{
						categoryTable[i] = null;
						Console.WriteLine($"Category  deleted from  table.");
						return;
					}
				}
			}
			else if (name == accessory)
			{
				for (int i = 0; i < accessoryTable.Length; i++)
				{
					if (accessoryTable[i] != null && accessoryTable[i].id == row.id)
					{
						accessoryTable[i] = null;
						Console.WriteLine($"Accessory    deleted from table.");
						return;
					}
				};
			}
			else
			{
				Console.WriteLine("Invalid table name.");
			}
		}

		public void Select(string name)
		{
			if (name == product)
			{
				SelectAllFromTable(productTable);
			}
			else if (name == category)
			{
				SelectAllFromTable(categoryTable);
			}
			else if (name == accessory)
			{
				SelectAllFromTable(accessoryTable);
			}
			else
			{
				Console.WriteLine("Invalid table name.");
			}
		}
		private void SelectAllFromTable<T>(T[] table)
		{
			for (int i = 0; i < table.Length; i++)
			{
				if (table[i] != null)
				{
					Console.WriteLine(table[i]);
				}
			}
		}
		private void AddToTable<T>(T[] table, dynamic row)
		{
			for (int i = 0; i < table.Length; i++)
			{
				if (table[i] == null)
				{
					table[i] = row;
					
					return;
				}
			}
			
		}
	
	}

}
