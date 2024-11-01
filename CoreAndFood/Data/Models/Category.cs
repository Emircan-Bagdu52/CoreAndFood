using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreAndFood.Data.Models
{
	public class Category
	{
        public int CategoryID { get; set; }

		[Required(ErrorMessage ="Category name not empty")]
		public string CategoryName { get; set; }

		public string CategoryDescription { get; set; }
        public bool Status { get; set; }

        public List<Food> Foods { get; set; }
    }
}
