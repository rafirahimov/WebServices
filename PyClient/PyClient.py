from zeep import Client
client = Client('http://localhost:55277/Service.svc?wsdl')
print client.service.Calculate(90,45,"/")