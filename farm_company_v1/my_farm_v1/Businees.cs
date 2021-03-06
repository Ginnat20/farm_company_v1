using System;
using System.Collections.Generic;
using System.Text;

namespace my_farm_v1
{
    public class Businees
    {
        Farmer[] Farmer = new Farmer[10];
        int FarmerCount = 0;

        Product[] Product = new Product[10];
        int ProductCount = 0;

        Crop[] Crop = new Crop[10];
        int CropCount = 0;

        public void AddFarmer(Farmer Farmers)
        {
            Farmer[FarmerCount] = Farmers;
            FarmerCount++;

        }
        public void AddProduct(Product Products)
        {
            Product[ProductCount] = Products;
            ProductCount++;

        }
        public void AddCrop(Crop Crops)
        {
            Crop[CropCount] = Crops;
            CropCount++;

        }

         public int CountFarmerbyProduct(string ProductName)
        {
            int FarmerbyProductCount = 0;

            for (int i = 0; i < CropCount; i++) 
            {
                if (Crop[i].Product.Name== ProductName)
                {
                    FarmerbyProductCount++;
                }
            }
            return FarmerbyProductCount;

        }

        public double getTotalAmountFarmer(int Gender)
        {
            double Total = 0;
            for (int i = 0; i < CropCount; i++)
            {
                if (Crop[i].Farmer.Gender != Gender)
                {
                    Total = Crop[i].Product.UnitPrice - Crop[i].Product.UnitPrice * Crop[i].Product.TaxPerUnitPercentage / 100;

                }
            }
            return Total;
        }

        


    }
}
