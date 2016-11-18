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
    public string GetFirstName()
    {
      return _firstName;
    }
    public void SetFirstName(newName)
    {
      _firstName = newName;
    }
    public string GetLastName()
    {
      return _lastName;
    }
    public void SetLastName(newName)
    {
      _lastName = newName;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public void SetPhone(newPhone)
    {
      _phone = newPhone;
    }
    public string GetEmail()
    {
      return _email;
    }
    public void SetEmail(newEmail)
    {
      _email = newEmail;
    }
    public Address GetAddress()
    {
      return _address;
    }
    public void SetAddress(newAddress)
    {
      _address = newAddress;
    }
    public int GetId()
    {
      return _id;
    }
    public static void GetAllContacts()
    {
      return _instances;
    }
    public static void ClearAllContacts()
    {
      _instances.Clear();
    }
    public static Contact Find(searchId)
    {
      return _instances[searchId-1];
    }
  }
}
