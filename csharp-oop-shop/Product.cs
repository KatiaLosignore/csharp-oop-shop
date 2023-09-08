using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Product
    {
        // ATTRIBUTI

        public int Code { get; private set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Vat { get; set; }

        // COSTRUTTORI

        public Product(string name, string description, decimal price = 0, int vat = 22)
        {
            this.Code = GetCodeRandom();
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Vat = vat;
           
        }

        // METODI

        // funzione che genera un un numero Random tra 1 e 999999
        public int GetCodeRandom()
        {
            Random randomNumber = new Random();
            return randomNumber.Next(1, 999999);
        }

        // funzione che genera il prezzo base
        public string PriceBase()
        {
            return this.Price + " " + "Euro";
        }

        // funzione che genera il prezzo base comprensivo di iva
        public decimal PriceVatIncluded()
        {

            return Decimal.Round(((this.Price / 100) * this.Vat) + Price, 2);
        }

        // funzione che restituisce il codice con un pad left di 0 per arrivare a 8 caratteri 

        public string GetCodeWithPadLeft()
        {
            return this.Code.ToString().PadLeft(8, '0');
        }

        // funzione che restituisce il nome esteso, ottenuto concatenando codice + nome

        public string ExtendedName()
        {
            return GetCodeWithPadLeft() + " " + this.Name;
        }

       
    }
}
