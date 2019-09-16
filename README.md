# SimpleGreetingWCFServiceLibrary&Host&ClientDemo

WCF Simple Greeting Service Library & Service Host Console Application Supporting Http and TCP Protocols & Client “Tester" Console Application 

Project Blog Article here: 
https://portfolio.katiegirl.net/2019/04/20/wcf-simple-greeting-service-library-service-host-console-application-supporting-http-and-tcp-protocols-client-tester-console-application/


About

This project presents a simple WCF Greeting Service that demos architectural styles of setting up, hosting, configuring services, and testing for dual protocols: http and tcp. The service accepts a simple string, which represents a name, and returns a simple string with a greeting that acknowledges the name.  Instead of using IIS Express, the simple greeting service is hosted using a console application. The Visual Studio solution also has two client “tester” applications that test both the http and tcp protocol connections to the hosted service. 


Architecture

The demo project consists of these component topics:


•	SimpleGreeting Service Library
o	ISimpleGreetingService (Interface for Service)
o	SimpleGreetingService (Code that Implements the Service Interface)


•	ServiceHostApplication “Service Host” Console Application
o	Hosts the SimpleGreeting Service
o	Started/Stopped Using Console Window Interface


•	HttpClient “Tester to Service” Console Application
o	Connected Service “Proxy Reference” SimpleGreetingServiceReference
o	Simple Program to test the service @ http endpoint


•	TcpClient “Tester to Service” Console Application
o	Connected Service “Proxy Reference” SimpleGreetingServiceReference
o	Simple Program to test the service @ tcp endpoint

