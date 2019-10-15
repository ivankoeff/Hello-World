<Query Kind="Program">
  <Reference>&lt;ProgramFilesX64&gt;\Microsoft SDKs\Azure\.NET SDK\v2.9\bin\plugins\Diagnostics\Newtonsoft.Json.dll</Reference>
</Query>

public interface IProduct
{
	bool SearchFor(string searchTerm);
}

public class Product : IProduct
{	
	public static List<string> StatList = new List<string>();

	public string Name { get; set; }
	public decimal Price { get; set; }
	public DateTime ExpiryDate { get; set; }

	public virtual bool SearchFor(string searchTerm)
	{
		return Name.Contains(searchTerm);
	}
}

public class ProductEx : Product
{
	public string Desc { get; set; }
	
	override public bool SearchFor(string searchTerm)
	{
		if (base.SearchFor(searchTerm))
			return true;
		return Desc.Contains(searchTerm);
	}
}

static void Main()
{
	Product.StatList.Add("I am a stat prop");
	Product.StatList.Dump();

	IProduct p1 = new Product()
	{
	    Name = "Product 1 (the best one!)",
	    Price = 99.95m,
	    ExpiryDate = new DateTime(2000, 12, 29, 0, 0, 0, DateTimeKind.Utc),
	};

	IProduct p2 = new ProductEx()
	{
	    Name = "Product 2",
	    Price = 12.50m,
	    ExpiryDate = new DateTime(2009, 7, 31, 0, 0, 0, DateTimeKind.Utc),
		Desc = "I am the best description!"
	};

	List<IProduct> products = new List<IProduct>();
	products.Add(p1);
	products.Add(p2);

	/*
	(p1 is IProduct).Dump();
	(p1 is Product).Dump();
	(p1 is ProductEx).Dump();
	(p2 is IProduct).Dump();
	(p2 is Product).Dump();
	(p2 is ProductEx).Dump();
	*/

	string json = Newtonsoft.Json.JsonConvert.SerializeObject(products, Newtonsoft.Json.Formatting.Indented);
	json.Dump();

	//products[1].Dump();
	//products[1].Dump();

	foreach(var product in products)
	{
		if (product.SearchFor("best"))
			product.Dump();

		/*
		if (product is ProductEx)
		{
			Product pp = product as Product;
		}
		else if (product is ProductEx)
		{
			ProductEx pp = product as ProductEx;
		}
		*/
	}
}

// Define other methods and classes here