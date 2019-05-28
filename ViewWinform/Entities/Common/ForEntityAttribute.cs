using System;

namespace MVCWinform.Common {
    [AttributeUsage(AttributeTargets.Class)]
    public class ForEntityAttribute : Attribute {
        public Entities Entity { get; set; }
        public bool Enabled { get; set; }
        public ForEntityAttribute(Entities entity) : base() {
            this.Entity = entity;
        }
    }
}
