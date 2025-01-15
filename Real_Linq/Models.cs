public class People
{
    public People(int number, string name, string fullname)
    {
        Number = number;
        Name = name;
        Fullname = fullname;
    }
    public string Name { get; set; }
    public string Fullname { get; set; }
    public int Number { get; set; }

}