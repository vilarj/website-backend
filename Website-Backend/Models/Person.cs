public class Person
{
    public int Id { get; set; }
    public string First { get; set; }
    public string Last { get; set; }
    public string Dob { get; set; }

    public Person (int Id, string First, string Last, string Dob)
    {
        this.Id = Id;
        this.First = First;
        this.Last = Last;
        this.Dob = Dob;
    }

    public Person ()
    {
        Id = 0;
        First = "James";
        Last = "Harden";
        Dob = "01-01-1111";
    }
}