using System;

namespace flower_shop {

    public class CallaLily : IStemLength {
        public string Color { get; set; }

        public double Price { get; set; }

        public bool HasThorns { get; set; }

        public double StemLength { get; set; }

        public override string ToString() {
            return $"A {Color} calla lily is {Price:c}";
        }
    }
}