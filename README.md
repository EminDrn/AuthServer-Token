# AuthServer

This is a sample API project developed with .NET Core, featuring JWT token authentication, caching, and Redis integration. The project serves as a mini MovieApp to showcase these functionalities.
Setup
Clone The Repository
Configure Database:
Ensure that SqlServer is running and accessible. Update the SQL connection details in the appsettings.json file:
"SqlServer" :"your sql server connection string"
Usage
Obtain JWT Token:
Authenticate and obtain a JWT token by making a POST request to /api/auth/createtoken with valid credentials.
Access Product Data: Use the obtained JWT token to access movie data by including it in the Authorization header of your requests:
GET /api/products
Authorization: Bearer your-jwt-token  
