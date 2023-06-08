using System;

namespace AutoPartsStore
{

    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();

            // إضافة سيارة
            Car car = new Car
            {
                Name = "Car1",
                Year = 2022,
                Gear = "Automatic",
                KM = 10000
            };
            repository.AddCar(car);

            // إضافة قطعة
            Part part = new Part
            {
                Name = "Part1",
                Quantity = 10,
                Price = 50,
                SupplierId = 1
            };
            repository.AddPart(part);

            // إضافة مصنع
            Supplier supplier = new Supplier
            {
                Name = "Supplier1",
                Address = "Address1"
            };
            repository.AddSupplier(supplier);
        }
    }


}
