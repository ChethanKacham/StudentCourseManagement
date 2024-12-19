# 🎓 Student Course Management System

This project is a Windows application built using C# .NET for managing students, teachers, and courses. The application includes features for logging in, managing student and teacher details, and handling course information.

---

## 📜 Features

- **Admin Login**:  
  - Validates `StudentID` and `Password`.  
  - Displays error messages for missing or incorrect credentials.

- **Student Management**:  
  - Add, update, and view student details.  
  - Displays data in a grid view format.

- **Teacher Management**:  
  - Add, update, and view teacher details.  
  - Displays data in a grid view format.

- **Course Management**:  
  - Add, update, and view course information.  

- **Validation**:  
  - All fields are validated for missing or incorrect data.

---

## 🛠️ Prerequisites

1. **.NET Framework**: Ensure you have the latest version installed.
2. **SQL Server**: Required to host the database.
3. **IDE**: Visual Studio (recommended) for running and modifying the application.

---

## 🚀 Setup and Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/ChethanKacham/StudentCourseManagement.git
   cd StudentCourseManagement
   
2. **Set Up the Database**:
   - Open the database/database.sql file.
   - Execute the script in SQL Server to create the necessary tables (LOGIN, Course, Student, Teacher).
   
3. **Run the Application**:
   - Open the src/ folder in Visual Studio.
   - Build and run the solution.
   - Use the provided login credentials to access the application.

---

## 📌 Purpose
This application was created as part of an assignment for the Advanced Application Programming in C# .NET course. It serves as a prototype for managing academic information.