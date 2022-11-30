using System;

namespace TrailsOfTucana.Models {
    public class Item {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public bool IsDrawn { get; set; } // true = card was drawn before and cannot be drawn again
    }
}