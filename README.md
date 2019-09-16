# MyWindowsServiceDemo

Positive Affirmations WCF Service Library & Windows Services Hosting & Client “Tester" Windows Form Application 

Project Blog Article here: 
https://portfolio.katiegirl.net/2019/09/16/positive-affirmations-wcf-service-library-windows-services-hosting-client-tester-windows-form-application/


About

This project presents a simple WCF Positive Affirmations Service that demos architectural styles of setting up, hosting via a Windows Service, configuring services, and testing for tcp protocols. The service accepts a simple string, which represents a name, and returns a simple string with a randomized positive affirmation that acknowledges the name.  Instead of using IIS Express, the simple service is hosted using Windows Services. The Visual Studio solution also has one client “tester” Windows Form application that tests the tcp protocol connection to the hosted service.


Architecture


The demo project consists of these component topics:

•	MyAffirmationServiceLib Service Library
	o	IAffirmationService (Interface for Service)
	o	AffirmationService (Code that Implements the Service Interface)

•	PositiveAffirmationsHost “Service Host” Windows Service Application
	o	Hosts the Service
	o	Installer Included and Configured
	o	Started/Stopped Using Windows Services

•	TestClientGUI “Tester to Service” Windows Form Application
	o	Connected Service “Proxy Reference” 
	o	Simple Program to test the service @ tcp endpoint


