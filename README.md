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
![pantalla principal](https://github.com/user-attachments/assets/3579e87e-4262-45cc-81aa-988ab0093c13)


### 2. Registro y Validación de Tareas
El sistema permite registrar nuevas tareas y valida que los IDs no estén duplicados.
![Registro de validacion](https://github.com/user-attachments/assets/cc5dbe69-fc4f-4ed2-98f3-6a265f1e0e48)


### 3. Procesamiento de Tareas (Dequeue)
Al procesar, la tarea más antigua (ID 101) se atiende y pasa al historial.
![tarea procesada](https://github.com/user-attachments/assets/957935e5-09fe-48fe-aeae-ac07f58dc982)

### 4. Función "Ver Próximo" (Peek)
Permite "espiar" la siguiente tarea sin removerla de la cola.
![proxima](https://github.com/user-attachments/assets/929cf0e8-2ee9-4c50-abf1-1827a5f89637)

### 5. Lector de README y Exportación
El sistema incluye un lector de `README.txt` que puede exportar la documentación.
![lector](https://github.com/user-attachments/assets/ae67f7ff-3283-4749-8f7c-6f2d6b87d6e8)

---

## 🛠️ Tecnologías Usadas
* **Lenguaje:** C# (.NET 6)
* **Interfaz:** Windows Forms
* **Estructura:** `Queue<T>` (Cola)
* **IDE:** Visual Studio 2022
* **Control de Versiones:** Git y GitHub
