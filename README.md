README - Sistema de Inicio de Sesión y Registro de Datos
Este repositorio contiene un ejercicio de implementación de un sistema de inicio de sesión y registro de datos, desarrollado en un entorno web. El sistema consta de dos pantallas principales: la pantalla de inicio de sesión y la pantalla de datos. A continuación, se detalla el funcionamiento y los requisitos del sistema:

Pantalla de Inicio de Sesión
La pantalla de inicio de sesión permite a los usuarios ingresar al sistema. Aquí están las funcionalidades clave:

Validación de Campos Vacíos: Si tanto el campo de usuario como el de contraseña se encuentran vacíos, el sistema mostrará un mensaje de error indicando que "Usuario no puede encontrarse vacío" o "Contraseña no puede encontrarse vacía".

Validación de Credenciales: Una vez que se ha confirmado que los campos no están vacíos, el sistema consultará una matriz bidimensional de usuarios y contraseñas para verificar las credenciales. Si las credenciales son incorrectas, se mostrará un mensaje que indica "Usuario no se encuentra en el sistema" o "Contraseña incorrecta", según corresponda. Uno de los usuarios predefinidos debe ser "ADMIN" con contraseña "ADMIN".

Redireccionamiento Exitoso: En caso de una validación exitosa, el usuario será redirigido a la pantalla de datos.

Pantalla de Datos
La pantalla de datos muestra información y permite la interacción con los registros. Aquí están las funcionalidades clave:

Visualización de Usuario: En la parte superior de la pantalla, se muestra el nombre de usuario que ha ingresado.

Cerrar Sesión: Se proporciona la opción de "Cerrar Sesión", que solicitará una confirmación antes de redirigir al usuario a la pantalla de inicio de sesión.

Validación de Acceso: Si un usuario intenta acceder directamente a la pantalla de datos sin haber iniciado sesión, se redirigirá automáticamente a la pantalla de inicio de sesión.

Formulario de Registro de Datos: Se presenta un formulario que incluye los siguientes campos obligatorios: Nombres, Apellidos, Fecha de Nacimiento y Correo. Además, se realiza una validación de formato en el campo de correo, asegurando que contenga "@".

Grilla de Datos: Los datos ingresados se muestran en una grilla que incluye los siguientes campos: ID, NOMBRE COMPLETO, FECHA DE NACIMIENTO, EDAD, CORREO y ACCIÓN.

Acciones de Edición y Eliminación: Cada fila de la grilla tiene dos botones de acción: "Editar" y "Eliminar". Al hacer clic en "Editar", se permite editar los registros y actualizar la grilla. Al hacer clic en "Eliminar", se muestra una confirmación antes de eliminar el registro de la grilla.

Persistencia de Datos: Los registros no desaparecerán al recargar la página. Sin embargo, si el usuario cierra sesión, se limpiarán todos los registros para que, al volver a iniciar sesión, la grilla esté vacía.

Limpieza del Formulario: Después de ingresar o editar registros, el formulario se limpia automáticamente para facilitar la entrada de nuevos datos.
