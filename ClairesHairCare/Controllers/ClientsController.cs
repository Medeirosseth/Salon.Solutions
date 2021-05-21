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

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Sylists, "StylistId", "StylistName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(ClientsController => client.ClientId == id);
      return View(thisClient);
    }

    public ActionResult Edit(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(ClientsController => client.ClientId == id);
      ViewBag.StylistId = new SelectList(_db.Stylist, "StylistId", "StylistName");
      return View(thisClient);
    }

    [HttpPost]

    public ActionResult Edit(Client client)
    {
      _db.Entry(client).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Client thisClient = _db.Client.FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    [HttpPost, ActionName("Delete")]

    public ActioinResult DeleteConfirmed(int id)
    {
      Client thisClient = _db.Client.FirstOrDefault(client => client.ClientId == id);
      _db.Client.Remove(thisClient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}