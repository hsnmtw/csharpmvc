using System;

namespace MVCHIS.Common {
    [AttributeUsage(AttributeTargets.Class)]
    public class ForModelAttribute : Attribute {
        public MODELS Model { get; set; }
        public bool Enabled { get; set; }
        public ForModelAttribute(MODELS model) : base() {
            Model = model;
        }
    }
}
