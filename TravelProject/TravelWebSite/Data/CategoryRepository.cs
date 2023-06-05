using TravelProject.Models;

namespace TravelProject.Data
{
    public class CategoryRepository
    {
        private static List<Category>? _categories=null;
        static CategoryRepository()
        {
            _categories=new List<Category>
            {
                new Category{CategoryId=1,Name="Tüm Seyehatler"},
                new Category{CategoryId=2,Name="Yurt İçi Seyehatler"},
                new Category{CategoryId=3,Name="Yurt Dışı Seyehatler"}
            };
        }
        public static List<Category>?Category
        {
            get
            {
                return _categories;
            }
        }
        public static void AddCategory(Category categories)
        {
            _categories.Add(categories);
        }
        public static Category GetCategoryById(int id)
        {
            return _categories.FirstOrDefault(c=>c.CategoryId==id);
        }        
    }
}