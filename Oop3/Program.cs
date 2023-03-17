// See https://aka.ms/new-console-template for more information
using Oop3;


//IhtiyacKrediManager ıhtiyacKrediManager=new IhtiyacKrediManager();
//ıhtiyacKrediManager.Hesapla();

//TasitKrediManager tasitKrediManager= new TasitKrediManager();
//tasitKrediManager.Hesapla();

//KonutKrediManager konutKrediManager= new KonutKrediManager();
//konutKrediManager.Hesapla();

// interfaceyi kullanarak yazalım

//IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
//ıhtiyacKrediManager.Hesapla();

//IKrediManager tasitKrediManager = new TasitKrediManager();
//tasitKrediManager.Hesapla();

//IKrediManager konutKrediManager = new KonutKrediManager();
//konutKrediManager.Hesapla();


// 1 krediyi seçtiğimizde hangisine başvurdugumuzu yazıcak
IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();
 //2 loglama altarnatifim var
ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileloggerService=new FileLoggerService();


BasvuruManager basvuruManager= new BasvuruManager();
basvuruManager.BasvuruYap(konutKrediManager,databaseLoggerService);  //istediğin krediyi yazdırırsın loglanma işleminide yaptırısın

List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager,konutKrediManager}; //yazdırma listeleme 
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);









