using TravelProject.Models;

namespace TravelProject.Data
{
    public class ProductRepository
    {
        private static List<Product>? _products=null;
        static ProductRepository()
        {
            _products=new List<Product>
            {
                new Product{ProductId=1,Name="NEVŞEHİR KAPADOKYA",Price=48000,Description="YURT İÇİ TATİL",ImageUrl="kapadokya.png",CategoryId=2},
                new Product{ProductId=2,Name="BURSA CUMALIKIZIK",Price=44000,Description="YURT İÇİ TATİL",ImageUrl="cumalıkızık.png",CategoryId=2},
                new Product{ProductId=3,Name="BOLU YEDİGÖLLER",Price=30000,Description="YURT İÇİ TATİL",ImageUrl="yedigöller.jpg",CategoryId=2},
                new Product{ProductId=4,Name="ESKİŞEHİR ODUNPAZARI",Price=33000,Description="YURT İÇİ TATİL",ImageUrl="odunpazarı.png",CategoryId=2},
                new Product{ProductId=5,Name="KIRKLARELİ İĞNEADA",Price=50000,Description="YURT İÇİ TATİL",ImageUrl="iğneada.jpg",CategoryId=2},
                new Product{ProductId=6,Name="PAMUKKALE TRAVERTENLERİ",Price=30000,Description="YURT İÇİ TATİL",ImageUrl="pamukkale.jpg",CategoryId=2},
                new Product{ProductId=7,Name="PRAG",Price=480000,Description="YURT DIŞI TATİL",ImageUrl="prag.png",CategoryId=3},
                new Product{ProductId=8,Name="MILANO",Price=190000,Description="YURT DIŞI TATİL",ImageUrl="milano.jpg",CategoryId=3},
                new Product{ProductId=9,Name="ROMA",Price=110000,Description="YURT DIŞI TATİL",ImageUrl="roma.jpeg",CategoryId=3},
                new Product{ProductId=10,Name="BERLİN",Price=30000,Description="YURT DIŞI TATİL",ImageUrl="berlin.jpg",CategoryId=3},
                new Product{ProductId=11,Name="BUDAPEŞTE",Price=15000,Description="YURT DIŞI TATİL",ImageUrl="budapeşte.jpg",CategoryId=3},
                new Product{ProductId=12,Name="VİYANA",Price=15000,Description="YURT DIŞI TATİL",ImageUrl="viyana.jpg",CategoryId=3}
            };
        }
        public static List<Product>?Product
        {
            get
            {
                return _products;
            }
        }
        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p=>p.ProductId==id);
        }        
    }
}