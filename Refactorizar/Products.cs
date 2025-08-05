//Refactorizar la clase Products

public class Products
{
    public decimal CalculatePrice(string productType, string productName, decimal basePrice, int quantity, bool isTaxable, 
                                    bool hasDiscount, decimal discountRate, List<string> brand)
    {
        var a = 0.0;
        var b = 20;
        var applyDiscount = false;
        var taxRate = 0.05m;

        if (productType == "Electronics")
        {
            var taxRate1 = 0.1m;
            var taxAmount = basePrice * taxRate1;
            a = (basePrice + taxAmount) * quantity;

            foreach (var str in brand)
            {
                if (str.Length > b)
                    applyDiscount = true;
            }

            if(applyDiscount)
                  a -= a * discountRate;
        }
        else if (productType == "Clothing")
        {
            var taxAmount = basePrice * taxRate;
            a = (basePrice + taxAmount) * quantity;

            a = hasDiscount ? a * discountRate : a;
        }
        else if (productType == "Books")
        {
            var taxRate2 = 0.1m;
            var taxAmount = basePrice * taxRate2;
            a = basePrice * quantity;

            if (isTaxable)
            {
                a += taxAmount;
            }
        }
        Console.WriteLine($"Product: {productName}, Total Price: {a:C}");
        return a;
    }
}