# GovtPath: Job Advertisement and Management System

GovtPath is a web-based job advertisement and management system built using ASP.NET Core MVC and MS SQL Server. This application is designed to streamline the process of job listing, admit cards, and results management for government job recruitment. It features an intuitive admin panel that allows administrators to easily manage job postings and related activities.

## Features

- **Admin Panel**: A comprehensive interface for administrators to manage jobs, admit cards, and results.
- **Job Listings**: Admins can create, edit, and delete job advertisements.
- **Admit Cards**: Functionality for generating and managing admit cards for candidates.
- **Results Management**: Admins can publish and manage results for various job positions.
- **User-Friendly Interface**: Easy navigation for both admins and users.

## Technologies Used

- **Backend**: ASP.NET Core MVC
- **Database**: Microsoft SQL Server
- **Frontend**: HTML, CSS, JavaScript

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version compatible with ASP.NET Core)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- A suitable code editor (e.g., Visual Studio, Visual Studio Code)

### Installation

1. **Clone the Repository**:

   ```bash
   git clone https://github.com/AccessAuthority/GJAMS.git
   cd GJAMS
   ```

2. **Setup the Database**:
   - Create a new database in SQL Server.
   - Update the connection string in `appsettings.json` to match your database configuration.

3. **Run Migrations**:
   - Open a terminal in the project directory and run:

   ```bash
   dotnet ef database update
   ```

4. **Start the Application**:
   - Run the application using:

   ```bash
   dotnet run
   ```

   Navigate to `http://localhost:5000` in your web browser to access the application.

## Usage

1. Log in to the admin panel using the credentials provided in the setup.
2. Use the dashboard to manage job listings, admit cards, and results.
3. Follow the on-screen instructions for each functionality.

## Contributing

Contributions are welcome! If you'd like to contribute, please fork the repository and submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgements

- Thanks to the ASP.NET Core and Microsoft SQL Server communities for their extensive documentation and support.
- Inspiration drawn from various open-source projects in the job management domain.

---

Feel free to reach out with questions, feedback, or suggestions!
