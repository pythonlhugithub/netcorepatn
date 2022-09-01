namespace Chain.Consoleapp;

internal record ExpenseReport(string name, int amount);
internal interface IManager{
void setSupversor(IManager manager);
void approvereport(ExpenseReport expt);
}
internal class SeniorManager : IManager
{

    IManager manager;
    public void approvereport(ExpenseReport expt)
    {
        if(expt.amount<500)
            Console.WriteLine("approved by manafer");
        else
        manager?.approvereport(expt); //manager not empty, do or ignore
    }

    public void setSupversor(IManager manager)
    {
        this.manager=manager;
    }
}

internal class vicepresident : IManager
{
   IManager manager;
    public void approvereport(ExpenseReport expt)
    {
        if(expt.amount<1000)
            Console.WriteLine("approved by vice president");
        else
        manager?.approvereport(expt); //manager not empty, do or ignore
    }

    public void setSupversor(IManager manager)
    {
        this.manager=manager;
    }
}

internal class COO : IManager
{
   IManager manager;
     public void approvereport(ExpenseReport expt)
    {
        if(expt.amount<5000)
            Console.WriteLine("approved by COO");
        else
        manager?.approvereport(expt); //manager not empty, do or ignore
    }

   public void setSupversor(IManager manager)
    {
        this.manager=manager;
    }
}