### NORTHWINDINVENTORYAPI
Overview
The NORTHWINDINVENTORYAPI is a RESTful API designed to manage the Northwind Traders database, an example database representing a small-scale wholesale company. This API facilitates interactions with product and supplier data, offering a comprehensive platform for accessing and manipulating inventory data, thereby supporting efficient inventory management and operations within enterprise applications.

### System Design
Architecture
This API adopts a layered architecture to separate concerns, enhance maintainability, and facilitate scalability:

1. Data Access Layer: Utilizes Entity Framework Core to interact with the SQLite database, abstracting database operations and ensuring data integrity.
2. Business Logic Layer: Embedded within the controller actions, this layer handles business rules and data validation.
3. Presentation Layer: Exposed through a set of HTTP endpoints that allow for CRUD operations on products and suppliers.

### Database Schema
The system interacts with two main entities:

Products: Represents the items available in the inventory, including details such as product name, supplier ID, category, unit price, units in stock, and more.
Suppliers: Stores information about the suppliers providing the products, such as company name, contact information, and address.

### API Endpoints
The API provides the following endpoints for managing inventory:

GET /api/products: Retrieves a list of all products.
GET /api/products/{id}: Retrieves a specific product by ID.
POST /api/products: Creates a new product.
PUT /api/products/{id}: Updates an existing product.
DELETE /api/products/{id}: Deletes a product.
For suppliers:

GET /api/suppliers: Retrieves a list of all suppliers.
GET /api/suppliers/{id}: Retrieves a specific supplier by ID.
POST /api/suppliers: Creates a new supplier.
PUT /api/suppliers/{id}: Updates an existing supplier.
DELETE /api/suppliers/{id}: Deletes a supplier.

### Technologies Used
ASP.NET Core: Serves as the framework for building the API.
Entity Framework Core: Used for ORM to interact with the SQLite database.
SQLite: Acts as the backend database.
Swagger (Swashbuckle): Provides API documentation and testing capabilities through an interactive UI.

