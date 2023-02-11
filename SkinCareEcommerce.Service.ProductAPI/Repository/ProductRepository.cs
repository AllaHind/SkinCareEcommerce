using SkinCareEcommerce.Service.ProductAPI.DbContexts;
using SkinCareEcommerce.Service.ProductAPI.Models;
using SkinCareEcommerce.Service.ProductAPI.Models.Dto;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text;

namespace SkinCareEcommerce.Service.ProductAPI.Repository
{
    public class ProductRepository: IProductRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        //Injection des dependece (constructeurs)
        public ProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        // La première ligne déclare une méthode asynchrone qui retourne un objet de type ProductDto et prend en paramètre un objet de type ProductDto également.

        public async Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
             // Product product =  await _db.Products.Where(x => x.ProductId ==productDto.ProductId).FirstOrDefaultAsync();
             //La ligne suivante utilise un objet "mapper" pour convertir l'objet productDto en un objet "Product"
           Product pr = _mapper.Map<Product>(productDto);
             // La ligne suivante utilise une condition "if" pour vérifier si l'identifiant de produit (ProductId) est inférieur ou égal à 0. Si c'est le cas, cela signifie qu'il s'agit d'un nouveau produit qui doit être ajouté à la base de données.

            if (pr.ProductId <= 0) {

             // La ligne suivante utilise la méthode "Add" pour ajouter le nouveau produit à la base de données.

             // La ligne suivante utilise la méthode "SaveChanges" pour enregistrer les modifications dans la base de données.
                _db.Products.Add(pr);
                _db.SaveChanges();
                 }
            // La ligne suivante est un "else", qui est exécuté si l'identifiant de produit est supérieur à 0. Cela signifie qu'il s'agit d'un produit existant qui doit être mis à jour dans la base de données.

            else
            {
            // La ligne suivante utilise la méthode "Update" pour mettre à jour le produit dans la base de données.

            // La ligne suivante utilise la méthode "SaveChanges" pour enregistrer les modifications dans la base de données.


                _db.Products.Update(pr);
                _db.SaveChanges(); }

            // La dernière ligne utilise à nouveau l'objet "mapper" pour convertir l'objet "Product" mis à jour en un objet "ProductDto" et le retourne

            return _mapper.Map<ProductDto>(pr); ;
        }

        public async Task <bool> DeleteProduct(int productId)
        {
            Product product = await _db.Products.Where(x => x.ProductId == productId).FirstOrDefaultAsync();
            if (product == null) { return false; } else {
                _db.Products.Remove(product);
                _db.SaveChanges(); return true;       
            }
           
        }

        public async Task<ProductDto> GetProductById(int productId)
        {
            Product product = await _db.Products.Where(x => x.ProductId == productId).FirstOrDefaultAsync();
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {

            List<Product> productList = await _db.Products.ToListAsync();
            return _mapper.Map<List<ProductDto>>(productList);
        }
    }
}
