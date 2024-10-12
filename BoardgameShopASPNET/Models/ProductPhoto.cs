namespace BoardgameShopASPNET.Models
{
    public class ProductPhoto
    {
        public List<Product> _products { get; set; }
        public List<CartPhoto> _cartPhotos { get; set; }
        public List<Photo> _photos { get; set; }

        public ProductPhoto(List<Product> products, List<CartPhoto> cartPhotos, List<Photo> photos) 
        {
            _products = products;
            _cartPhotos = cartPhotos;
            _photos = photos;
        }
    }
}
