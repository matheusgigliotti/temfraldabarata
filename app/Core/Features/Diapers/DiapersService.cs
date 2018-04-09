// DiapersService.cs
// 
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace TemFraldaBarata.Core.Features
{
	public interface IDiapersService
	{
		Task<ObservableCollection<OffersModel>> GetAllAsync();
	}

	public class DiapersService : IDiapersService
	{
		readonly IOffersService _offersService;

		public DiapersService(IOffersService offersService)
		{
			_offersService = offersService;
		}


		public async Task<ObservableCollection<OffersModel>> GetAllAsync()
		{
			var offers = await _offersService.GetAllAsync();

			return offers.Where(o => o.Category == OffersCategory.Dipers)


		}
	}
}
