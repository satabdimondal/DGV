# User Management System - C# Windows Forms Application

This is a simple **User Management System** developed using **C# Windows Forms**. It allows users to **add**, **update**, and **delete** user information such as First Name, Last Name, Phone Number, Address, and Username. The application is designed to provide basic CRUD operations for managing users.

## Features

- **Add User**: Enter details in the input fields (First Name, Last Name, Phone No., Address, and Username) and click **Save** to add the user.
- **Update User**: Select a user, modify the details in the input fields, and click **Update** to save the changes.
- **Delete User**: Select a user from the list and click **Delete** to remove the user from the system.
- The application shows the list of users (displayed in the area at the bottom of the form).

## Project Structure

- **Form Controls**:
  - **TextBox** fields for `First Name`, `Last Name`, `Phone No.`, `Address`, and `Username`.
  - **Buttons**:
    - **Save**: Saves the new user details.
    - **Update**: Updates the selected user's details.
    - **Delete**: Deletes the selected user from the system.
  - **Data Grid / List Area**: Displays the list of users (can be implemented using a `DataGridView` or List).
 
## Gui Layout
![c#-1](https://github.com/user-attachments/assets/6fb3f27a-600a-46ee-9a7f-e35be83f5ceb)

## Database
![Screenshot 2024-09-19 233546](https://github.com/user-attachments/assets/36250f4c-8c25-4ef7-951c-7efc96cf965e)

Table: </br>
CREATE TABLE [dbo].[InfoTable] ( </br>
    [FirstName] VARCHAR (50)  NOT NULL, </br>
    [LastName]  VARCHAR (50)  NOT NULL, </br>
    [UserName]  VARCHAR (50)  NOT NULL, </br>
    [PhoneNo]   INT           NOT NULL, </br>
    [Address]   VARCHAR (100) NOT NULL, </br>
    PRIMARY KEY CLUSTERED ([UserName] ASC) </br>
);

## Requirements

- **IDE**: Visual Studio (2019 or later recommended)
- **.NET Framework**: Ensure that the project targets a compatible version of the .NET Framework (e.g., .NET Framework 4.7.2 or .NET 5.0+).

## Installation

1. Clone or download the repository to your local machine.
2. Open the solution (`.sln`) file in **Visual Studio**.
3. Restore NuGet packages (if necessary).
4. Build the solution to ensure all dependencies are resolved.
5. Run the application using `F5` or `Ctrl + F5`.

## How to Use

1. **Add a User**: 
    - Enter the required user details (First Name, Last Name, Phone No., Address, and Username).
    - Click the **Save** button to store the information.
2. **Update a User**:
    - Select an existing user from the list (to be implemented in the data display area).
    - Modify any details in the text fields.
    - Click **Update** to save the changes.
3. **Delete a User**:
    - Select a user from the list (to be displayed in the bottom section of the form).
    - Click **Delete** to remove the user from the system.

