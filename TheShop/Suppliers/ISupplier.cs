using TheShop.Models;

namespace TheShop.Suppliers
{
	public interface ISupplier
	{
		bool ArticleInInventory(int id);
		Article GetArticle(int id);
        void UpdateArticle(Article article);
        bool CompareArticles(Article article1, Article article2);
        
	}
}