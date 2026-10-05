using System;

class RefactorActivity
{
    static void Main(string[] args)
    {
        // Unstructured script with repetitive code and bad variable naming
        double p1 = 120.00;
        double p2 = 45.00;
        double p3 = 250.00;

        // Process item 1
        double d1;
        if (p1 > 100)
        {
            d1 = p1 * 0.10;
        }
        else
        {
            d1 = 0;
        }
        double f1 = p1 - d1;
        double t1 = f1 * 1.20;
        Console.WriteLine($"Item 1 Final: £{t1:F2}");

        // Process item 2 (Duplicate code block)
        double d2;
        if (p2 > 100)
        {
            d2 = p2 * 0.10;
        }
        else
        {
            d2 = 0;
        }
        double f2 = p2 - d2;
        double t2 = f2 * 1.20;
        Console.WriteLine($"Item 2 Final: £{t2:F2}");

        // Process item 3 (Duplicate code block)
        double d3;
        if (p3 > 100)
        {
            d3 = p3 * 0.10;
        }
        else
        {
            d3 = 0;
        }
        double f3 = p3 - d3;
        double t3 = f3 * 1.20;
        Console.WriteLine($"Item 3 Final: £{t3:F2}");
    }
}
