// IOffersService.cs
// 
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace TemFraldaBarata.Core.Features
{
	public interface IOffersService
	{
		Task<ObservableCollection<OffersModel>> GetAllAsync();
	}

	public class FakeOffersService : IOffersService
	{
		public Task<ObservableCollection<OffersModel>> GetAllAsync() => All();

		async Task<ObservableCollection<OffersModel>> All()
		{
			await Task.Delay(900);

			return new ObservableCollection<OffersModel>
			{
				new OffersModel {
					Title="Kit com 3 Fraldas PAMPERS Premium Care XG Mega - 96 Fraldas",
					FullPrice = "R$ 194,70",
					ActualPrice = "R$ 93,90",
					Category = OffersCategory.Dipers,
					Date = "31/02/2013",
					Cover = "https://media.netfarma.com.br/produtos/kit-fraldas-pampers-premium-care-xxg-mega-3-x-32un_zoom.jpg",
					Url = "https://www.netfarma.com.br/kit-fraldas-pampers-premium-care-xxg-mega-3-x-32un?gclid=CjwKCAiA78XTBRBiEiwAGv7EKtN63u6M_N8vBYUKQBZ5UJmtbwSetWwHXHzOL8GQQx-I9bfhafDPIBoC0PMQAvD_BwE"
				},
				new OffersModel {
					Title="Kit com 3 Fraldas PAMPERS Premium Care XG Mega - 96 Fraldas",
					FullPrice = "R$ 194,70",
					ActualPrice = "R$ 93,90",
					Category = OffersCategory.Dipers,
					Date = "31/02/2013",
					Cover = "https://media.netfarma.com.br/produtos/kit-fraldas-pampers-premium-care-xxg-mega-3-x-32un_zoom.jpg",
					Url = "https://www.netfarma.com.br/kit-fraldas-pampers-premium-care-xxg-mega-3-x-32un?gclid=CjwKCAiA78XTBRBiEiwAGv7EKtN63u6M_N8vBYUKQBZ5UJmtbwSetWwHXHzOL8GQQx-I9bfhafDPIBoC0PMQAvD_BwE"
				},
				new OffersModel {
					Title="Kit com 3 Fraldas PAMPERS Premium Care XG Mega - 96 Fraldas",
					FullPrice = "R$ 194,70",
					ActualPrice = "R$ 93,90",
					Category = OffersCategory.Dipers,
					Date = "31/02/2013",
					Cover = "https://media.netfarma.com.br/produtos/kit-fraldas-pampers-premium-care-xxg-mega-3-x-32un_zoom.jpg",
					Url = "https://www.netfarma.com.br/kit-fraldas-pampers-premium-care-xxg-mega-3-x-32un?gclid=CjwKCAiA78XTBRBiEiwAGv7EKtN63u6M_N8vBYUKQBZ5UJmtbwSetWwHXHzOL8GQQx-I9bfhafDPIBoC0PMQAvD_BwE"
				},
				new OffersModel {
					Title="Pomada Preventiva de Assaduras Hipoglós ",
					FullPrice = "R$ 38,47",
					ActualPrice = "R$ 21,35",
					Category = OffersCategory.Dipers,
					Date = "31/02/2013",
					Cover = "https://media.netfarma.com.br/produtos/kit-fraldas-pampers-premium-care-xxg-mega-3-x-32un_zoom.jpg",
					Url = "https://media.netfarma.com.br/produtos/pomada-preventiva-de-assaduras-hipoglos-90g_zoom.jpg"
				}
			};
		}
	}
}
