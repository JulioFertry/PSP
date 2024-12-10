namespace PSP02_01hilos.Participant;

public class Participant
{
    
    private List<string> _options = new List<string>{"rock", "paper", "scissors"};


    private string GetRandomOption()
    {
        Random random = new Random();
        int index = random.Next(_options.Count);
        return _options[index];
    }
    
}