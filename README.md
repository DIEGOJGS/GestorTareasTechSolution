# 🚀 Gestor de Tareas Prioritarias (TechSolutions S.A.)

Proyecto del curso **Estructura de Datos** (UPN) que simula un sistema de gestión de tickets de soporte técnico, implementado en C# con Windows Forms.

## 📋 Descripción del Problema
La empresa TechSolutions S.A. gestionaba sus tareas de soporte en hojas de cálculo, generando retrasos y pérdida de información. Este proyecto soluciona el problema implementando un sistema de escritorio que gestiona las tareas por orden de llegada.

## 🧠 Estructura de Datos: Cola (Queue)
Se seleccionó la estructura **Cola (Queue)** por su principio **FIFO (First-In, First-Out)**. Esto garantiza que la primera tarea en registrarse sea la primera en atenderse, creando un sistema justo y ordenado.

---

## 📸 Capturas de Pantalla del Sistema

### 1. Interfaz Principal y Carga de Datos
Al iniciar, la app carga 3 tareas de prueba y muestra los contadores en tiempo real.
*(¡Aquí arrastra y suelta tu captura de pantalla de la app principal!)*

### 2. Registro y Validación de Tareas
El sistema permite registrar nuevas tareas y valida que los IDs no estén duplicados.
*(¡Aquí arrastra y suelta tu captura del formulario de registro!)*

### 3. Procesamiento de Tareas (Dequeue)
Al procesar, la tarea más antigua (ID 101) se atiende y pasa al historial.
*(¡Aquí arrastra y suelta tu captura del mensaje "Tarea Procesada"!)*

### 4. Función "Ver Próximo" (Peek)
Permite "espiar" la siguiente tarea sin removerla de la cola.
*(¡Aquí arrastra y suelta tu captura del mensaje "Ver Próximo"!)*

### 5. Lector de README y Exportación
El sistema incluye un lector de `README.txt` que puede exportar la documentación.
*(¡Aquí arrastra y suelta tu captura del "FormReadme" con el texto!)*

---

## 🛠️ Tecnologías Usadas
* **Lenguaje:** C# (.NET 6)
* **Interfaz:** Windows Forms
* **Estructura:** `Queue<T>` (Cola)
* **IDE:** Visual Studio 2022
* **Control de Versiones:** Git y GitHub
