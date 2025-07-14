# Vehicle Leasing Management System (ASP.NET MVC - MySQL)

This is a simple Vehicle Leasing Management System built with **ASP.NET MVC (.NET Framework)** using **Entity Framework Code First** and **MySQL** as the database.

The system allows a company to manage leased vehicles by tracking:
- Which **supplier** provided the vehicle
- Which **branch** the vehicle is assigned to
- Which **client** leased the vehicle
- Which **driver** is responsible for the vehicle

---

## Technologies Used

- ASP.NET MVC (.NET Framework)
- Entity Framework (Code First)
- MySQL Database (via Pomelo.EntityFrameworkCore.MySql)
- Bootstrap (for UI)
- Visual Studio 2022
- LINQ for reporting

---

## Features

- Manage **Suppliers**, **Branches**, **Clients**, **Drivers**, and **Vehicles**
- Create, Read, Update, Delete (CRUD) for all entities
- Dropdown selections for related entities (foreign keys)
- Reports:
  - Allocation of vehicles per supplier, branch, and client
  - Total count of vehicles per group
- Entity Relationship Diagram (ERD) included

---

## Setup Instructions

1. Clone this repository

```bash
git clone (https://github.com/Mandiseli/Vehicle-Lease-App.git)

'``` Nugget Packages

Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Tools
Pomelo.EntityFrameworkCore.MySql
Microsoft.AspNet.Mvc
Microsoft.AspNet.Razor

