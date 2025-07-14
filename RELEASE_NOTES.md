
---

##  `RELEASE_NOTES.md`

```markdown
# Release Notes

## Application: Vehicle Leasing Management System  
## Version: 1.0.0  
## Date: July 2025  
## Author: Mandiseli Mfeya

---

### Overview

The Vehicle Leasing Management System is designed to assist leasing companies in managing vehicle allocations. It provides full CRUD operations for vehicles and their related entities: suppliers, branches, clients, and drivers.

---

### Features Completed

- Vehicle CRUD
- Supplier CRUD
- Branch CRUD
- Client CRUD
- Driver CRUD
- Drop-down relationships between entities
- Index view with grouped vehicle allocation report
- Input validation and model binding
- MVC layout with Bootstrap styling
- ERD file included
- README and Release Notes added

---

### Technical Stack

- ASP.NET MVC (.NET Framework)
- Entity Framework Core (Code First)
- MySQL using Pomelo provider
- Visual Studio 2022

---

### NuGet Packages Used

- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.Tools`
- `Pomelo.EntityFrameworkCore.MySql`
- `Microsoft.AspNet.Mvc`
- `Microsoft.AspNet.Razor`

---

### Known Issues

- No authentication/authorization implemented.
- No client-side validation (only server-side).
- Report page currently static (grouped with LINQ).

---

### Future Enhancements

- Add authentication for admin users
- Include downloadable vehicle reports (PDF or Excel)
- Implement AJAX-based dynamic filtering
- Improve responsive layout for mobile devices

---

### Submission

Submitted to: stefan.becker@rosond.com 
GitHub Link:  https://github.com/Mandiseli/Vehicle-Lease-App.git
