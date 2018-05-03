## DI ASP Net Core - 2.	Microsoft.DependencyInjection

Ejemplo sencillo de Dependency Injection con ASP net Core, utilizando el contenedor de injeccion dependencias que viene integrado
en el ASP NET Core.

### Introducci�n

Creamos una capa Business Logic donde teneemos una interface que emula el acceso a la capa repository para poder obtener una lista
de students y poder visualizarlo en la vista.
En este caso para ver el funcionamiento solo accedemos a la vist Index.

Las dependencias se registran y resuelven en la clase "Startup.cs".

En el momento del registro, las dependencias requieren una definici�n de por vida. 
La vida �til del servicio define las condiciones bajo las cuales se crear� una nueva instancia de servicio. 
A continuaci�n est�n las vidas definidas por el marco DI de ASP.Net. La terminolog�a puede ser diferente si elige usar un marco diferente.

* Transient : creado cada vez que se solicitan.
* Scoped : Creado una vez por alcance. La mayor�a de las veces, el alcance se refiere a una solicitud web. 
* Singleton : Creado solo para la primera solicitud. 

### Recursos utilizados 

* https://docs.microsoft.com/es-es/aspnet/core/fundamentals/dependency-injection
* https://joonasw.net/view/aspnet-core-di-deep-dive
* https://stackify.com/net-core-dependency-injection/
