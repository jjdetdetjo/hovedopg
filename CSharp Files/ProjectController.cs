using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hvdopg.CSharp_Files
{
    public class ProjectController
    {
        public ActionResult GetAllTickets()

        {

            try

            {

                List<Ticket> tickets = repo.GetAllTickets();

                return Json(tickets, JsonRequestBehavior.AllowGet);

            }

            catch (Exception e)

            {

                Logger.Error(e, e.Message);

                return Error(HttpStatusCode.InternalServerError, $"Failed to get tickets", e);

            }

        }
    }
}
