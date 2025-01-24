# ASP.NET Core MVC in .NET 8
# ASP.NET Core 8 MVC CRUD Application

## Overview

Welcome to the ASP.NET Core 8 MVC CRUD Application! This project is designed to showcase the Model-View-Controller (MVC) architecture while implementing basic Create, Read, Update, and Delete (CRUD) operations. This README will guide you through the MVC framework, its components, and how they interact within this application.

## What is MVC?

MVC is a design pattern that separates an application into three main interconnected components:

1. **Model**: Represents the data and business logic. In this application, the Model is responsible for managing the data related to a specific entity (e.g., `Product`).
   
2. **View**: Represents the user interface. Views are responsible for displaying data to the user and providing means to interact with that data. In this application, views are created using Razor syntax to render HTML.

3. **Controller**: Acts as an intermediary between the Model and View. Controllers handle user input and update the Model or View accordingly. They process incoming requests, retrieve data from the Model, and return the appropriate View.

## Project Structure

```
/Models  
    - Product.cs  
/Views  
    /Products  
        - Index.cshtml  
        - Create.cshtml  
        - Edit.cshtml  
        - Details.cshtml  
/Controllers  
    - ProductsController.cs  
/Data  
    - ApplicationDbContext.cs  
```

## Getting Started

### Prerequisites

Make sure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. Clone the repository:
   ```bash  
   git clone https://github.com/yourusername/aspnetcore8-mvc-crud.git  
   cd aspnetcore8-mvc-crud  
   ```

2. Restore dependencies:
   ```bash  
   dotnet restore  
   ```

3. Run the application:
   ```bash  
   dotnet run  
   ```

Navigate to `http://localhost:5000/products` in your web browser to access the application.

## CRUD Operations

### 1. Create

Users can create a new product by navigating to the "Create" page. The form captures the product name and price, which are then added to the database.

### 2. Read

The "Index" page displays a list of all products stored in the database. Each product entry includes options to view details, edit, or delete.

### 3. Update

By clicking "Edit" next to a product, users can modify existing product information. Changes are saved and reflected in the list after submission.

### 4. Delete

Users can delete a product by clicking the "Delete" button, which prompts for confirmation. Upon confirmation, the product is removed from the database.

## Conclusion

This ASP.NET Core 8 MVC CRUD application provides a foundational understanding of the MVC architecture and demonstrates how to implement basic CRUD operations. Feel free to customize and expand it as you explore more features of ASP.NET Core!

## License

This project is licensed under the MIT License. See the LICENSE file for details.

## Contributing

If you'd like to contribute, please fork the repository and submit a pull request. Your input is welcome and appreciated!

For questions or feedback, reach out via [email](mailto:your.email@example.com).

Happy coding! 🎉
