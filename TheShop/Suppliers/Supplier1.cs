using System.Collections.Generic;
using TheShop.Models;

namespace TheShop.Suppliers
{
	public class Supplier1 : SupplierBase
	{
		protected override int Id => 1;
		protected override string NameOfArticle => "Article from supplier1";
		protected override int ArticlePrice => 458;

        public Supplier1()
        {
            _articles = new List<Article>()
        {
            new Article() { ID = 1, NameOfArticle = "Article 1 from supplier1", ArticlePrice = 458 },
            new Article() { ID = 2, NameOfArticle = "Article 2 from supplier1", ArticlePrice = 302 },
            new Article() { ID = 3, NameOfArticle = "Article 3 from supplier1", ArticlePrice = 200 },
            new Article() { ID = 4, NameOfArticle = "Article 4 from supplier1", ArticlePrice = 300 },
            new Article() { ID = 5, NameOfArticle = "Article 5 from supplier1", ArticlePrice = 100 },
            new Article() { ID = 7, NameOfArticle = "Article 7 from supplier1", ArticlePrice = 400 },
            new Article() { ID = 10, NameOfArticle = "Article 7 from supplier1", ArticlePrice = 97 }
        };
        }
    }
}