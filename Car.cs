
using System.Collections;
using System.Collections.Generic;

namespace AutoPartsStore
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Gear { get; set; }
        public int KM { get; set; }

        public ICollection<Part> Parts { get; set; }
        public List <Sale> Sales { get; set; } // علاقة واحد إلى واحد مع جدول البيع

        public List<CarPart> CarParts { get; set; } // قائمة تحتوي على القطع المرتبطة بالسيارة
    }
}
