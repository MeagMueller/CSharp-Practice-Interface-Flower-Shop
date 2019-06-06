using System;
using System.Collections.Generic;

namespace flower_shop {

    public class Flowers {

        public List<Rose> Roses { get; set; } = new List<Rose>();

        public List<Hyacinth> Hyacinth { get; set; } = new List<Hyacinth>();

        public List<Moonflower> Moonflowers { get; set; } = new List<Moonflower>();

        public List<CallaLily> CallaLilies { get; set; } = new List<CallaLily>();

        public List<IFlowerColor> MothersDayBouquet() {
            return new List<IFlowerColor> {
                new Rose() {Color = "Red", Price = 5.00},
                new Rose() {Color = "Yellow", Price = 5.00},
                new Hyacinth() {Color = "Blue", Price = 5.00},
                new Hyacinth() {Color = "White", Price = 5.00}
            };
        }

        public List<IStemLength> FathersDayBouquet() {
            return new List<IStemLength> {
                new CallaLily() {StemLength = 5.5, Price = 5.00},
                new Rose() {StemLength = 6.5, Price = 5.00},
                new Moonflower() {StemLength = 6.0, Price = 5.00}
            };
        }

        

    }

}