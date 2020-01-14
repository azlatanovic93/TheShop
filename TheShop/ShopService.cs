using System;
using System.Collections.Generic;
using System.Linq;
using TheShop.Models;
using TheShop.Suppliers;

namespace TheShop
{
	public class ShopService : IShopService
	{
		private readonly DatabaseDriver _databaseDriver;
		private readonly Logger _logger;
		private List<ISupplier> _suppliers;

		public ShopService()
		{
			_databaseDriver = new DatabaseDriver();
			_logger = new Logger();
			_suppliers = new List<ISupplier>()
			{
				new Supplier1(),
				new Supplier2(),
				new Supplier3()
			};
		}

		public void OrderAndSellArticle(int id, int maxExpectedPrice, int buyerId)
        {
            #region ordering article

            Article article = OrderArticle(id, maxExpectedPrice);

            #endregion

            #region selling article

            SellArticle(id, buyerId, article);

            #endregion
        }

        private void SellArticle(int id, int buyerId, Article article)
        {
            try
            {
                if (article == null)
                {
                    throw new Exception("Could not order article");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }

            _logger.Debug("Trying to sell article with ID = " + id);

            //_suppliers.Where(s => s.GetArticle(id).NameOfArticle == article.NameOfArticle).; //  s.GetArticle(id).IsSold = true);

            article.IsSold = true;
            article.SoldDate = DateTime.Now;
            article.BuyerUserId = buyerId;
            _suppliers.ForEach(s => s.UpdateArticle(article));

            try
            {
                _databaseDriver.Save(article);
                _logger.Info("Article with ID = " + id + " is sold.");
            }
            catch (Exception)
            {
                string errorMessage = "Could not save article with ID = " + id;
                _logger.Error(errorMessage);
                Console.WriteLine(errorMessage);
                //throw new Exception(errorMessage);
            }
        }

        private Article OrderArticle(int id, int maxExpectedPrice)
        {
            Article article = null;
            var articlesInInventory = _suppliers.Where(s => s.ArticleInInventory(id)).ToArray();
            if (articlesInInventory.Length > 0)
            {
                var minPrice = articlesInInventory.Min(s => s.GetArticle(id).ArticlePrice);
                article = articlesInInventory.Select(s => s.GetArticle(id))
                    .FirstOrDefault(s => s.ArticlePrice == minPrice && s.ArticlePrice <= maxExpectedPrice);
            }

            return article;
        }

        public Article GetById(int id)
		{
			return _databaseDriver.GetById(id);
		}
	}
}