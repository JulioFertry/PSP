string finished = "";
bool foundOut = false;

Thread t1 = new Thread(WriteY); // Kick off a new thread
Thread t2 = new Thread(WriteX); // Kick off a new thread
t1.Start(); // running WriteY()
t2.Start(); // running WriteX()

while (finished.Length == 0)
{
    
}

Console.WriteLine();
foundOut = true;
Console.WriteLine($"\nHa ganado {finished}");

void WriteY()
{
    WriteText("Y");
}

void WriteX()
{
    WriteText("X");
}

void WriteText(string text)
{
    for (int i = 0; i < 1000 && finished == ""; i++) Console.Write(text);
    if (finished == "") finished = text;
    while (!foundOut)
    {
        Console.Write(text);
    }
}