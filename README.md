# Computer-Lab-Monitoring-System-with-C#
# 💻 Computer Laboratory Monitoring System

A **C# and MySQL-based** desktop application designed to help computer laboratories monitor and manage their equipment effectively. This system enables users to track inventory items with details like barcode, brand, part, location, and description. It includes features such as reporting, maintenance logging, and user management in a simple, user-friendly interface.

---

## 🚀 Features

- Manage Items (CRUD)
-  Transfer Items
- Under Maintenance Items
- Lost and Damaged Items
-  Manage Parts
-  Manage Computer Sets
-  Manage Brands
-  Manage Locations
-  Manage Users
-  Generate and Print Reports:
  - List of All Items
  - Damaged Items
  - Transferred Items
  - Lost Items
  - Under Maintenance Items
  - Login & Logout System

---

## 🧰 Tech Stack

- **Frontend/Backend**: C# (Windows Forms)
- **Database**: MySQL
- **Reporting Tool**: SAP Crystal Reports

---

## 📦 Requirements

Make sure to install the following before running the system:

- [XAMPP (Latest Version)](https://www.apachefriends.org/index.html)
- [MySQL Connector](https://dev.mysql.com/downloads/connector/net/)
- [MySQL ODBC Driver](https://dev.mysql.com/downloads/connector/odbc/)
- Microsoft Visual Studio 2015 or later (tested with VS 2019 Community)
- [SAP Crystal Reports](https://www.crystalreports.com/)

---

## 🛠️ Installation & Setup

1. **Download or Clone the Repository**
   ```bash
   git clone https://github.com/yourusername/computer-lab-monitoring.git
   ```

   

## 2. Database Setup

Open XAMPP and start the MySQL service.

-💬 Start Apache too if you plan to use phpMyAdmin.

-Visit http://localhost/phpmyadmin in your browser.

-Create a new database named: dbmonitoring

-💬 In phpMyAdmin, click “New” and enter the database name.

-Import dbmonitoring.sql from the root project folder.

-💬 Use the Import tab in phpMyAdmin to upload the SQL file and create the required tables.

   


## 3. Open the Project in Visual Studio

-Open the solution file: ComputerMonitoringSystem.sln

-💬 This file loads the full project in Visual Studio.

-In the Solution Explorer, locate and open SQLConfig.cs.

## 🔐 Admin Login

-Username: admin

-Password: admin

## 📚 Learning Opportunity
This project is ideal for beginners who want to learn:

-C# and MySQL Database Integration

-CRUD Operations (Create, Read, Update, Delete)

- Report Generation using SAP Crystal Reports

- Desktop App Development using WinForms in Visual Studio