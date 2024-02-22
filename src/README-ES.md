# Arquitectura de la Aplicación

## 🎸 Dominio (Domain)

Esta es la estrella principal del show, el corazón de tu aplicación. Aquí es donde defines la lógica de negocio y las reglas que hacen única a tu aplicación. Piensa en esto como el mensaje o la historia que tu banda quiere contar. Incluye:

- **Entidades**: Objetos con una identidad que se mantiene constante a través del tiempo.
- **Objetos de Valor**: Objetos que no tienen identidad y son inmutables; definen características.
- **Agregados**: Una colección de objetos (entidades y objetos de valor) que se tratan como una unidad para las operaciones de datos.
- **Eventos de Dominio**: Cosas significativas que suceden dentro del dominio.

## 🎤 Aplicación (Application)

Este es el manager de la banda, coordinando todo pero sin llevarse el crédito. Se encarga de la lógica de aplicación que orquesta cómo se utiliza el dominio, definiendo las operaciones de alto nivel que se pueden realizar. Aquí encontrarás:

- **Casos de Uso o Comandos**: Especificaciones de las operaciones de negocio que se pueden ejecutar, basadas en las necesidades de los usuarios.
- **Event Handlers**: Lógica para manejar eventos y orquestar reacciones a ellos.
- **DTOs (Data Transfer Objects)**: Usados para transferir datos entre la capa de aplicación y la de cliente o externos, sin revelar el modelo de dominio interno.

## 🎹 Infraestructura (Infrastructure)

El equipo técnico detrás del escenario, encargado de todo lo que hace posible el espectáculo pero que no se ve directamente en el escenario. Esta capa proporciona soporte técnico a las capas de Aplicación y Dominio, como persistencia de datos, comunicaciones de red, y configuraciones de infraestructura. Incluye:

- **ORMs**: Para mapear tus entidades a una base de datos.
- **Repositorios**: Implementaciones concretas para acceder a la base de datos.
- **Servicios Externos**: Integraciones con servicios de terceros (APIs externas, servicios de mensajería, etc.).
