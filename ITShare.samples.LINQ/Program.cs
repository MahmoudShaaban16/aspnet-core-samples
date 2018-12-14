using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace ITShare.samples.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            ITShareDBEntities db = new ITShareDBEntities();
            db.GetProductDetails();
            /// lambda and functions
            /// 
            var results = db.Products
                .Include(x => x.OrderItems)
                .Where(prod => prod.Id >= 2)
                .GroupBy(x => x.Id)
                .Select(r=> new {Count=r.Count(),Id=r.Key });

            foreach(var res in results)
            {
                int productId = res.Id;
                int orderItemsCount = res.Count;
            }
             

            // linq example
            var queryResult = GetSelectStement(db);
            var products = queryResult.AsQueryable();

            
        }
        static IQueryable GetSelectStement(ITShareDBEntities db)
        {



            return (from Product p in db.Products
                    join orderItem in db.OrderItems on p.Id equals orderItem.ProductId
                    where (p.Id >= 2) ///&&() || ()
                    group p by p.Id into gp
                    select new { Id = gp.Key, Count = gp.Count() });
        }
    }
}
