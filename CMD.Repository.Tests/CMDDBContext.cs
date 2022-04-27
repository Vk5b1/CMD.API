using CMD.Model.Tests;
using System;
using System.Data.Entity;
using System.Linq;

namespace CMD.Repository.Tests
{
    public class CMDDBContext : DbContext
    {
        // Your context has been configured to use a 'CMDTestContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CMD.Repository.Tests.CMDTestContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CMDTestContext' 
        // connection string in the application configuration file.
        public CMDDBContext()
            : base("name=DefaultConnection")
        {
            
        }

        public DbSet<Test> Tests { get; set; }
        public DbSet<TestReport> TestsReports { get; set; }
        public DbSet<PatientDetail> PatientDetails { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}