// See https://aka.ms/new-console-template for more information

using csharp_oop_shop;

Product myProduct = new Product("Scatoletta di tonno", "Rio mare garantisce un marchio di qualità al prodotto");

myProduct.Price = 100;
Console.WriteLine(myProduct.PriceBase());

Console.WriteLine(myProduct.GetCodeRandom());

Console.WriteLine(myProduct.GetCodeWithPadLeft());

Console.WriteLine(myProduct.PriceVatIncluded());

Console.WriteLine(myProduct.ExtendedName());
