using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penso.Common.Mapper
{
	public static class ModelMapper
	{
		private static readonly MapperConfiguration mapperConfig;
		private static readonly IMapper mapper;
		static ModelMapper()
		{
			mapperConfig = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<Persistance.Models.User, Domain.User>().ReverseMap();
			});

			mapper = mapperConfig.CreateMapper();
		}

		public static TResult Map<TResult>(object source)
		{
			return mapper.Map<TResult>(source);
		}

		public static IEnumerable<TResult> Map<TResult>(IEnumerable<object> source)
		{
			return mapper.Map<IEnumerable<TResult>>(source);
		}
	}
}
