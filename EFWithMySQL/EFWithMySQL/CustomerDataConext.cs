﻿using System.Data.Entity;

namespace EFWithMySQL
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))] 
    public class CustomerDataConext : DbContext
    {
        public CustomerDataConext(): base("DefaultConnectionString")
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
    }
}