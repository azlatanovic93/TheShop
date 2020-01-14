using System.Collections.Generic;
using TheShop.Models;

namespace TheShop.Suppliers
{
	public abstract class SupplierBase : ISupplier
	{
		protected abstract int Id { get; }
		protected abstract string NameOfArticle { get; }
		protected abstract int ArticlePrice { get; }
        protected List<Article> _articles;
        public void UpdateArticle(Article article)
        {
            foreach(Article article1 in _articles)
            {
                if(CompareArticles(article, article1))
                {
                    article1.IsSold = article.IsSold;
                    article1.SoldDate = article.SoldDate;
                    article1.BuyerUserId = article.BuyerUserId;
                    break;
                }
            }
        }

        public bool CompareArticles(Article article1, Article article2)
        {
            if (article1.ID == article2.ID
                && article1.NameOfArticle == article2.NameOfArticle
                && article1.ArticlePrice == article2.ArticlePrice)
                return true;
            return false;
        }

        public bool ArticleInInventory(int id)
		{
            foreach(Article article in _articles)
            {
                if (article.IsSold)
                    return false;
            }
			return true;
		}
		
		public Article GetArticle(int id)
		{
            foreach(Article article in _articles)
            {
                if (article.ID == id)
                    return article;
            }
            return null;

			//return new Article()
			//{
			//	ID = Id,
			//	NameOfArticle = NameOfArticle,
			//	ArticlePrice = ArticlePrice
			//};
		}
	}
}