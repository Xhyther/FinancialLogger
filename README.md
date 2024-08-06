# Financial Logger

## Overview

**Financial Logger** is a web application designed to help you manage your finances by logging incomes and expenses. This application allows you to perform CRUD operations on your financial records, view the history of your transactions, and maintain a list of desired items to evaluate their affordability based on your current financial status.

## Features

- **Incomes and Expenses Management**: Add, edit, delete, and view details of your incomes and expenses.
- **Transaction History**: View a detailed list of all your past transactions.
- **Wants Section**: Maintain a list of desired items and check their affordability based on your income and expenses.

## Technologies Used

- ASP.NET MVC
- Entity Framework
- SQL Server / PostgreSQL (optional)
- HTML, CSS, JavaScript

## Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/Xhyther/FinancialLogger.git
   cd financial-logger
   ```

2. **Configure the Database**:
   - Update the connection string in `appsettings.json` to point to your SQL Server or PostgreSQL database.

3. **Apply Migrations**:
   ```bash
   dotnet ef database update
   ```

4. **Run the Application**:
   ```bash
   dotnet run
   ```

## Usage

1. **Incomes and Expenses**:
   - Navigate to the "Incomes" or "Expenses" section.
   - Use the form to add new records.
   - Edit or delete existing records from the list.

2. **Transaction History**:
   - Navigate to the "History" section.
   - View all your past incomes and expenses in a consolidated list.

3. **Wants Section**:
   - Navigate to the "Wants" section.
   - Add items you wish to purchase.
   - The application will evaluate your financial records to determine if you can afford the item based on your current incomes and expenses.

## Note !!!IMPORTANT

- The **want section** is still under development and not yet completed.
- The **frontend** design and functionality are also in progress, as the primary focus is currently on backend development.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any improvements or bug fixes.


## Contact

For any questions or suggestions, feel free to open an issue or contact me at [vhontabalan@gmail.com](mailto:your-email@example.com).
