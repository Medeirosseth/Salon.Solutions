using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ClairesHairCare.Models;

namespace ClairesHairCare.Controllers
{
  public class StylistsController : Controller
  {
    private readonly ClairesHairCareContext _db;

    public StylistsController(ClairesHairCareContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }

    public ActionbResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActioinResult Create(Stylist stylist)
    {
      _db.Stylist.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist thisStylist = _db.Stylist.FirstOrDefault(Stylist => stylist.StylistId == id);
      thisStylist.Clients = _db.Clients.Where(ClientsController => client.ClientId == id).ToList();
      return View(thisStylist);
    }
  }
}
