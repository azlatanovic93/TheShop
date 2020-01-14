using System.Collections.Generic;
using TheShop.Models;

namespace TheShop.Suppliers
{
	public class Supplier3 : SupplierBase
	{
		protected override int Id => 1;
		protected override string NameOfArticle => "Article from supplier3";
		protected override int ArticlePrice => 460;

        public Supplier3()
        {
            _articles = new List<Article>()
        {
            new Article() { ID = 1, NameOfArticle = "Article 1 from supplier3", ArticlePrice = 460 },
            new Article() { ID = 3, NameOfArticle = "Article 3 from supplier3", ArticlePrice = 270 },
            new Article() { ID = 8, NameOfArticle = "Article 4 from supplier3", ArticlePrice = 340 },
            new Article() { ID = 9, NameOfArticle = "Article 9 from supplier3", ArticlePrice = 312 },
            new Article() { ID = 10, NameOfArticle = "Article 10 from supplier3", ArticlePrice = 101 },
            new Article() { ID = 11, NameOfArticle = "Article 11 from supplier3", ArticlePrice = 215 }
        };
        }

    }
}