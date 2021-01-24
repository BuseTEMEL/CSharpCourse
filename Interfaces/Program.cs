using System;
using System.Net.Http.Headers;
using static Interfaces.Oracle;

namespace Interfaces
{
    class Program
    {

        static void Main(string[] args)
        {
            //InterfacesIntro();

            //InterfacesDemo();

            ICostumerDal[] costumerDals = new ICostumerDal[2]
            {
                new SqlServerCostumerDal(),
                new Oracle()
            };
            foreach (var costumerDal in costumerDals)
            {
                costumerDal.Updated();
            }
            

        Console.ReadLine();
        }

    private static void InterfacesDemo()
    {
        CostumerManager costumerManager = new CostumerManager();
        costumerManager.Add(new SqlServerCostumerDal());
    }

    private static void InterfacesIntro()
    {
        PersonManager manager = new PersonManager();
        Costumer costumer = new Costumer
        {
            Id = 1,
            Firstname = "Özkan",
            Lastname = "TORAMAN",
            Address = "istanbul"
        };
        Student student = new Student
        {
            Id = 2,
            Firstname = "Buse",
            Lastname = "TEMEL",
            Depatmant = "Computer Seciences"
        };
        manager.Add(costumer); /*(new Costumer { Id = 1, Firstname = "Özkan", Lastname = "TORAMAN", Address = "istanbul" });*/
    }
}

interface IPerson
{
    int Id { get; set; }
    string Firstname { get; set; }
    string Lastname { get; set; }
}

class Costumer : IPerson
{
    public int Id { get; set; }
    public String Firstname { get; set; }
    public string Lastname { get; set; }

    public string Address { get; set; }
}
class Student : IPerson
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public string Depatmant { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.Lastname);
    }
}
}
