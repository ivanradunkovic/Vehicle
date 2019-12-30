using System;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Net;
using Vehicle.Common;
using Vehicle.Models;
using Vehicle.Services;
using Vehicle.Services.Common;

namespace Vehicle.MVC.Controllers
{
    public class HomeController : Controller
    {

        // Vehicle service field.
        private IVehicleService vehicleService;
        private IMakeService makeService;

        #region constructor

        // Home controller constructor.
        public HomeController()
        {
            vehicleService = new VehicleService();
            makeService = new MakeService();
        }

        #endregion

        // Index page.
        // <returns>Index view.</returns>
        public ActionResult Index()
        {
            return View();
        }

        // Back to home page.
        // <returns>Index view.</returns>
        public ActionResult BackToHomePage()
        {
            return RedirectToAction("Index");
        }
       
        // New vehicle.
        // <param name="vehicle">Vehicle.</param>
        // <returns>Index view if model state is valid.</returns>
        [HttpPost]
        public async Task<ActionResult> NewVehicle(VehicleModelPoco vehicle)
        {
            if (ModelState.IsValid)
            {
                await vehicleService.InsertVehicleAsync(vehicle);
                return RedirectToAction("Index");
            }
            return View();
        }
             
        // Gets vehicles.
        // <param name="id">Id.</param>
        // <param name="makeId">Maker id.</param>
        // <param name="findVehicle">Find vehicle.</param>
        // <param name="sortField">Sort field.</param>
        // <param name="sortOrder">Sort order.</param>
        // <param name="pageNumber">Page number.</param>
        // <param name="pageSize">Page size.</param>
        // <param name="sorting">Sorting.</param>
        // <returns>Vehicles.</returns>
        public async Task<ActionResult> GetVehicles(Guid id, Guid? makeId, string findVehicle, string sortField, string sortOrder, int pageNumber = 1, int pageSize = 12, string sorting = "VehicleMaker.Name")
        {       
            try
            {
                PagingParameters paging = new PagingParameters(pageNumber, pageSize);
                VehicleFilter filtering = new VehicleFilter(id, findVehicle, makeId);
                
                ViewBag.SortMake = sorting == "VehicleMake.Name" ? "VehicleMake.Name desc" : "VehicleMake.Name";

                if (sorting.Contains("desc"))
                {
                    string[] sorts = sorting.Split();
                    sortField = sorts[0];
                    sortOrder = sorts[1];
                }
                else
                {
                    sortField = sorting;
                    sortOrder = "";
                }

                SortingParameters sortingFilter = new SortingParameters(sortField, sortOrder);

                ViewBag.Makes = new SelectList(await makeService.GetMakesAsync(), "Id", "Name");
                ViewBag.CurrentSort = sorting;
                ViewBag.CurrentSearch = findVehicle;
                ViewBag.CurrentMaker = makeId;

                return View(await vehicleService.GetVehiclesAsync(paging, filtering, sortingFilter));
            }
            catch
            {
                return new HttpNotFoundResult("There are no vehicles");
            }
       
        }   

        // <param name="id">Id.</param>
        // <returns>One vehicle.</returns>
        public async Task<ActionResult> MoreDetails(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var details = await vehicleService.GetVehicleAsync(id);

            if (details == null)
            {
                return HttpNotFound();
            }

            return View(details);
        }

        // Deletes vehicle.
        // <param name="id">Id.</param>
        // <returns>Get vehicles page.</returns>
        public async Task<ActionResult> DeleteVehicle(Guid id)
        {
            var vehicle =  await vehicleService.GetVehicleAsync(id);          

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else if (vehicle == null)
            {
                return HttpNotFound();
            }

            await vehicleService.DeleteVehicleAsync(id);

            return RedirectToAction("GetVehicles", new { id = id });
        }
    }
}