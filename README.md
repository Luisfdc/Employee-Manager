# Employees Manager

# Execução aplicação

**Visual Studio**

>>**1** Abrir solução, definir o projeto EmployeesManager.Web como Set as StartUp Project.

>>**2** Alterar ConnectionStrings string no arquivo EmployeesManager.Web/appsettings.json.

>>**3** No console do gerenciador Nuget executar o comando Update-Database no projeto EmployeesManager.Repository.

>>**4** Dar start no projeto (F5)

**Terminal**:

>>**1** Alterar ConnectionStrings string no arquivo EmployeesManager.Web/appsettings.json.

>>**2** Alterar ConnectionStrings string no arquivo EmployeesManager.Repository/appsettings.json.

>>**3** Navegar até a pasta do projeto EmployeesManager.Repository e executar o comando dotnet ef database update

>>**4** Navegar até a pasta do projeto EmployeesManager.Web e executar o comando dotnet run.

