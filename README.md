# Employees Manager

# Execução aplicação

**Visual Studio**

>> Abrir solução, definir o projeto EmployeesManager.Web como Set as StartUp Project.
>> Alterar ConnectionStrings string no arquivo EmployeesManager.Web/appsettings.json.
>> No console do gerenciador Nuget executar o comando Update-Database no projeto EmployeesManager.Repository.
>> Da start no projeto (F5)

**Terminal**:

>> Alterar ConnectionStrings string no arquivo EmployeesManager.Web/appsettings.json.
>> Alterar ConnectionStrings string no arquivo EmployeesManager.Repository/appsettings.json.
>> Navegar até a pasta do projeto EmployeesManager.Repository e executar o comando dotnet ef database update
>> Navegar até a pasta do projeto EmployeesManager.Web e executar o comando dotnet run.

