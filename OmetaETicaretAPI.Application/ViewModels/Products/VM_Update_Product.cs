using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmetaETicaretAPI.Application.ViewModels.Products
{
	public class VM_Update_Product
	{
        public string Id { get; set; }
		public string Name { get; set; }

		public string Description { get; set; }

        public int Stock { get; set; }

        public int Price { get; set; }
    }
}
