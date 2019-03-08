//Cat Class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
	class Cat:Pet
	{
		public Cat(string name, string owner,double weight):base(string.Empty,name,owner,weight)
		{
			this.name=name;
			this.owner=owner;
			this.weight=weight;
		}
		public string meow(int count)
		{
			string meow="";
			for (int i=0;i<count;i++)
			{
				meow=meow+"meow.";
			}
			return meow;
		}
	}
}