# Dating App using ASP.NET Core and Angular
***********
### 1. User can a create account.
### 2. Like other user.
### 3. Message other user.
### 4. Upload Photos.
### 5. See who is online.

# How to use

### 1. Clone the repo or download as zip.
### 2. Install Dotnet(8.0) and Angular(16).
### 3. Go to the "API" directory and open the terminal
### 4. Run
    - dotnet build
### 5. If you have docker installed run the following command to install postgres container
        - docker run --name postgres -e POSTGRES_PASSWORD=159753 -p 5432:5432 -d postgres:latest
### if don't have docker then go to "appsettings.Development.json" on the API folder and find "DefaultConnection" change it to "DefaultConnection": "Data source=datingapp.db". It will create a SQLite database. Then go to ApplicationServiceExtensions.cs file on Extensions folder and find
#### "opt.UseNpgsql(config.GetConnectionString("DefaultConnection"));" replace this line with "opt.UseSqlite(config.GetConnectionString("DefaultConnection"));" this.

### 6. Run from the api folder
    - dotnet run

### 7. If you change anything on the angular make sure to npm install from the client folder then run ng build
    - npm install
    - ng build
