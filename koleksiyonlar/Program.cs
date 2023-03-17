// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//string[] isimler = new string[] { "engin", "murat", "halil", "kerem" };
//Console.WriteLine(isimler[0]);
//Console.WriteLine(isimler[1]);
//Console.WriteLine(isimler[2]);
//Console.WriteLine(isimler[3]);

//isimler = new string[5];

//isimler[4] = "ilker";
//Console.WriteLine(isimler[4]);
// arrayler sabit tutar bu yüzden stack ve heap bölgelerinde isimleri yeni atama yaptıgımız için ilk 4 elemanı boş son elemanı ilker olarak gönderecektir.

List<string> isimler2 = new List<string> { "engin", "murat", "halil", "kerem" };

Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);
isimler2.Add("ilker");

Console.WriteLine(isimler2[4]);
Console.WriteLine(isimler2[0]);

// kolleksiyonlardaki listeleme yöntemi ile tutulan veri genişletilebilir yada darlatılabilir. diğer elemanlarıda tutmaya dewam eder.