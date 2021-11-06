# moviesApi
An API for movies, you can search a movies for movie title, genre and actor name.

## Installation
1. After you clone this repo, you need to go to the file `appsettings.Development.json` and write your right sql server in the connection string, just the server.
2. Run `dotnet restore` to install all the needed packages
3. Run `dotnet ef database update` for run all migrations, this command creates the database, tables and populate the tables


### Notes
- This API just allow localhost cors with the port 3000


