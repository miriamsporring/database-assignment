using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Nest;
using SuperYarnCompany.Entities;
using SuperYarnCompany.Models;
using SuperYarnCompany.Repositories;

namespace SuperYarnCompany.Services;

internal class ProductService
{
    private readonly ProductRepository _productRepository;
    private readonly CategoryRepository _categoryRepository;

    public ProductService(CategoryRepository categoryRepository, ProductRepository productRepository)
    {
        _categoryRepository = categoryRepository;
        _productRepository = productRepository;
    }

    // CREATE
    public async Task<bool> CreateProductAsync(ProductRegistrationForm form)
    {
        if (!await _productRepository.ExistsAsync(x => x.Name == form.Name))
        {
            //get or create category 
            var categoryEntity = await _categoryRepository.GetAsync(x => x.CategoryName == form.Name);
            categoryEntity ??= await _categoryRepository.CreateAsync(new CategoryEntity { CategoryName = form.Category });

            var productEntity = await _productRepository.CreateAsync(new ProductEntity()
            {
                Name = form.Name,
                Description = form.Description,
                Category = form.Category
            });   

        }
        return true;

    }











    //public async Task<Name> ViewAllProductsAsync(ProductRegistrationForm form)
    //{
    //    if (!await _productRepository.ExistsAsync(x => x.Name == form.Name))
    //    {


    //        var productEntity = await _productRepository.GetAllAscync(new ProductEntity()
    //        {
    //            Name = form.Name,
    //            Description = form.Description,
    //            Category = form.Category
    //        });

    //    }
    //    return true!;
    //}

}





    //var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
    //    return user != null; // Returnerar true om användaren med den givna e-postadressen finns, annars false.





//SE INSPELNING 15/11!!!



















