using System;
using System.Collections.Generic;

namespace flower_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rose aRose = new Rose() {
            //     HasThorns = true,
            //     Color = "red",
            //     StemLength = 8.5,
            //     Price = 200.00
            // };

            // Console.WriteLine(aRose); 

            // Hyacinth Hyacinth = new Hyacinth() {
            //     HasThorns = false,
            //     Color = "purple",
            //     Price = 50.00
            // };

            // Moonflower Moonflower = new Moonflower() {
            //     HasThorns = false,
            //     Color = "white",
            //     Price = 3000.00
            // };

            Flowers shop = new Flowers();

            List<IFlowerColor> mothersDay = shop.MothersDayBouquet();

            foreach(IFlowerColor flower in mothersDay) {
                Console.WriteLine(flower);
            }

            List<IStemLength> fathersDay = shop.FathersDayBouquet();

            foreach(IStemLength stemFlower in fathersDay) {
                Console.WriteLine(stemFlower);
            }


        }
    }
}
