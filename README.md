# Proyecto de estructura de datos

Este proyecto es una aplicación de escritorio en C# utilizando Windows Forms para gestionar la inscripción de participantes en actividades artísticas. Permite registrar datos de los participantes, calcular el costo total de las clases según la técnica seleccionada y generar un informe detallado.

## 📌 Características
- **Validación de Acceso:** Se requiere una clave para ingresar al sistema.
- **Gestión de Inscripción:** Permite ingresar datos personales y seleccionar una técnica artística.
- **Cálculo Automático:** Calcula el costo total de las clases en función de la cantidad de clases y la técnica seleccionada.
- **Generación de Reporte:** Muestra un resumen detallado de la inscripción en una ventana emergente.
- **Interfaz Intuitiva:** Basado en formularios de Windows Forms con validaciones y mensajes de error.

## 📂 Estructura del Código

### 1️⃣ **Form1.cs**
- Valida la clave de acceso antes de permitir el ingreso al sistema.
- Si la clave es correcta, abre el formulario principal de inscripción.

### 2️⃣ **valores.cs** (Formulario Principal)
- Permite la selección de técnica artística y la entrada de datos personales.
- Realiza validaciones para asegurar que los datos ingresados sean correctos.
- Calcula el costo total de las clases.
- Guarda los datos ingresados.

### 3️⃣ **GestionParticipantes.cs** (Lógica de Negocio)
- Contiene el método `CalcularCostoTotal(int numClases, int costoClase)`, que multiplica la cantidad de clases por el costo unitario.
- Método `GuardarRegistro(...)` para almacenar la información del participante.

### 4️⃣ **Reporte.cs** (Resumen de Inscripción)
- Muestra los datos ingresados y el costo total en un nuevo formulario.
- Permite cerrar la ventana de reporte fácilmente.

## 🖥️ Requisitos del Sistema
- Windows 10/11
- .NET Framework 4.7 o superior
- Visual Studio (para compilar y ejecutar el proyecto)

## 🚀 Instalación y Ejecución
1. Clonar este repositorio o descargar el código fuente.
   ```sh
   git clone https://github.com/tu-repositorio.git
   ```
2. Abrir el proyecto en **Visual Studio**.
3. Compilar y ejecutar el programa.
4. Ingresar la clave **"123"** para acceder al sistema.
5. Completar los datos del formulario y calcular el costo total.

## 📜 Licencia
Este proyecto está bajo la licencia **MIT**. Puedes usarlo y modificarlo libremente.

---

📩 *Para cualquier duda o mejora, siéntete libre de contribuir o contactarme.* 🚀

