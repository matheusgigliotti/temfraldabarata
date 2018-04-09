// OffersModel.cs
// 
using System;
namespace TemFraldaBarata.Core.Features
{
	public class OffersModel : BaseModel
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string Date { get; set; }
		public string PromoCode { get; set; }
		public string Url { get; set; }
		public string Cover { get; set; }
		public string FullPrice { get; set; }
		public string ActualPrice { get; set; }
		public int Rating { get; set; }
		public OffersCategory Category { get; set; }
	}

	public enum OffersCategory
	{
		Dipers,
		CarSeat,
		Stroller,
		Bathtime,
		Clothing,
		Toys,
		Feeding,
	}
}