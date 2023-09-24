namespace _03._07;
public class InternationalPassport
{
    public int Id { get; set; }
    public string? FirstName
    {
        get => FirstName; 
        set
        {
            for(int i=0; i<value.Length; i++) 
                if (!Char.IsLetter(value[i]))
                    throw new ArgumentException();
            FirstName = value;
        }
    }
    public string? SecondName
    {
        get => SecondName;
        set
        {
            for (int i = 0; i < value.Length; i++)
                if (!Char.IsLetter(value[i]))
                    throw new ArgumentException();
            SecondName = value;
        }
    }
    public DateTime date { get; set; }
}
