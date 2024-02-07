using System;
using Microsoft.AspNetCore.Mvc;
using MVC_TEST.Models;

namespace MVC_TEST.Models
{
	public class RamenFactory
	{
		static public List<HelloWorldModel> MakeRamens()
		{
			var ramens = new List<HelloWorldModel>
			{
				new HelloWorldModel{ id = 1, Name = "塩ラーメン", Price=1000},
			new HelloWorldModel { id = 2, Name = "味噌ラーメン", Price = 2000 },
			new HelloWorldModel { id = 3, Name = "二郎ラーメン", Price = 3000 },
		};
			return ramens;
		}
    }
}

