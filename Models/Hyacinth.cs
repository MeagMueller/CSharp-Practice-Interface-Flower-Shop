using System;

namespace flower_shop {

    public class Hyacinth : IFlowerColor {
        public string Color { get; set; }

        public double Price { get; set; }

        public bool HasThorns { get; set; }


        public override string ToString() {
            return $"A {Color} hyacinth is {Price:c}";
        }
    }

}