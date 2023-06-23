using Demo.DependencyInjection.Model;
using System.Collections.Generic;

namespace Demo.DependencyInjection.Data
{
	public interface IStadionReader
	{
		List<Stadion> LadenStadien(string land);
	}
}