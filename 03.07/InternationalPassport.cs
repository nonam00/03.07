namespace _03._07;
internal class InternationalPassport
{
    public int Id { get; set; }
    public string FirstName
    {
        get => FirstName; 
        set
        {
            foreach (char item in value) 
                if (!Char.IsLetter(item))
                    throw new ArgumentException();
            FirstName = value;
        }
    }
    public string SecondName
    {
        get => SecondName;
        set
        {
            foreach (char item in value)
                if (!Char.IsLetter(item))
                    throw new ArgumentException();
            SecondName = value;
        }
    }
    public DateTime date { get; set; }
}
