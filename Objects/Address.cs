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

    public Address(street, city, state, zip)
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
    public void SetStreet(newStreet)
    {
      _street = newStreet;
    }
    public string GetCity()
    {
      return _city;
    }
    public void SetCity(newCity)
    {
      _city = newCity;
    }
    public string GetState()
    {
      return _state;
    }
    public void SetState(newState)
    {
      _state = newState;
    }
    public string GetZip()
    {
      return _zip;
    }
    public void SetZip(newZip)
    {
      _zip = newZip;
    }
    public int GetId()
    {
      return _id;
    }
    public static Address Find(searchId)
    {
      return _instances[searchId-1];
    }
    public static void ClearAllAddresses()
    {
      _instances.Clear();
    }
  }
}
