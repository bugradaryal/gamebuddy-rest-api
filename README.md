# gamebuddy-rest-api
.NET Core Api for react app.

## METHODS

<table>
    <tr>
      <th>DESCRIPTION</th>
      <th>PATH</th>
      <th>METHOD</th>
      <th>FOR</th>
    </tr>
    <tr align="center">
      <td>Testing all data</td>
      <td><b>http://localhost:61256/api/DbTest/{id}</b></td>
      <td>Get</td>
      <td>Test</td>
    </tr>
    <tr align="center">
        <td>Gets all users data</td>
        <td><b>http://localhost:61256/api/User/GetAllUser</b></td>
        <td>Get</td>
        <td rowspan=6 >User's data<br> (called User)</td>
    </tr>
    <tr align="center">
        <td>Gets user's data by id</td>
        <td><b>http://localhost:61256/api/User/GetUserById/{id}</b></td>
        <td>Get</td>
    </tr>
    <tr align="center">
        <td>Gets user's data by password and e-mail <br> (a password and e-mail must be send)</td>
        <td><b>http://localhost:61256/api/User/GetUser</b></td>
        <td>Get</td>
    </tr>
    <tr align="center">
        <td>Creates new user <br> (user information must be send)</td>
        <td><b>http://localhost:61256/api/User/CreateUser</b></td>
        <td>Post</td>
    </tr>
    <tr align="center">
        <td>Updates the user's data <br> (user's new values must be send)</td>
        <td><b>http://localhost:61256/api/User/UpdateUser</b></td>
        <td>Put</td>
    </tr>
    <tr align="center">
        <td>Deletes the user by id</td>
        <td><b>http://localhost:61256/api/User/DeleteUser/{id}</b></td>
        <td>Delete</td>
    </tr>
    <tr align="center">
        <td>Gets all user's selected games by user id</td>
        <td><b>http://localhost:61256/api/My_Game/GetUsersAllGame/{id}</b></td>
        <td>Get</td>
        <td rowspan=3 >The user's selected games data<br> (called My_Game)</td>
    </tr>
    <tr align="center">
        <td>Removes the user's selected game</td>
        <td><b>http://localhost:61256/api/My_Game/DeleteUsersGames/{id}</b></td>
        <td>Delete</td>
    </tr>
    <tr align="center">
        <td>Adds game to user's game list if game exist<br> (the user's id and game's id are required)</td>
        <td><b>http://localhost:61256/api/My_Game/AddUsersGame</b></td>
        <td>Post</td>
    </tr>
    <tr align="center">
        <td>Gets all games data</td>
        <td><b>http://localhost:61256/api/AllGame/GetAllGames</b></td>
        <td>Get</td>
        <td rowspan=4>All added games data<br> (called AllGame)</td>
    </tr>
    <tr align="center">
        <td>Gets game's data by game id</td>
        <td><b>http://localhost:61256/api/AllGame/GetGameById/{id}</b></td>
        <td>Get</td>
    </tr>
    <tr align="center">
        <td>Deletes game's data by game id</td>
        <td><b>http://localhost:61256/api/AllGame/DeleteGame/{id}</b></td>
        <td>Delete</td>
    </tr>
    <tr align="center">
        <td>Creates new game<br> (game name must be send)</td>
        <td><b>http://localhost:61256/api/AllGame/AddGame</b></td>
        <td>Post</td>
    </tr>
  </table>
  
## Connection String
  
You should change the connection string in "~/game buddy-rest-api/DataAccess/DataDbContext" before starting.

```csharp
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //Database connection string - connection bağlantısı
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress; Database=GameBuddy; Trusted_Connection=True; MultipleActiveResultSets=true;");
        }
```

