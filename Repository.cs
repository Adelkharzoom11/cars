using System;
using System.Collections.Generic;
using System.Linq;
using AutoPartsStore;
using Microsoft.EntityFrameworkCore;

public class Repository
{
    private readonly AppDbContext _dbContext;

    public Repository()
    {
        _dbContext = new AppDbContext();
        _dbContext.Database.Migrate();
    }

    // إضافة سيارة جديدة إلى قاعدة البيانات
    public void AddCar(Car car)
    {
        _dbContext.Cars.Add(car);
        _dbContext.SaveChanges();
    }

    // إضافة قطعة غيار جديدة إلى قاعدة البيانات
    public void AddPart(Part part)
    {
        _dbContext.Parts.Add(part);
        _dbContext.SaveChanges();
    }

    // إضافة مورد جديد إلى قاعدة البيانات
    public void AddSupplier(Supplier supplier)
    {
        _dbContext.Suppliers.Add(supplier);
        _dbContext.SaveChanges();
    }

    // إضافة عملية بيع جديدة إلى قاعدة البيانات
    public void AddSale(Sale sale)
    {
        _dbContext.Sales.Add(sale);
        _dbContext.SaveChanges();
    }

    // إضافة عميل جديد إلى قاعدة البيانات
    public void AddCustomer(Customer customer)
    {
        _dbContext.Customers.Add(customer);
        _dbContext.SaveChanges();
    }

    // الحصول على قائمة بجميع السيارات الموجودة في قاعدة البيانات
    public List<Car> GetAllCars()
    {
        return _dbContext.Cars.ToList();
    }

    // الحصول على قائمة بجميع قطع الغيار الموجودة في قاعدة البيانات
    public List<Part> GetAllParts()
    {
        return _dbContext.Parts.ToList();
    }

    // الحصول على قائمة بجميع الموردين الموجودين في قاعدة البيانات
    public List<Supplier> GetAllSuppliers()
    {
        return _dbContext.Suppliers.ToList();
    }

    // الحصول على قائمة بجميع عمليات البيع الموجودة في قاعدة البيانات
    public List<Sale> GetAllSales()
    {
        return _dbContext.Sales.ToList();
    }

    // الحصول على قائمة بجميع العملاء الموجودين في قاعدة البيانات
    public List<Customer> GetAllCustomers()
    {
        return _dbContext.Customers.ToList();
    }

    // الحصول على سيارة بناءً على معرفها
    public Car GetCarById(int carId)
    {
        return _dbContext.Cars.Find(carId);
    }

    // الحصول على قطعة غيار بناءً على معرفها
    public Part GetPartById(int partId)
    {
        return _dbContext.Parts.Find(partId);
    }

    // الحصول على مورد بناءً على معرفه
    public Supplier GetSupplierById(int supplierId)
    {
        return _dbContext.Suppliers.Find(supplierId);
    }

    // الحصول على عملية بيع بناءً على معرفها
    public Sale GetSaleById(int saleId)
    {
        return _dbContext.Sales.Find(saleId);
    }

    // الحصول على عميل بناءً على معرفه
    public Customer GetCustomerById(int customerId)
    {
        return _dbContext.Customers.Find(customerId);
    }

    // تحديث بيانات سيارة موجودة في قاعدة البيانات
    public void UpdateCar(Car car)
    {
        _dbContext.Entry(car).State = EntityState.Modified;
        _dbContext.SaveChanges();
    }

    // تحديث بيانات قطعة غيار موجودة في قاعدة البيانات
    public void UpdatePart(Part part)
    {
        _dbContext.Entry(part).State = EntityState.Modified;
        _dbContext.SaveChanges();
    }

    // تحديث بيانات مورد موجود في قاعدة البيانات
    public void UpdateSupplier(Supplier supplier)
    {
        _dbContext.Entry(supplier).State = EntityState.Modified;
        _dbContext.SaveChanges();
    }

    // تحديث بيانات عملية بيع موجودة في قاعدة البيانات
    public void UpdateSale(Sale sale)
    {
        _dbContext.Entry(sale).State = EntityState.Modified;
        _dbContext.SaveChanges();
    }

    // تحديث بيانات عميل موجود في قاعدة البيانات
    public void UpdateCustomer(Customer customer)
    {
        _dbContext.Entry(customer).State = EntityState.Modified;
        _dbContext.SaveChanges();
    }

    // حذف سيارة من قاعدة البيانات بناءً على معرفها
    public void DeleteCar(int carId)
    {
        var car = _dbContext.Cars.Find(carId);
        if (car != null)
        {
            _dbContext.Cars.Remove(car);
            _dbContext.SaveChanges();
        }
    }

    // حذف قطعة غيار من قاعدة البيانات بناءً على معرفها
    public void DeletePart(int partId)
    {
        var part = _dbContext.Parts.Find(partId);
        if (part != null)
        {
            _dbContext.Parts.Remove(part);
            _dbContext.SaveChanges();
        }
    }

    // حذف مورد من قاعدة البيانات بناءً على معرفه
    public void DeleteSupplier(int supplierId)
    {
        var supplier = _dbContext.Suppliers.Find(supplierId);
        if (supplier != null)
        {
            _dbContext.Suppliers.Remove(supplier);
            _dbContext.SaveChanges();
        }
    }

    // حذف عملية بيع من قاعدة البيانات بناءً على معرفها
    public void DeleteSale(int saleId)
    {
        var sale = _dbContext.Sales.Find(saleId);
        if (sale != null)
        {
            _dbContext.Sales.Remove(sale);
            _dbContext.SaveChanges();
        }
    }

    // حذف عميل من قاعدة البيانات بناءً على معرفه
    public void DeleteCustomer(int customerId)
    {
        var customer = _dbContext.Customers.Find(customerId);
        if (customer != null)
        {
            _dbContext.Customers.Remove(customer);
            _dbContext.SaveChanges();
        }
    }
}
