using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBasicExample.Entity.Interfaces
{
    internal class ProductCrud : ICrud<Product>
    {
        DataContext db = new DataContext();

        public bool Add(Product entity)
        {

            if (entity != null)
            {
                entity.IsStatus = true;
                db.Product.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var product = db.Product.Find(id);
            if (product != null)
            {
                //tamamen silmek için
                //db.Category.Remove(category);

                //siliyormuş gibi yapıyor
                product.IsDelete = true;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public Product Get(int id)
        {
            var product = db.Product.Find(id);
            if (product != null && !product.IsDelete)
            {
                return product;
            }
            return null;
        }

         public List<Product> GetList()
        {
            return db.Product.Where(x => x.IsDelete == false).ToList();
        }

        public bool Update(Product entity, int id)
        {
            var product = db.Product.Find(id);
            if (product != null && !product.IsDelete)
            {
                product.Name = entity.Name;
                product.Description = entity.Description;
                product.IsStatus = product.IsStatus;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
