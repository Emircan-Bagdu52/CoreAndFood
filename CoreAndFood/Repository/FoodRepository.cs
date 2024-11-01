using CoreAndFood.Repository;
using CoreAndFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace CoreAndFood.Repository
{
	public class FoodRepository : GenericRepository<Food>
	{
		//	Context c=new Context();
		//	public List<Food> FoodList()
		//	{
		//		return c.Foods.ToList();
		//	}
		//	public void FoodAdd(Food f)
		//	{
		//		c.Foods.Add(f);
		//		c.SaveChanges();
		//	}

		//	public void FoodDelete(Food f)
		//	{
		//		c.Foods.Remove(f);
		//		c.SaveChanges();
		//	}
		//	public void FoodUpdate(Food f)
		//	{
		//		c.Foods.Update(f);
		//		c.SaveChanges();
		//	}
		//	public void GetFoot(int id)
		//	{
		//		c.Foods.Find(id);
		//	}

	}
}
