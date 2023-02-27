using EntityFrameworkCoreBPB;
using Microsoft.EntityFrameworkCore;

SystemContext systemContext = new SystemContext();

List<Product> products = systemContext.Products
    .Include(x=> x.Category)
    .ToList();
    




//Customer customer = new Customer();
//customer.Name = "Customer test";
//customer.BirthDay = new DateTime(1987, 01, 01);
//customer.Address = "Test street at Test city";
//customer.DocumentNumber = "1234567";

//SystemContext systemContext = new SystemContext();


//systemContext.Customers.Add(customer);


//systemContext.SaveChanges();










