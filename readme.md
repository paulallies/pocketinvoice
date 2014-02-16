Go from client to client and invoice on the go.
This basic application is a mobile application built for the following platforms:

1. Windows Phone 8
* Android
* IOS

The purpose of the application is to illustrate the process of developing a single
application for multiple mobile platforms.

The application has the following pieces of functionality:

1. List of Invoices
2. List of Clients

The Client details will include the following:

1. Id int(automatically generated) 
* Name string (mandatory)
* Contact string
* Email string
* Telephone string
* Cell Number string 
* Billing Address string
* Shipping Address string

The invoice will contain the following:

1. Id int(automatically generated)
* Invoice Date Date
* Due Date Date
* clientid int(ref to client collection)
* Payment Term Enum [immediate, ]
* Collection of Invoice lines
	[{
		Qty int,
		Description string,
		Rate decimal,
		Amount decimal (determined)
	}]




 
