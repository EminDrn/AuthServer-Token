# AuthServer

This is a sample .NET Core API project showcasing JWT token authentication, caching, and Redis integration. It is developed as a minimalistic project focused on product-related functionalities.

## Installation

### Clone the Repository

Clone the project to your local machine using the following command in the terminal or command prompt:

```sh
git clone https://github.com/user/AuthServer.git

```
### Configure the Database  
Make sure that SqlServer is running and accessible. Then, update the SQL connection details in the appsettings.json file:  
```sh
{
  "ConnectionStrings": {
    "SqlServer": "your-sql-server-connection-string"
  },
  ...
}
```
## Usage  
### Obtain JWT Token
Authenticate and obtain a JWT token by making a POST request to the /api/auth/createtoken endpoint with valid credentials.  
### Access Product Data  
Use the obtained JWT token to access product data by including it in the Authorization header of your requests:  
Get All Products
```sh
GET /api/products
Authorization: Bearer your-jwt-token
```


