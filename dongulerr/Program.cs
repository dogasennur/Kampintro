// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//string kurs1 ="yazılım geliştirici kurs";
//string kurs2 = "programlamaya başlamak için temel kurs";
//string kurs3 = "java kursu ";

//Console.WriteLine(kurs1);
//Console.WriteLine(kurs2);
//Console.WriteLine(kurs3);

//array = yani diziler

string[] kurslar = new string[] { "yazılım geliştirici kurs", "programlamaya başlamak için temel kurs", "java kursu ", "phyton" };


//i sayaç görevinde 10 dan küçükse çalış ++ 1 er arttır dmek
for (int i = 0; i < 4; i++) // yada i+=2 yazarak 2şer artırırım.)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("for bitti");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}


Console.WriteLine("sayfa sonu");

