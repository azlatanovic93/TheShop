﻿using System;

namespace TheShop.Models
{
	public class Article
	{
		public int ID { get; set; }
		public string NameOfArticle { get; set; }
		public int ArticlePrice { get; set; }
		public bool IsSold { get; set; }
		public DateTime SoldDate { get; set; }
		public int BuyerUserId { get; set; }
	}
}