using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _firstName;
    private string _lastName;
    private string _phone;
    private string _email;
    private Address _address;
    private int _id;

    private static List<Contact> _instances = new List<Contact>{};

    public Contact(string firstName, string lastName, string phone, string email, Address address)
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
    public void SetFirstName(string newName)
    {
      _firstName = newName;
    }
    public string GetLastName()
    {
      return _lastName;
    }
    public void SetLastName(string newName)
    {
      _lastName = newName;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }
    public string GetEmail()
    {
      return _email;
    }
    public void SetEmail(string newEmail)
    {
      _email = newEmail;
    }
    public Address GetAddress()
    {
      return _address;
    }
    public void SetAddress(Address newAddress)
    {
      _address = newAddress;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Contact> GetAllContacts()
    {
      return _instances;
    }
    public static void ClearAllContacts()
    {
      _instances.Clear();
    }
    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
