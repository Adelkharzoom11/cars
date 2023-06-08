using System.Collections.Generic;

namespace AutoPartsStore
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<Part> Parts { get; set; }
    }
}
