namespace ConvergeDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProductDataModel : DbContext
    {
        public ProductDataModel()
            : base("name=ProductDataModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<Product> Product { get; set; }
    }
}
