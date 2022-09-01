using Chain.Consoleapp;
var maanger=new  SeniorManager();
var vp=new vicepresident();

var coo=new COO();
maanger.setSupversor(vp);
vp.setSupversor(coo);

var expnse=new ExpenseReport("monica", 499);
Console.Write(expnse);
maanger.approvereport(expnse);

 expnse=new ExpenseReport("monica", 999);
Console.Write(expnse);
maanger.approvereport(expnse);

 expnse=new ExpenseReport("monica", 46999);
Console.Write(expnse);
maanger.approvereport(expnse);

//chain responcibility pattern

// var sp=new serviceproxy(null);

// sp.get();
// sp.post("");

using var sp=new serviceproxy(null);

 sp.get();
  sp.post("");