# Ticket system architecture

The system revolves around a SQL database, and multiple ASP.NET Core projects, to stimulate a simple ticket system base. 
There's one REST API project, another REST API client project, a database-repository project containing models & database query methods and lastly two MVC projects. One of the MVC projects being the backoffice/admin panel and the other one being the client webshop. 
All these components communicate with each other through the REST API.

# Context diagram

<img src="images/context.png" />

# Container diagram

<img src="images/container.png" />

# Database

<img src="images/database_diagram.png" />