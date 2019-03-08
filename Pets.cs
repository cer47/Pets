using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
	class Pet
	{
		public string type {set;get;}
		public string name {set;get;}
		public string owner {set;get;}
		public double weight {set;get;}
		
		public Pet(string type,string name,string owner,string weight)
		{
			this.type=type;
			this.name=name;
			this.owner=owner;
			this.weight=weight;
		}
		public string getTag()
		{
			return "If lost, call"+this.owner+".";
		}
	}
}