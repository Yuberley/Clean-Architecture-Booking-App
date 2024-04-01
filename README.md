# Arquitectura utilizada

## Iniciando con la Arquitectura utilizada en el proyecto

El proyecto **Bookify** cuenta con una Arquitectura Limpia la cual es un enfoque de diseño de software que se centra en la separación de responsabilidades y la independencia de las capas. La Arquitectura Limpia se basa en el principio de que el código debe ser fácil de entender, fácil de mantener y fácil de cambiar.

![Clean Architecture](https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/media/image5-7.png)
_Imagen tomada de [**Microsoft Docs - eBook, Architect Modern Web Applications with ASP.NET Core and Azure**](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures#clean-architecture)_

### Un vistazo más de cerca a la Arquitectura Limpia

En el mundo de .NET, la Arquitectura Limpia se puede implementar de varias maneras. Una de las formas más comunes es tomar como guía la plantilla de proyecto de ASP.NET Core con la arquitectura de referencia implementada por **Steve Smith** [**@ardalis**](https://ardalis.com/) en su repositorio [**Clean Architecture Solution Template**](https://github.com/ardalis/cleanarchitecture) y promovida por **Microsoft**.

Echando un vistazo más de cerca de la Arquitectura Limpia podemos ver que se organiza la aplicación en cuatro capas:

1. **Dominio**: Contiene las clases que implementan la lógica de negocio central. Esta capa es independiente de cualquier otra capa y no tiene dependencias de otras capas.
  
1. **Aplicación**: Esta capa define los casos de uso y actúa como intermediario entre el Dominio y las capas externas. Esta capa contiene las clases que implementan la lógica de aplicación y las reglas de negocio.

1. **Infraestructura**: sta capa proporciona implementaciones concretas de las interfaces definidas en las capas internas. Puede incluir operaciones relacionadas con bases de datos, sistemas de archivos y otros recursos externos. 

1. **API**: Esta es la capa más externa responsable de presentar la información al usuario y recibir la entrada del usuario. Una regla crítica es que las dependencias deben apuntar hacia adentro, lo que significa que una capa externa puede depender de una capa interna, pero no al revés. Esta estructura hace que la arquitectura sea resistente a los cambios en la tecnología y las dependencias externas.


#### Organizar la solución:

- Dominio (Biblioteca de Clases) 
- Aplicación (Biblioteca de Clases) 
- Infraestructura (Biblioteca de Clases) 
- WebUI (Aplicación Web ASP.NET Core) 

#### Otra perspectiva gráfica de la Arquitectura Limpia:
![Clean Architecture](https://pbs.twimg.com/media/F92a6qvXYAA6i8K?format=png&name=4096x4096)
_Autor de la imagen [**mjovanovictech LinkedIn**](https://www.linkedin.com/in/milan-jovanovic/)_

### Algunos beneficios de la Arquitectura Limpia

- **Facilidad de mantenimiento**: La Arquitectura Limpia facilita la identificación y corrección de errores en el código. Al separar las responsabilidades y las dependencias, es más fácil encontrar y corregir problemas en el código.
- **Facilidad de escalabilidad**: La Arquitectura Limpia facilita la adición de nuevas funcionalidades a la aplicación. Al separar las capas de la aplicación, es más fácil agregar nuevas funcionalidades sin afectar las existentes.
- **Facilidad de pruebas**: La Arquitectura Limpia facilita la escritura de pruebas unitarias y de integración. Al separar las capas de la aplicación, es más fácil probar cada componente de forma aislada.
- **Facilidad de cambio**: La Arquitectura Limpia facilita la adaptación a los cambios en los requisitos de la aplicación. Al separar las capas de la aplicación, es más fácil cambiar una parte de la aplicación sin afectar las demás.

### Lecturas recomendadas

- [**Clean Architecture - Common web application architectures**](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures#clean-architecture) del documento [**Architect Modern Web Applications with ASP.NET Core and Azure**](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/) - Aprende a crear aplicaciones web modernas con ASP.NET Core y Azure.

-  [**Clean Architecture - Robert C. Martin**](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html) - Artículo original de Robert C. Martin sobre la Arquitectura Limpia.