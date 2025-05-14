# 🌾 Farm Produce Manager

A role-based web application built with **ASP.NET Core MVC**, **Entity Framework Core**, and **SQLite**.  
It allows **farmers** to manage their produce and **employees** to track and analyze data via role-specific dashboards.

---

## 📚 Table of Contents

- [🚀 Features](#-features)
- [🛠️ Technologies Used](#️-technologies-used)
- [📦 Getting Started](#-getting-started)
- [🔐 Test Users](#-test-users)
- [🧪 Usage Guide](#-usage-guide)
- [📚 References](#-references)
- [📃 License](#-license)

---

## 🚀 Features

### 👤 Authentication & Roles
- ASP.NET Identity with custom `ApplicationUser`
- Role-based redirection: **Farmer** or **Employee**
- Role dropdown on registration page

### 👨‍🌾 Farmer Portal
- Create and manage a farmer profile
- Add farm produce (name, category, production date)
- View personal product list

### 🧑‍💼 Employee Portal
- View all farmers' products
- Filter products by category and date
- Add new farmer profiles manually

### 🎨 UI & Styling
- Responsive layout using Bootstrap 5
- Themed navbar and pages
- Clean tables, forms, and role-specific navigation

---

## 🛠️ Technologies Used

| Tool                     | Purpose                           |
|--------------------------|-----------------------------------|
| .NET 8 SDK               | Backend framework                 |
| ASP.NET Core MVC         | Web app structure                 |
| Entity Framework Core    | ORM (SQLite database)             |
| ASP.NET Identity         | Authentication & roles            |
| Razor Pages              | Identity UI customization         |
| Bootstrap 5              | Responsive front-end styling      |

---

## 📦 Getting Started

### 🧰 Prerequisites

- Visual Studio 2022 or later
- .NET 8 SDK or later
- No additional database setup needed (uses SQLite)

### ⚙️ Setup Instructions

1. Clone or download the solution folder  
2. Open `FarmProduceManager.sln` in Visual Studio  
3. Open **Package Manager Console** and run:

```bash
Add-Migration InitialCreate
Update-Database
```

4. Press `F5` to build and run the app 🎉

---

## 🔐 Test Users

| Role     | Email              | Password      |
|----------|--------------------|---------------|
| Farmer   | farmer@test.com    | Password123!  |
| Employee | employee@test.com  | Password123!  |

> Seeded via `DataSeeder.cs` when the app runs the first time.

---

## 🧪 Usage Guide

### 🌱 Farmer Flow
- Register or log in as a `Farmer`
- Create your farmer profile
- Add products to your account
- View your personal product dashboard

### 📊 Employee Flow
- Register or log in as an `Employee`
- View all product listings
- Filter by category and production date
- Create new farmer profiles

---

## 📚 References

- Microsoft Docs – [ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-8.0)
- Microsoft Docs – [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- Microsoft Docs – [ASP.NET Core Identity](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity)
- Microsoft Docs – [Razor Pages Identity UI](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity)
- SQLite – [Official Documentation](https://www.sqlite.org/docs.html)
- Bootstrap 5 – [W3Schools Docs](https://www.w3schools.com/bootstrap5/)
- Code Maze – [ASP.NET Core Roles](https://code-maze.com/aspnetcore-identity-user-roles/)
- Dev.to – [Customize Identity in ASP.NET Core](https://dev.to/moe23/customize-identity-in-aspnet-core-37h4)
- Bootswatch – [Themes for Bootstrap](https://bootswatch.com/)
- Visual Studio Tutorials – [Scaffold Identity UI](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-8.0&tabs=visual-studio)

---

## 📃 License

This project is for academic use only.  
If published publicly, you may include the [MIT License](https://opensource.org/licenses/MIT).
