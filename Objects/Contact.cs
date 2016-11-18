using System.Collections.Generic;

namespace AddressBook.Objects
{
  public Class Contact
  {
    private string _firstName;
    private string _lastName;
    private string _phone;
    private string _email;
    private Address _address;
    private int _id;

    private static List<Contact> _instances = new List<Contact>{};

    public Contact(firstName, lastName, phone, email, address)
    {
      _firstName = firstName;
      _lastName = lastName;
      _phone = phone;
      _email = email;
      _address = address;

      _instances.Add(this);
      _id = _instances.Count;
    }
  }
}
