# magero-store

## Overview
magero-store is a sample e-commerce application built using .NET Core MVC. The application simulates a shopping experience similar to popular e-commerce platforms, allowing users to browse products, add items to their cart, and complete purchases.

## Features
- **Home Page**: Displays featured products and navigation options.
- **Product Listing**: Users can view all available products and filter through them.
- **Product Details**: Detailed view of each product, including descriptions and images.
- **Shopping Cart**: Users can view items added to their cart and adjust quantities.
- **Checkout Process**: A streamlined process for users to finalize their purchases.

## Project Structure
```
magero-store
├── Controllers
│   ├── HomeController.cs
│   ├── ProductsController.cs
│   ├── CartController.cs
├── Models
│   ├── Product.cs
│   ├── CartItem.cs
│   └── ApplicationDbContext.cs
├── Views
│   ├── Home
│   │   └── Index.cshtml
│   ├── Products
│   │   ├── Index.cshtml
│   │   ├── Details.cshtml
│   ├── Cart
│   │   ├── Index.cshtml
│   │   ├── Checkout.cshtml
│   └── Shared
│       ├── _Layout.cshtml
│       └── _ViewImports.cshtml
├── wwwroot
│   ├── css
│   │   └── site.css
│   ├── js
│   │   └── site.js
│   └── lib
├── appsettings.json
├── Program.cs
├── Startup.cs
└── README.md
```

## Getting Started
1. **Clone the Repository**: 
   ```
   git clone <repository-url>
   cd magero-store
   ```

2. **Install Dependencies**: 
   Ensure you have the .NET Core SDK installed. Run the following command to restore dependencies:
   ```
   dotnet restore
   ```

3. **Run the Application**: 
   Start the application using:
   ```
   dotnet run
   ```
   Navigate to `http://localhost:5000` in your web browser to view the application.

## Contributing
Contributions are welcome! Please feel free to submit a pull request or open an issue for any enhancements or bug fixes.

## License
This project is licensed under the MIT License - see the LICENSE file for details.