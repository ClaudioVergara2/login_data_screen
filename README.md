# Sistema de Inicio de Sesión y Registro de Datos

Este repositorio contiene una aplicación web que implementa un sistema de inicio de sesión y un formulario de registro de datos. El sistema consta de dos pantallas principales: la pantalla de inicio de sesión y la pantalla de datos.

## Pantalla de Inicio de Sesión

- Si los campos de usuario y contraseña están vacíos, se mostrará un mensaje de error indicando que "Usuario no puede encontrarse vacío" o "Contraseña no puede encontrarse vacía".

- Una vez validados los campos, se verificará si el usuario y la contraseña son correctos utilizando una matriz bidimensional de usuarios y contraseñas. Si las credenciales son incorrectas, se mostrará un mensaje que indica "Usuario no se encuentra en el sistema" o "Contraseña incorrecta". Uno de los usuarios predefinidos es "ADMIN" con la contraseña "ADMIN".

- En caso de una validación exitosa, el usuario será redirigido a la pantalla de datos.

## Pantalla de Datos

- En la parte superior de la pantalla, se muestra el nombre de usuario que ha iniciado sesión.

- Se proporciona la opción "Cerrar Sesión", que solicitará una confirmación antes de redirigir al usuario a la pantalla de inicio de sesión.

- Si un usuario intenta acceder directamente a la pantalla de datos sin haber iniciado sesión, se redirigirá automáticamente a la pantalla de inicio de sesión.

- El formulario de registro de datos incluye campos obligatorios: Nombres, Apellidos, Fecha de Nacimiento y Correo. Se realiza una validación de formato en el campo de correo para asegurarse de que contenga "@".

- Los datos ingresados se muestran en una grilla que incluye los campos: ID, NOMBRE COMPLETO, FECHA DE NACIMIENTO, EDAD, CORREO y ACCIÓN.

- Cada fila de la grilla tiene dos botones de acción: "Editar" y "Eliminar". Al hacer clic en "Editar", se permite editar los registros y actualizar la grilla. Al hacer clic en "Eliminar", se muestra una confirmación antes de eliminar el registro de la grilla.

- Los registros no desaparecerán al recargar la página. Sin embargo, si el usuario cierra sesión, se limpiarán todos los registros para que, al volver a iniciar sesión, la grilla esté vacía.

- Después de ingresar o editar registros, el formulario se limpia automáticamente para facilitar la entrada de nuevos datos.

## Vistas

![Vista](https://github.com/ClaudioVergara2/login_data_screen/blob/main/VistaLogin.jpg)

![Vista](https://github.com/ClaudioVergara2/login_data_screen/blob/main/VistaDataScreen.jpg)
