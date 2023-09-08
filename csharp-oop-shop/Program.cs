// See https://aka.ms/new-console-template for more information

using csharp_oop_shop;

/*
Product myProduct = new Product("Scatoletta di tonno", "Rio mare garantisce un marchio di qualità al prodotto");


myProduct.Price = 100;
Console.WriteLine(myProduct.PriceBase());

Console.WriteLine(myProduct.GetCodeRandom());

Console.WriteLine(myProduct.GetCodeWithPadLeft());

Console.WriteLine(myProduct.PriceVatIncluded());

Console.WriteLine(myProduct.ExtendedName());

myProduct.PrintProductInfo();
*/

// Istanzio 5 prodotti della classe Product

Product penne = new Product("Penne", "Pasta much appreciated for its lightness.", 8.00M);
Product rigatoni = new Product("Rigatoni", "Rough texture that holds the condiments better.", 10.00M);
Product paccheri = new Product("Paccheri", "Thanks to their large cavity they pair particularly well with full-bodied sauces and ragù.", 15.00M);
Product fusilli = new Product("Fusilli", "Type of pasta with an elongated shape having two or more coils, made with durum wheat semolina.", 12.00M);
Product linguine = new Product("Linguine", "they are a long, flat pasta shape that goes well with pesto.", 9.00M);


// inserisco i 5 prodotti istanziati all'interno di un Array

Product[] arrayProducts = { penne, rigatoni, paccheri, fusilli, linguine };

Console.WriteLine("Products list: ");


// ciclo i prodotti e stampo l'elenco

for (int i  = 0; i < arrayProducts.Length; i++)
{
    Console.WriteLine();

    Console.WriteLine($"Product {i + 1}:");

    arrayProducts[i].PrintProductInfo();        
}