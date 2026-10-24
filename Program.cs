using static LINQ.DataSources.Source;
using LINQ.Models;
using System.Linq;

namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Part 01

			// 1
			//var result = from p in ProductList
			//			 where p.Category == "Seafood"
			//			 select new { p.ProductName, p.UnitPrice };

			//Console.WriteLine(string.Join(", ", result));


			// 2
			//method 1 
			//var result = ProductList.Select(p => p.ProductName);

			//foreach (var item in result)
			//{
			//	Console.WriteLine(item);
			//}
			//method 2
			//var result = from p in ProductList
			//			 select p.ProductName;
			//foreach (var item in result)
			//{
			//	Console.WriteLine(item);
			//}


			//3
			//var result = ProductList.OrderBy(p => p.UnitPrice);

			//foreach (var product in result)
			//{
			//	Console.WriteLine($"Name: {product.ProductName} | Price: {product.UnitPrice:C}");
			//}

			// 4
			//var result = ProductList.Where(p => 10 < p.UnitPrice && p.UnitPrice < 30);

			//foreach (var item in result)
			//{
			//	Console.WriteLine(item);
			//}

			//var result = from p in ProductList
			//			 where 10 < p.UnitPrice && p.UnitPrice < 30
			//			 select p;
			//foreach (var item in result)
			//{
			//	Console.WriteLine(item);
			//}


			//5
			//var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
			//foreach (var item in result)
			//{
			//	Console.WriteLine(item);
			//}

			//var result = from p in ProductList
			//			 where p.UnitsInStock > 0 && p.Category == "Condiments"
			//			 select p;


			//6 anonymous type 
			//var result = ProductList.Select(p => new
			//{
			//	Name = p.ProductName,
			//	Price = p.UnitPrice,
			//	StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
			//});

			//foreach (var item in result)
			//{
			//	Console.WriteLine($"Name: {item.Name} | Price: {item.Price} | Status: {item.StockStatus}");
			//}


			//7
			//var result = ProductList.Select((p , Index) => $"{Index + 1}. {p.ProductName}");

			//foreach (var item in result)
			//{
			//	Console.WriteLine(item);
			//}


			//8
			//var result = ProductList.OrderBy(p => p.Category)
			//			.ThenByDescending(p => p.UnitPrice);

			//foreach (var product in result)
			//{
			//	Console.WriteLine($"Category: {product.Category} | Name: {product.ProductName} | Price: {product.UnitPrice:C}");
			//}


			//9
			//var result = ProductList
			//	.Where(p => p.Category == "Beverages")
			//	.OrderByDescending(p => p.UnitsInStock);

			//foreach (var product in result)
			//{
			//	Console.WriteLine($"Name: {product.ProductName} | Stock: {product.UnitsInStock}");
			//}

			
			//10
			//var result = from o in OrderList
			//			 from p in CustomerList 
			//			 where o.OrderDate.Year == 1997 && o.CustomerID == p.CustomerID
			//			 select new
			//			 {
			//				 p.CustomerID,
			//				 o.OrderDate
							 
			//			 };


			//11
			//var result = ProductList.Select((p, index) => $"{index + 1}. {p.ProductName}");

			//foreach (var item in result)
			//{
			//	Console.WriteLine(item);
			//}

			#endregion
		}
	}
}