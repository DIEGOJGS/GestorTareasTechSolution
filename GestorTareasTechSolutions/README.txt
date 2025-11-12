=========================================
  PROYECTO: Gestor de Tareas Prioritarias
=========================================
Autor: Diego Jose Garcia Saldaña
Curso: Estructura de Datos
Universidad: Universidad Privada del Norte (UPN)

-----------------------------------------
1. JUSTIFICACIÓN DE LA ESTRUCTURA USADA
-----------------------------------------
Para este proyecto, se seleccionó la estructura de datos lineal
COLA (Queue).

El problema describe un sistema de soporte técnico donde las
solicitudes (instalaciones, mantenimiento, etc.) se gestionan
manualmente, generando retrasos. La solución más justa y
eficiente para este escenario es atender las solicitudes en
el orden en que llegan.

La Cola opera bajo el principio FIFO (First-In, First-Out),
lo que garantiza que la primera tarea registrada sea la
primera en ser procesada, eliminando los retrasos arbitrarios
y asegurando un flujo de trabajo ordenado.

SOBRE EL CAMPO "PRIORIDAD":
Aunque el sistema registra la prioridad (Alta, Media, Baja),
esta se utiliza como un campo MERAMENTE INFORMATIVO para el
técnico. La lógica de negocio, basada en la Cola, atiende
las tareas por estricto orden de llegada, sin importar la
prioridad, para garantizar un trato justo a todos los usuarios.

-----------------------------------------
2. GUÍA DE USO
-----------------------------------------

* Pantalla Principal (Datos Cargados):
  (Captura de la app al iniciar)
  Al iniciar, la aplicación carga automáticamente 3 tareas
  de prueba. Se pueden ver los contadores de tareas
  pendientes y atendidas, que se actualizan en tiempo real.

* Registro de Tareas:
  (Captura registrando una tarea)
  El usuario llena los campos ID, Nombre, Prioridad y
  Descripción. Al hacer clic en "Registrar Tarea", esta se
  añade al final de la cola de pendientes. El sistema
  valida que el ID no esté duplicado.

* Procesamiento y Cola:
  (Captura del mensaje "Procesar Tarea")
  Al hacer clic en "Procesar Siguiente Tarea", el sistema
  toma la tarea más antigua (la primera de la lista), la
  remueve de la cola de pendientes y la añade al historial
  de atendidas. Un mensaje muestra el detalle de la
  tarea procesada.

* Función "Ver Próximo" (Peek):
  (Captura del mensaje "Ver Próximo")
  El botón "Ver Próximo" permite "espiar" la siguiente tarea
  en la cola (usando la operación `Peek()`) y muestra sus
  detalles, pero *sin* removerla de la lista de pendientes.

* Lector de README:
  (Captura de la ventana del README)
  El botón "Ayuda / README" abre una ventana secundaria que
  carga y muestra este mismo archivo de texto, permitiendo
  también guardarlo localmente.

-----------------------------------------
3. CONCLUSIONES DEL ESTUDIANTE
-----------------------------------------

1. Se concluye que la elección de la estructura de datos es
   fundamental para resolver un caso real. La Cola (Queue)
   fue la estructura adecuada  ya que su principio
   FIFO (First-In, First-Out)  responde directamente a la
   necesidad de atender las tareas por "orden de llegada",
   solucionando el problema de retrasos y duplicidad
   planteado por TechSolutions S.A..

2. Se aplicaron con éxito los principios de Programación
   Orientada a Objetos (POO) y la programación modular
   requerida. Al separar la lógica de negocio
   (en `GestorTareas.cs`) de la definición de datos
   (en `Tarea.cs`)  y de la interfaz de usuario
   (`Form1.cs`), se obtuvo un código más limpio, escalable
   y fácil de mantener.

3. El sistema implementa correctamente las operaciones
   fundamentales de la estructura, como `Enqueue` (para registrar)
   y `Dequeue` (para procesar), logrando un flujo
   coherente que simula el paso de una tarea desde
   "pendiente"  hasta "historial de atendidas".

4. El uso de una interfaz gráfica en WinForms  y la
   implementación de validaciones (como el control de IDs
   duplicados  y de cola vacía ) permitieron
   crear una aplicación funcional, robusta y fácil de
   usar, demostrando la eficiencia de las
   estructuras de datos lineales.