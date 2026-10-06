\# Patient Management System



A C# Windows Forms desktop application developed to manage patients, doctors, and hospital appointments.



\## Features



\* Admin login

\* Patient management

\* Doctor management

\* Appointment booking

\* Appointment status management

\* SQL Server database integration

\* User-friendly Windows Forms interface



\## Technologies Used



\* C#

\* .NET

\* Windows Forms

\* SQL Server

\* Visual Studio



\## Main Modules



\### Login



Provides admin authentication before accessing the system.



\### Patient Management



Allows users to add and view patient information such as name, gender, date of birth, phone number, and address.



\### Doctor Management



Allows users to add and view doctor information including name, specialization, and phone number.



\### Appointment Management



Allows users to book and view appointments by selecting a patient, doctor, appointment date, and appointment status.



\## Database



The application uses Microsoft SQL Server for storing:



\* Admin accounts

\* Patient records

\* Doctor records

\* Appointment records



\## Project Structure



```text

PatientManagementSystem

├── LoginForm.cs

├── DashboardForm.cs

├── PatientForm.cs

├── DoctorForm.cs

├── AppointmentForm.cs

├── Program.cs

├── PatientManagementSystem.csproj

└── PatientManagementSystem.sln

```



\## How to Run



1\. Open `PatientManagementSystem.sln` using Visual Studio.

2\. Make sure SQL Server Express is installed.

3\. Create the required `HospitalDB` database and tables.

4\. Update the database connection string if your SQL Server instance is different.

5\. Build and run the application.



\## Project Type



Desktop application developed as a university project using C# Windows Forms and SQL Server.



