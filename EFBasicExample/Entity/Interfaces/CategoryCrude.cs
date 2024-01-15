using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBasicExample.Entity.Interfaces
{
    internal class CategoryCrude : ICrud<Category>
    {
        DataContext db = new DataContext();

        public bool Add(Category entity)
        {
            if (entity != null)
            {
                entity.IsStatus = true;
                db.Category.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var category = db.Category.Find(id);
            if (category != null)
            {
                //tamamen silmek için
                //db.Category.Remove(category);

                //siliyormuş gibi yapıyor
                category.IsDelete = true;
                db.SaveChanges ();
                return true;
            }
            return false;

        }

        public Category Get(int id)
        {
            var category = db.Category.Find(id);
            if (category != null && !category.IsDelete)
            {
                return category; 
            }
            return null;
        }

        public List<Category> GetList()
        {
            return db.Category.Where(x => x.IsDelete == false).ToList();
        }

        public bool Update(Category entity, int id)
        {
            var category = db.Category.Find(id);
            if (category != null && !category.IsDelete)
            {
                category.Name = entity.Name;
                category.Description = entity.Description;
                category.IsStatus = category.IsStatus;
                db.SaveChanges();
                return true;
            }
            return false;
        }



    }
}
