using ConvergeDB;
using ConvergeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvergeTest
{
    class Program : Repo<Product>
    {
        /* Usually we can create a class and inherit Repo from it.
         * Repo has all the methods that relates to db. 
         * Importantly is that we change <T> to the datatype (in this case is Product)*/

        static void Main(string[] args)
        {
            /* because  in the abstract repo class constructor we said to instantiate the datamodel
             * we can call it by the class it inherits it. In this case Program.*/

            Program p = new Program();
            
            Product product = new Product();

            product.Nodes = 3;
            product.Repeaters = 1;
            product.Hubs = 92;

            // Adding an item to db
           // p.AddProduct(product);


            //Removing an item from db
            /* List<Product> x = p.GetData();
             foreach(Product i in x)
             {
                 p.RemoveProduct(i);
             }*/


            //Update an item in the DB
            List<Product> x = p.GetData();
            foreach(Product i in x)
            {
                if(i.ID == 2)
                {
                    i.Nodes = 20;
                    
                    p.UpdateProduct(i);
                }
            }

            /* 1. Even for the test project EF must be install
             * 2. Connection string must be copy/pasted into app.config.*/
            

            
        }
    }
}
