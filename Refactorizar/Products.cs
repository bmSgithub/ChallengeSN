//Refactorizar la clase Products

public class Products
{
    public ProductType Type {  get; set; }

    public string Name { get; set; }

    public decimal BasePrice { get; set; }

    public int Quantity { get; set; }

    public bool IsTaxable { get; set; }

    public bool HasDiscount { get; set; }

    public decimal DiscountRate { get; set; }

    public List<string> Brands { get; set; }

    public decimal CalculatePrice()
    {
        decimal price = 0;
        var limit = 20;

        switch (Type)
        {
            case ProductType.ELECTRONICS:
                price = BasePrice * TaxRates.ELECTRONICS * Quantity;

                if (Brands != null && Brands.Any(b => b.Length > limit))
                {
                    price -= price * DiscountRate;
                }

                break;
            case ProductType.CLOTHING:
                price = BasePrice * TaxRates.CLOTHING * Quantity;

                if (HasDiscount)
                {
                    //En el codigo original es { = }  no { -= } pero se perderia el precio en ese caso, lo modifique aunque falta contexto de lo esperado.
                    price -= price * DiscountRate;
                }
                break;
            case ProductType.BOOKS:
                price = BasePrice * Quantity;

                if (IsTaxable)
                {
                    price *= TaxRates.BOOKS;
                }
                break;
        }

        Console.WriteLine($"Product: {Name}, Total Price: {price:C}");
        return price;
    }
}

public enum ProductType
{
    ELECTRONICS = 1,
    CLOTHING = 2,
    BOOKS = 3
}

public static class TaxRates
{
    public const decimal ELECTRONICS = 1.10m;
    public const decimal CLOTHING = 1.05m;
    public const decimal BOOKS = 1.10m;
}