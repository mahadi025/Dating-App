
# Dating App using ASP.NET Core and Angular
***********
### 1. User can a create account.
### 2. Like other user.
### 3. Message other user.
### 4. Upload Photo.
### 5. See who is online.

# How to use

### 1. Clone the repo or download as zip.
### 2. Install Dotnet(8.0) and Angular(16)
### 3. Go to the directory and open the terminal. Then cd into "API"
### 4. Run
    - dotnet build
### 5. If you have docker installed run the following command to install postgres container
        - docker run --name postgres -e POSTGRES_PASSWORD=159753 -p 5432:5432 -d postgres:latest
### if don't have docker then go to "appsettings.Development.json" on the API folder and find "DefaultConnection" change it to "DefaultConnection": "Data source=datingapp.db". It will create a SQLite database.

### 6. Run from the api folder
    - dotnet run

### 7. If you change anything on the angular make sure to npm install from the client folder then run ng build
    - npm install
    - ng build

