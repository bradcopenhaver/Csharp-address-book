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
      }
      Post["/"] = _ =>
      {
        
      }
    }
  }
}
