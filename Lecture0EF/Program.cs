namespace Lecture0EF;

class Program{
  public static void Main(){
    MyContext db = new MyContext();
      //TestInsert(db);
      //TestSelectAll(db);
      FindPerson(db);
  }
  public static void FindPerson(MyContext db){
    string toFind = "Abdul";
    var x = db.Persons.FirstOrDefault(_=>_.Name.Contains(toFind));
    if(x is null)
      Console.WriteLine($"{toFind} is not available");
    else
      Console.WriteLine($"{x.ID}, {x.Name}, {x.Gender}, {x.Address}, {x.PostCode}, {x.TelNr}, {x.Email}, {x.IBAN}, {x.AccountTitle}, {x.Dontation}" );
  }
  public static void TestSelectAll(MyContext db){
    db.Persons.ToList().ForEach(x=>Console.WriteLine($"{x.ID}, {x.Name}, {x.Gender}, {x.Address}, {x.PostCode}, {x.TelNr}, {x.Email}, {x.IBAN}, {x.AccountTitle}, {x.Dontation}"  ));
  }
  public static void TestInsert(MyContext db){
    db.Persons.Add(
      new Person(){
        Name = "Abdullah",
        Gender = Gender.Male,
        Address = "Dennekruid 59",
        PostCode  = "3068SE", //check format all fields below
        TelNr = "+3168765123",
        Email= "abdullah@gmail.com",
        IBAN = "NL31ABNA123456789",
        AccountTitle = "Allah Da Banda",
        Dontation  = 20,
      }
    );

    db.Persons.Add(
      new Person(){
        Name = "Bint e Hawa",
        Gender = Gender.Female,
        Address = @"'SGravindijkWall 59",
        PostCode  = "1068SE", //check format all fields below
        TelNr = "+923335765123",
        Email= "noemail@gmail.com",
        IBAN = "ABC31ABNA123456789",
        AccountTitle = "B. Hawa",
        Dontation  = 10,
      }
    );

    Console.WriteLine($"{db.SaveChanges()} records added");

  }

}