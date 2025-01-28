# ASP.NET Core MVC in .NET 8
# ASP.NET Core 8 MVC CRUD Application

## Overview

Welcome to the ASP.NET Core 8 MVC CRUD Application! This project is designed to showcase the Model-View-Controller (MVC) architecture while implementing basic Create, Read, Update, and Delete (CRUD) operations. This README will guide you through the MVC framework, its components, and how they interact within this application.

## What is MVC?

MVC is a design pattern that separates an application into three main interconnected components:

1. **Model**: Represents the data and business logic. In this application, the Model is responsible for managing the data related to a specific entity (e.g., `Category`).
   
2. **View**: Represents the user interface. Views are responsible for displaying data to the user and providing means to interact with that data. In this application, views are created using Razor syntax to render HTML.

3. **Controller**: Acts as an intermediary between the Model and View. Controllers handle user input and update the Model or View accordingly. They process incoming requests, retrieve data from the Model, and return the appropriate View.

## Project Structure

```
/Models
    - CategoriesRepository.cs
    - Category.cs

/Views  
    /Categories  
        - Index.cshtml  
        - Add.cshtml  
        - Edit.cshtml  
        - _Category.cshtml
   /Home
       - Index.cshtml
   /Shared
       - _viewImports.cshtml
       - _viewStart.cshtml
/Controllers  
    - CategoriesController.cs  
```

## Getting Started

### Prerequisites

Make sure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. Clone the repository:
   ```bash  
   git clone https://github.com/yourusername/MVCLearningProject.git  
   cd MVCLearningProject  
   ```

2. Restore dependencies:
   ```bash  
   dotnet restore  
   ```

3. Run the application:
   ```bash  
   dotnet run  
   ```

Navigate to `http://localhost:7159/Categories` in your web browser to access the application.

## CRUD Operations

### 1. Create

Users can create a new category by navigating to the "Categories" page. The form captures the category name and description, which are then added to the stub repository.

### 2. Read

The "Categories" page displays a list of all categories stored in the stub repository. Each category entry includes options to edit or delete a category.

### 3. Update

By clicking "Edit" next to a category, users can modify existing category information. Changes are saved and reflected in the list after submission.

### 4. Delete

Users can delete a product by clicking the "Delete" next to a category, which prompts for confirmation. Upon confirmation, the category is removed from the stub repository.

## Conclusion

This ASP.NET Core 8 MVC CRUD application provides a foundational understanding of the MVC architecture and demonstrates how to implement basic CRUD operations. Feel free to customize and expand it as you explore more features of ASP.NET Core!

## License

This project is licensed under the MIT License. See the LICENSE file for details.

## Contributing

If you'd like to contribute, please fork the repository and submit a pull request. Your input is welcome and appreciated!

For questions or feedback, reach out via [email](mailto:gargaruhi9@gmail.com.com).

Happy coding! 🎉
