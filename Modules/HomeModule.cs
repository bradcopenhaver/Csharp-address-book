using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        List<Contact> allContacts = Contact.GetAllContacts();

        return View["index.cshtml", allContacts];
      };
      Post["/"] = _ =>
      {
        Address newAddress = new Address(Request.Form["street"], Request.Form["city"], Request.Form["state"], Request.Form["zip"]);
        Contact newContact = new Contact(Request.Form["firstName"], Request.Form["lastName"], Request.Form["phone"], Request.Form["email"], newAddress);
        List<Contact> allContacts = Contact.GetAllContacts();

        return View["index.cshtml", allContacts];
      };
      Get["/contact/new"] = _ => View["contact_form.cshtml"];
      Get["/contact/{id}"] = parameters =>
      {
        Contact currentContact = Contact.Find(parameters.id);

        return View["contact_details.cshtml", currentContact];
      };
    }
  }
}
