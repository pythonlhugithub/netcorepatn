using HttpClientFactory;

namespace Chain.Consoleapp;

public class serviceproxy :IDisposable
{

    private HttpClient http;
    private Boolean disposed=false;
    public serviceproxy(IHttpClientFactory _http)
    {
        http=_http.GetHttpClient("");
    }

    ~serviceproxy()
    {
        Dispose(false);  //destructor , finalize done bg gc in dispose, so false here to avoid duplicated. so supres

    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);//
    }

protected virtual void Dispose(bool disposing){   //using virtual can define same name method in here

    if(disposed){
        return;
    }

    if(disposing){
        http.Dispose();//client has dispose method to call,ged object
    }

    //dispose unmanaged object, then

    disposed=true;
}
    public void get(){
       var respons= http.GetAsync("");
    }
    public void post(string pp){

         var respons= http.PostAsync("", null);
    }

    
}