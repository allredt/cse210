class Product
{
    protected string _productName;
    protected int _productID, _quantity;
    protected double _price;

    public void ProductInformation()
    {
        Console.Write("What is the product name? ");
        _productName = Console.ReadLine();

        Console.Write("What is the product ID? ");

        Console.Write("How many would you like? ");
        _quantity = int.Parse(Console.ReadLine());

        Console.Write(string.Format("Product Name: {0}, ID: {1}, Quantity: {2}", _productName, _productID, _quantity));
        
    }
    public double Price()
    {
        _price = _quantity * _price;

        Console.Write(string.Format("total Price: {0}", _price));

        return _price;
    }
}
// Product
// Contains the name, product id, price, and quantity of each product.
// The price of this product is computed by multiplying the price and the quantity.