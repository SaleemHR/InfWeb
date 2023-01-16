namespace Lecture0EF;
enum Gender{Female, Male}
class Person{
  public int ID { get; set; }
  public string Name { get; set; }
  public Gender Gender{get;set;}
  public string  Address { get; set; }
  public string PostCode  { get; set; } //check format

  public string TelNr {get;set;}

  public string Email{get;set;}

  public string IBAN { get; set; }
  public string AccountTitle{get;set;}
  public decimal Dontation {get;set;}

  public ICollection<Payment> Payments{get;set;} //Collection Navigation Property

}

class Payment{
  public int ID { get; set; }
  public DateOnly PaymentDate  { get; set; }
  public int PersonID {get;set;}
  public Person?  Person { get; set; }
  public decimal Amount{get;set;} //to record changes in contribution if any later.
  public string IBAN{get;set;} //for book keeping if required
  public string TrasactionID{get;set;} //for book keeping if required
}