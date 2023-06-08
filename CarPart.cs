namespace AutoPartsStore
{
    public class CarPart
    {
        public int CarId { get; set; }
        public int PartId { get; set; } 

        public Car Car { get; set; } // العلاقة بين جدول السيارة وجدول القطعة (علاقة واحد إلى واحد)
        public Part Part { get; set; } // العلاقة بين جدول القطعة وجدول السيارة (علاقة واحد إلى واحد)

        public List<Car> Cars { get; set; } // قائمة تحتوي على السيارات المرتبطة بالقطعة (علاقة واحد إلى كثير)

        public List<Part> Parts { get; set; } // قائمة تحتوي على القطع المرتبطة بالسيارة (علاقة واحد إلى كثير)
    }
}




