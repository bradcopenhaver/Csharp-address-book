using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Address
  {
    private string _street;
    private string _city;
    private string _state;
    private string _zip;
    private int _id;

    private static List<Address> _instances = new List<Address>{};

    public Address(string street, string city, string state, string zip)
    {
      _street = street;
      _city = city;
      _state = state;
      _zip = zip;

      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetStreet()
    {
      return _street;
    }
    public void SetStreet(string newStreet)
    {
      _street = newStreet;
    }
    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string newCity)
    {
      _city = newCity;
    }
    public string GetState()
    {
      return _state;
    }
    public void SetState(string newState)
    {
      _state = newState;
    }
    public string GetZip()
    {
      return _zip;
    }
    public void SetZip(string newZip)
    {
      _zip = newZip;
    }
    public int GetId()
    {
      return _id;
    }
    public static Address Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public static void ClearAllAddresses()
    {
      _instances.Clear();
    }
  }
}
