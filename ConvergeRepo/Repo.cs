using ConvergeDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace ConvergeRepo
{
    public class Repo<T> where T:class
    {
        /*When instantiating the repo class we need to instantiate the data model as well
         * That's why we initiate it through the repo's constructor*/

        //Need to install EF for SET to work

        ProductDataModel PDM;
        public Repo()
        {
            PDM = new ProductDataModel();
        }

        //Method to get data
        public List<T> GetData()
        {
            List<T> productlist = new List<T>();

            foreach (var i in PDM.Set<T>())
            {
                productlist.Add(i);
            }
            return productlist;
        }

        //Method to Add product
        public void AddProduct(T item)
        {
            PDM.Set<T>().Add(item);
            PDM.SaveChanges();
        }

        //Method to Remove product
        public void RemoveProduct(T item)
        {
            PDM.Set<T>().Remove(item);
            PDM.SaveChanges();
        }

        //Method to Update Product
        public void UpdateProduct(T item)
        {
            //In order to use AddOrUpdate method you need to add --> System.Data.Entity.Migrations;
            PDM.Set<T>().AddOrUpdate(item);
            PDM.SaveChanges();
        }

    }
}
