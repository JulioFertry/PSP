namespace PSP02_LearningMultiThreading.LearningFiles;


public class MyThread
{
    Thread _thread;
    private string text;
    private Action finalAction;
    
    public MyThread(string text, ref Action finalAction)
    {
        this.text = text;
        finalAction += () => { Console.WriteLine($"Hilo {text}"); };
        this.finalAction = finalAction;
        _thread = new Thread(_process);
    }

    public void Start()
    {
        _thread.Start();
    }

    void _process()
    {
        for (int i = 0; i < 1000; i++) Console.Write (text);
        finalAction?.Invoke();
        Console.WriteLine($"Ha terminado: {text}");
    }
}