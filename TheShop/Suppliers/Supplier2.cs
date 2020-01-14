using System.Collections.Generic;
using TheShop.Models;

namespace TheShop.Suppliers
{
	public class Supplier2 : SupplierBase
	{
		protected override int Id => 1;
		protected override string NameOfArticle => "Article from supplier2";
		protected override int ArticlePrice => 459;
        
        public Supplier2()
        {
            _articles = new List<Article>()
        {
            new Article() { ID = 1, NameOfArticle = "Article 1 from supplier2", ArticlePrice = 459 },
            new Article() { ID = 2, NameOfArticle = "Article 2 from supplier2", ArticlePrice = 297 },
            new Article() { ID = 3, NameOfArticle = "Article 3 from supplier2", ArticlePrice = 360 },
            new Article() { ID = 4, NameOfArticle = "Article 4 from supplier2", ArticlePrice = 200 },
            new Article() { ID = 5, NameOfArticle = "Article 5 from supplier2", ArticlePrice = 190 },
            new Article() { ID = 6, NameOfArticle = "Article 6 from supplier2", ArticlePrice = 278 },
            new Article() { ID = 7, NameOfArticle = "Article 7 from supplier2", ArticlePrice = 403 },
            new Article() { ID = 8, NameOfArticle = "Article 8 from supplier2", ArticlePrice = 330 },
            new Article() { ID = 9, NameOfArticle = "Article 9 from supplier2", ArticlePrice = 309 }
        };
        }
    }
}