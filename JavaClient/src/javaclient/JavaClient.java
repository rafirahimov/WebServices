

package javaclient;

import java.net.MalformedURLException;
import java.net.URL;
import webservice.IService;
import webservice.Service;


public class JavaClient {

    public static void main(String[] args) throws MalformedURLException {
        URL wsdl = new URL("http://localhost:55277/Service.svc?wsdl");
        Service clientSrv = new Service(wsdl);
        IService iSrv =  clientSrv.getBasicHttpBindingIService();
        System.out.println(iSrv.calculate(23, 56, "+"));
    }
    
}
