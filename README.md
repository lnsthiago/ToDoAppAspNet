# ToDoAppAspNet

Para rodar o projeto é necessário:

* Abrir a solução para Visual Studio.

* Restaurar os pacotes do NuGet;

* No arquivo `appsettings.json` informar a ConnectionString apontando para o seu banco;

* Abrir a aba `Package Manager Console` (Tools -> Nucget Package Manager) 
  - Setar o projeto `TasksToDo.Infrastructure`
  - e executar o comando: `Update-Database` 
  
  Assim a estrutura do banco será criada
  
 * Rodar o projeto
