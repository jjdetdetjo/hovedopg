using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hvdopg.CSharp_Files
{
    public class ProjectRepository
    {
        //public List<Ticket> GetTickets(int categoryId)

        //{

        //    using (var ctx = new DataModelContainer())

        //    {

        //        return ctx.HappyFoxTickets

        //            .Where(x => x.CategoryId == categoryId && !x.Status.Equals("Closed"))

        //            .Select(x => new JSONResponseDefinitions.Ticket

        //            {

        //                Id = x.Id,

        //                Name = x.Name,

        //                CategoryId = x.CategoryId,

        //                Status = x.Status,

        //                DisplayId = x.DisplayId,

                        Estimate = x.Estimate,

                        TimeSpent = x.TimeSpent,

                        Assignee = x.Assignee

        //            }

        //            ).ToList();

        //    }

        //}



        public List<Ticket> GetAllTickets()

        {

            using (var ctx = new DataModelContainer())

            {

                return ctx.HappyFoxTickets

                    .Where(x => !x.Status.Equals("Closed"))

                    .Select(x => new Ticket

                    {

                        Id = x.Id,

                        Name = x.Name,

                        CategoryId = x.CategoryId,

                        Status = x.Status,

                        DisplayId = x.DisplayId,

                        Estimate = x.Estimate,

                        TimeSpent = x.TimeSpent,

                        Assignee = x.Assignee

                    }

                    ).ToList();

            }

        }
    }
}
