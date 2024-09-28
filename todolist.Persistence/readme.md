## How to create new migration with EF CLI
step 1: install EF Core CLI tools.

step 2: cd to the root folder.

step 3: run this command <code>dotnet ef migrations add <migration_snapshot_title> -s ./TodoList -p ./TodoList.Persistence</code>

step 4: apply the migration <code>dotnet ef database  update -p .\TodoList</code>