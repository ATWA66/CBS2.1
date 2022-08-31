Address instance = new Address(04075, "Ukraine", "kiev", "lisna", "60a", 9);
instance.print();
class Address 
{
    public int index { get; set; }
    public string country { get; set; }
    public string city { get; set; }
    public string street { get; set; }
    public string house { get; set; }
    public int apartment { get; set; }
    public Address(int index, string country, string city, string street, string house, int apartment)
    {
        this.index = index;
        this.country = country;
        this.city = city;
        this.street = street;
        this.house = house;
        this.apartment = apartment;
    }
    public void print()
    {
        Console.WriteLine("index -"+index);
        Console.WriteLine("country -" + country);
        Console.WriteLine("city -" + city);
        Console.WriteLine("street -" + street);
        Console.WriteLine("house -" + house);
        Console.WriteLine("apartment -" + apartment);
    }
}
