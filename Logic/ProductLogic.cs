using Models.Product;

namespace Logic.ProductLogic
{
    public class ProductLogic : BaseLogic
    {
        public ProductLogic() { }

        /// <summary>
        /// Получение продукта
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Product GetProduct(int Id)
        {
            return new Product();
        }

        /// <summary>
        /// Получение списка продуктов
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProduct()
        {
            return new List<Product>();
        }
    }
}
