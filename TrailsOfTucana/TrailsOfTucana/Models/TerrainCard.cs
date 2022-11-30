using System;

namespace TrailsOfTucana.Models {
    public class TerrainCard {
        public int Id { get; set; }
        public string Terrain { get; set; }
        public bool IsDrawn { get; set; } // true = card was drawn before and cannot be drawn again
    }
}