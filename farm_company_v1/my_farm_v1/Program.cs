using System;

namespace my_farm_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Businees businees = new Businees();


            Product Strawberries = new Product();
            Strawberries.Name = "Strawberries";
            Strawberries.UnitPrice = 350;
            Strawberries.UnitPerKilometer = 15;
            Strawberries.CropExtensionKms = 23;
            Strawberries.TaxPerUnitPercentage = 0.15; // 15%
            businees.AddProduct(Strawberries);

            Product Mango = new Product();
            Mango.Name = "Mango";
            Mango.UnitPrice = 120;
            Mango.UnitPerKilometer = 15;
            Mango.CropExtensionKms = 42;
            Mango.TaxPerUnitPercentage = 0.15;
            businees.AddProduct(Mango);

            Product Blackberry = new Product();
            Blackberry.Name = "Blackberry";
            Blackberry.UnitPrice = 340;
            Blackberry.UnitPerKilometer = 15;
            Blackberry.CropExtensionKms = 32;
            Blackberry.TaxPerUnitPercentage = 0.15;
            businees.AddProduct(Blackberry);

            Product Avocado = new Product();
            Avocado.Name = "Avocado";
            Avocado.UnitPrice = 160;
            Avocado.UnitPerKilometer = 15;
            Avocado.CropExtensionKms = 23;
            Avocado.TaxPerUnitPercentage = 0.15;
            businees.AddProduct(Avocado);

            Product Tomatoes = new Product(); 
            Tomatoes.Name ="Tomatoes";
            Tomatoes.UnitPrice = 262;
            Tomatoes.UnitPerKilometer = 15;
            Tomatoes.CropExtensionKms = 24;
            Tomatoes.TaxPerUnitPercentage = 0.15;
            businees.AddProduct(Tomatoes);

            Product Pears = new Product();
            Pears.Name = "Pears";
            Pears.UnitPrice = 122;
            Pears.UnitPerKilometer = 15;
            Pears.CropExtensionKms = 43;
            Pears.TaxPerUnitPercentage = 0.15;
            businees.AddProduct(Pears);

            Product Oranges = new Product();
            Oranges.Name = "Oranges";
            Oranges.UnitPrice = 234;
            Oranges.UnitPerKilometer = 15;
            Oranges.CropExtensionKms = 31;
            Oranges.TaxPerUnitPercentage = 0.15;
            businees.AddProduct(Oranges);

            Farmer f1 = new Farmer();
            f1.Name = "Juan";
            f1.Stratum = 2;
            f1.Gender = 1;
            businees.AddFarmer(f1);

            Farmer f2 = new Farmer();
            f2.Name = "Lucia";
            f2.Stratum = 1;
            f2.Gender = 0;
            businees.AddFarmer(f2);

            Farmer f3 = new Farmer();
            f3.Name = "Franco";
            f3.Stratum = 1;
            f3.Gender = 1;
            businees.AddFarmer(f3);

            Farmer f4 = new Farmer();
            f4.Name = "Oscar";
            f4.Stratum = 3;
            f4.Gender = 1;
            businees.AddFarmer(f4);

            Farmer f5 = new Farmer();
            f5.Name = "Sara";
            f5.Stratum = 2;
            f5.Gender = 0;
            businees.AddFarmer(f5);

            Crop c1 = new Crop();
            c1.Product = Strawberries;
            c1.Farmer = f1;
            businees.AddCrop(c1);

            Crop c2 = new Crop();
            c2.Product = Pears;
            c2.Farmer = f2;
            businees.AddCrop(c2);

            Crop c3 = new Crop();
            c3.Product = Tomatoes;
            c3.Farmer = f2;
            businees.AddCrop(c3);

            Crop c4 = new Crop();
            c4.Product = Pears;
            c4.Farmer = f3;
            businees.AddCrop(c4);

            Crop c5 = new Crop();
            c5.Product = Oranges;
            c5.Farmer = f4;
            businees.AddCrop(c5);

            Crop c6 = new Crop();
            c6.Product = Avocado;
            c6.Farmer = f5;
            businees.AddCrop(c6);

            Crop c7 = new Crop();
            c7.Product = Blackberry;
            c7.Farmer = f3;
            businees.AddCrop(c7);

            /*
            Console.WriteLine("Enter the Product name:");
            string Product = Console.ReadLine();
            int FarmerbyProduct = businees.CountFarmerbyProduct(Product);
            Console.WriteLine("Amount of Farmer"+ FarmerbyProduct);
            */
           
            























        }
    }
}
