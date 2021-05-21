using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ClairesHairCare.Models;

namespace ClairesHairCare.Controllers
{
  public class ClientsController : Controller
  {
    private readonly ClairesHairCareContext _db;

    public ClientsController(ClairesHairCareContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> listOfClients = _db.Clients.Include(client => client.Stylist).ToList();
      return View(listOfClients);
    }
  }
}