using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSession01.Models
{
    public class Product
    {
        private int _ProductID;
        private String _ProductName;
        public Product()
        {

        }
        public Product(int proid,String proname)
        {
            this._ProductID = proid;
            this._ProductName = proname;

        }
        public String ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }


        public int ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }

        public List<Product> GetAllProducts() {
            List<Product> _al = new List<Product>();
            _al.Add(new Product { ProductID =100,ProductName = "Milk Pack"});
            _al.Add(new Product { ProductID = 101, ProductName = "Soap" });
            _al.Add(new Product { ProductID = 102, ProductName = "Dove" });
            _al.Add(new Product { ProductID = 103, ProductName = "Olper" });
            _al.Add(new Product { ProductID = 104, ProductName = "Everyday" });
            _al.Add(new Product { ProductID = 105, ProductName = "new Milk" });
            return _al;
        }
    }
}