using PSP02_LearningMultiThreading.LearningFiles;


Action finalizar = () => { Console.WriteLine("Suscriptor A"); };
finalizar += () => { Console.WriteLine("Suscriptor B"); };

MyThread t1 = new MyThread("x", ref finalizar);
MyThread t2 = new MyThread("y", ref finalizar);

finalizar += () => { Console.WriteLine("Suscriptor C"); };

t1.Start();
t2.Start();