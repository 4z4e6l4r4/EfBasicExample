using EFBasicExample.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBasicExample
{
    internal class Program
    {
       
        static void Main(string[] args)

        {
            CategoryCrude categoryCrude = new CategoryCrude();


            // CATEGORY EKLEME
            //----------------------------------------
            //Category category = new Category()
            //{
            //    Name = "Tablet",
            //    Description = "Tablet Category"
            //};


            //Console.WriteLine(categoryCrude.Add(category)? "Kategori Ekleme Başarılı":"Kategori ekleme başarısız");


            // CATEGORY SİLME
            //----------------------------------------
            //if (categoryCrude.Delete(2))
            //{
            //    Console.WriteLine("Silme İşlemi Başarılı");
            //}
            //else
            //{
            //        Console.WriteLine("Silme İşlemi Başarılı");

            //}



            // CATEGORY GETİRME
            //----------------------------------------

            //var category = categoryCrude.Get(2);

            //if (category != null)
            //{
            //    Console.WriteLine($"Name: {category.Name}");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found Category");
            //}



            // CATEGORYLİSTESİNİ GETİRME
            //----------------------------------------
            //if (categoryCrude.GetList().Count>0)
            //{
            //    foreach (var item in categoryCrude.GetList())
            //    {
            //        Console.WriteLine($"Name: {item.Name} \t\t Status: {item.IsStatus}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Kategori Listesi Boş");
            //}

            // CATEGORY UPDATE
            //----------------------------------------
            //var category = new Category()
            //{
            //    Name = "TV",
            //    Description = "TV Kategori"
            //};
            //if (categoryCrude.Update(category, 1))
            //{
            //    Console.WriteLine( "Düzenleme Başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Düzenleme Başarısız");
            //}


            //-------------------------------------SINIF ÇALIŞMASI------------------------------------
            //-------------------------------------------------------------------------------------------
            Console.WriteLine("--------- Product Magament ---------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Select Proccess: ");
            Console.WriteLine("Category Proccess (1): ");
            Console.WriteLine("Product Proccess  (2): ");
            Console.WriteLine("Exit Program      (0): ");
            Console.Write("Select: ");
            int selectProccess = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (selectProccess)
            {
                case 1:
                    Console.WriteLine("--------- Category Proccess --------");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Select Proccess: ");
                    Console.WriteLine("Category List   (1): ");
                    Console.WriteLine("Get Category    (2): ");
                    Console.WriteLine("Add Category    (3): ");
                    Console.WriteLine("Update Category (4): ");
                    Console.WriteLine("Delete Category (5): ");
                    Console.WriteLine("Back Proccess  (0): ");
                    Console.Write("Select: ");


                    int selectCategoryProccess = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    
                    switch (selectCategoryProccess)
                    {


                        //GET CATEGORY 
                        case 2:
                            if (categoryCrude.GetList().Count > 0)
                            {
                                foreach (var item in categoryCrude.GetList())
                                {
                                    Console.WriteLine($"Id: {item.Id} \t Name: {item.Name}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Category Listesi Boş");

                            }
                           
                           
                            break;

                            //ADD CATEGORY

                        case 3:
                            if (categoryCrude.GetList().Count > 0)
                            {
                                foreach (var item in categoryCrude.GetList())
                                {
                                    Console.WriteLine($"Id: {item.Id} \t Name: {item.Name}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Category Listesi Boş");
                            }

                            Category category1 = new Category();
                            Console.Write("Category Id: ");
                            category1.Id = Convert.ToInt32(Console.ReadLine());
                            break;
                            //UPDATE CATEGORY

                        case 4:
                            var category = new Category()

                            {
                                Name = "TV",
                                Description = "TV Kategori"
                            };
                            if (categoryCrude.Update(category, 1))
                            {
                                Console.WriteLine("Düzenleme Başarılı");
                            }
                            else
                            {
                                Console.WriteLine("Düzenleme Başarısız");
                            }

                            break;
                    }

                    break;



                case 2:
                    Console.WriteLine("--------- Product Proccess ---------");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Select Proccess: ");
                    Console.WriteLine("Product List   (1): ");
                    Console.WriteLine("Get Product    (2): ");
                    Console.WriteLine("Add Product    (3): ");
                    Console.WriteLine("Update Product (4): ");
                    Console.WriteLine("Delete Product (5): ");
                    Console.WriteLine("Back Proccess  (0): ");
                    Console.Write("Select: ");
                    int selectProductProccess = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (selectProductProccess)
                    {

                        //GET PRODUCT
                        case 2:

                            var category = categoryCrude.Get(2);

                            if (category != null)
                            {
                                Console.WriteLine($"Name: {category.Name} \t \t  ");
                            }
                            else
                            {
                                Console.WriteLine("Not Found Category");
                            }



                            break;


                        //ADD PRODUCT
                        case 3:
                            if (categoryCrude.GetList().Count > 0)
                            {
                                foreach (var item in categoryCrude.GetList())
                                {
                                    Console.WriteLine($"Id: {item.Id} \t Name: {item.Name}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Kategori Listesi Boş");
                            }

                            Product product0 = new Product();
                            Console.Write("Category Id: ");
                            product0.CategoryId = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }

    }
}
