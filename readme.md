# Google forms Desktop Application

This repository contains a Windows Forms application for managing form submissions. The application allows you to create, view, delete, and edit submissions. It also includes a feature to search submissions by email.

## Features

- Create submissions
- View submissions
- Delete submissions
- Edit submissions
- Search submissions by email
- Toggle stopwatch timer in submission forms
- Better design on frontend
- Keyboard control functionality

## Getting Started

### Prerequisites

- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) (version compatible with Windows Forms)
- [Visual Studio](https://visualstudio.microsoft.com/) (or any other compatible IDE)
- [Node.js](https://nodejs.org/) + Express.js (for running the backend server)

### Running the Backend Server

1. Clone the repository:
    ```sh
    git clone https://github.com/grow-xd/googleformsbackend.git
    cd googleformsbackend
    ```

2. Navigate to the server directory:
    ```sh
    npm install
    ```

3. Install dependencies:
    ```sh
    npm run dev
    ```

The server will start on `http://localhost:3000`.

### Running the Windows Forms Application

1. Open the solution file `Slidelyapp.sln` in Visual Studio.

2. Build the solution:
    - In Visual Studio, go to `Build > Build Solution`.

3. Run the application:
    - Press `F5` or go to `Debug > Start Debugging`.

## API Endpoints

### View Submissions

- **GET** `http://localhost:3000/read?index={index}`
  - Retrieves the submission at the specified index.

### Create Submission

- **POST** `http://localhost:3000/submit`
  - Create the new submission at the last index.

### Delete Submission

- **DELETE** `http://localhost:3000/delete?index={index}`
  - Deletes the submission at the specified index.

### Edit Submission

- **PUT** `http://localhost:3000/edit?index={index}`
  - Updates the submission at the specified index.
  - Requires a JSON body with the updated fields.

### Search Submissions by Email

- **GET** `http://localhost:3000/submissions/group?email={emailsearch}`
  - Retrieves submissions matching the specified email.

## Windows Forms Application

### MainForm

- **Create Submission**: Opens a form to create a new submission with a stopwatch timer.
- **View Submissions**: Opens a form to view, edit, and delete submissions.
- **Search by Email**: Opens a form to search for submissions by email.
  ![image](https://github.com/grow-xd/formsdesktopapp/assets/80830946/898b3ac4-efe4-49a3-bd18-b024c0fc9f05)


### ViewSubmissionsForm

- **Previous (CTRL + P)**: View the previous submission.
- **Next (CTRL + N)**: View the next submission.
- **Delete (CTRL + DEL)**: Delete the current submission.
- **Edit (CTRL + E)**: Edit the current submission.
- All these are Non editable read only fields.
  
  ![image](https://github.com/grow-xd/formsdesktopapp/assets/80830946/547d3ef9-e8e2-48ea-b818-f742e7f1449c)

### CreateNewSubmissionForm

- **Submit (CTRL + S)**: Create a new submission.
  
  ![image](https://github.com/grow-xd/formsdesktopapp/assets/80830946/f09443b5-09fe-4ab7-b8c8-f68d86e249b7)


### EditSubmissionForm

- Fields to edit the submission details.
- Toggle stopwatch timer.
  
  ![image](https://github.com/grow-xd/formsdesktopapp/assets/80830946/32bde84b-d961-4a6e-810a-aa596efbcfcf)

### SearchByEmailForm

- Input field to enter an email search query.
- Button to fetch submissions matching the email.
  
  ![image](https://github.com/grow-xd/formsdesktopapp/assets/80830946/9822ba0c-ee24-423a-b904-f2d1cddaa2f4)

## Code Structure

- **Forms**: Contains Windows Forms for creating, viewing, editing, and searching submissions.



