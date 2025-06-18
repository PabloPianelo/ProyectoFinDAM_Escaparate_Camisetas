# 🎽 Escaparate de Camisetas - Proyecto Final DAM

> Sistema de gestión y visualización de camisetas desarrollado en C# WPF con base de datos MySQL.

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-blue.svg)](https://dotnet.microsoft.com/download/dotnet-framework)
[![MySQL](https://img.shields.io/badge/MySQL-8.0+-orange.svg)](https://www.mysql.com/)
[![XAMPP](https://img.shields.io/badge/XAMPP-Required-red.svg)](https://www.apachefriends.org/)
[![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2019+-purple.svg)](https://visualstudio.microsoft.com/)

---

## 📋 Índice

- [Descripción](#-descripción)
- [Características](#-características)
- [Requisitos del Sistema](#-requisitos-del-sistema)
- [Instalación](#-instalación)
- [Configuración de la Base de Datos](#-configuración-de-la-base-de-datos)
- [Estructura del Proyecto](#-estructura-del-proyecto)
- [Uso de la Aplicación](#-uso-de-la-aplicación)
- [Arquitectura](#-arquitectura)
- [Tecnologías Utilizadas](#-tecnologías-utilizadas)
- [Troubleshooting](#-troubleshooting)
- [Contribución](#-contribución)
- [Licencia](#-licencia)

---

## 🎯 Descripción

Escaparate de Camisetas es una aplicación de escritorio desarrollada como **Proyecto Final de Desarrollo de Aplicaciones Multiplataforma (DAM)**. La aplicación permite gestionar un catálogo de camisetas con funcionalidades completas de CRUD, sistema de usuarios con roles diferenciados (administrador/usuario) y una interfaz intuitiva para visualizar productos.

### Funcionalidades Principales:
- 🔐 **Sistema de autenticación** con roles de usuario y administrador
- 👕 **Gestión completa de camisetas** (crear, leer, actualizar, eliminar)
- 🖼️ **Manejo de imágenes** asociadas a los productos
- 👥 **Administración de usuarios**
- 🏪 **Escaparate visual** para mostrar productos
- 📊 **Panel de control administrativo**

---

## ✨ Características

### Para Administradores:
- ✅ Gestión completa de productos (camisetas)
- ✅ Administración de usuarios del sistema
- ✅ Control de imágenes del catálogo
- ✅ Panel de administración intuitivo
- ✅ Visualización de estadísticas

### Para Usuarios:
- ✅ Navegación por el catálogo de productos
- ✅ Visualización detallada de camisetas
- ✅ Registro en el sistema
- ✅ Interfaz de usuario amigable

---

## 💻 Requisitos del Sistema

### Software Necesario:
- **Windows 10/11** (recomendado)
- **XAMPP** (Apache + MySQL + PHP)
- **Visual Studio 2019 o superior** con soporte para .NET Framework
- **.NET Framework 4.7.2** o superior
- **MySQL Server** (incluido en XAMPP)

### Hardware Mínimo:
- **RAM:** 4GB (8GB recomendado)
- **Espacio en disco:** 500MB libres
- **Procesador:** Intel Core i3 o equivalente

---

## 🚀 Instalación

### 1. Preparar el Entorno

#### Instalar XAMPP:
1. Descargar XAMPP desde [https://www.apachefriends.org/](https://www.apachefriends.org/)
2. Ejecutar el instalador como administrador
3. Instalar en la ruta predeterminada: `C:\xampp`
4. Iniciar **Apache** y **MySQL** desde el panel de control de XAMPP

#### Verificar MySQL:
```bash
# Acceder a MySQL desde línea de comandos
cd C:\xampp\mysql\bin
mysql -u root -p
```

### 2. Clonar/Descargar el Proyecto

```bash
# Si usas Git
git clone [URL-del-repositorio]

# O descargar y extraer en:
C:\xampp\htdocs\DWes\ProyectoFinDAM_Escaparate_Camisetas
```

### 3. Configurar Visual Studio

1. Abrir **Visual Studio**
2. Seleccionar `Abrir un proyecto o solución`
3. Navegar a: `C:\xampp\htdocs\DWes\ProyectoFinDAM_Escaparate_Camisetas\`
4. Abrir el archivo: `Proyecto_Escaparate_Camisetas.sln`

---

## 🗄️ Configuración de la Base de Datos

### 1. Importar la Base de Datos

#### Método 1: phpMyAdmin (Recomendado)
1. Abrir navegador web y ir a: `http://localhost/phpmyadmin`
2. Crear nueva base de datos llamada: `proyecto_escaparate_camisetas`
3. Seleccionar la base de datos creada
4. Ir a la pestaña **Importar**
5. Seleccionar el archivo: `proyecto_escaparate_camisetas.sql`
6. Hacer clic en **Continuar**

#### Método 2: Línea de Comandos
```bash
# Navegar al directorio de MySQL
cd C:\xampp\mysql\bin

# Crear la base de datos
mysql -u root -p -e "CREATE DATABASE proyecto_escaparate_camisetas;"

# Importar el archivo SQL
mysql -u root -p proyecto_escaparate_camisetas < "C:\xampp\htdocs\DWes\ProyectoFinDAM_Escaparate_Camisetas\proyecto_escaparate_camisetas.sql"
```

### 2. Verificar la Importación

```sql
-- Conectar a MySQL
mysql -u root -p

-- Usar la base de datos
USE proyecto_escaparate_camisetas;

-- Mostrar tablas
SHOW TABLES;

-- Verificar datos de ejemplo
SELECT * FROM usuarios LIMIT 5;
SELECT * FROM camisetas LIMIT 5;
```

### 3. Configuración de Conexión

La configuración de conexión se encuentra en:
```
Proyecto_Escaparate_Camisetas\BD\ConexionBD.cs
```

**Configuración actual:**
- **Servidor:** localhost
- **Base de datos:** proyecto_escaparate_camisetas
- **Usuario:** root
- **Contraseña:** (vacía)
- **Puerto:** 3306 (predeterminado)

---

## 📁 Estructura del Proyecto

```
ProyectoFinDAM_Escaparate_Camisetas/
├── 📄 README.md                                    # Este archivo
├── 📄 Proyecto_Escaparate_Camisetas.sln            # Solución de Visual Studio
├── 📄 proyecto_escaparate_camisetas.sql            # Script de base de datos
├── 📄 ControladorCamiseta.html                     # Documentación adicional
├── 📁 .vs/                                         # Configuración de Visual Studio
├── 📁 packages/                                    # Paquetes NuGet
└── 📁 Proyecto_Escaparate_Camisetas/               # Proyecto principal
    ├── 📁 BD/                                      # Capa de datos
    │   ├── ConexionBD.cs                          # Conexión a MySQL
    │   └── Modelo.cs                              # Modelo de datos
    ├── 📁 Clases/                                  # Modelos de negocio
    │   ├── Camiseta.cs                            # Clase Camiseta
    │   ├── Imagen.cs                              # Clase Imagen
    │   └── Usuarios.cs                            # Clase Usuario
    ├── 📁 Conexión/                                # Certificados SSL
    │   └── BaltimoreCyberTrustRoot.crt.pem        # Certificado Azure
    ├── 📁 Imagenes/                                # Recursos gráficos
    ├── 📁 Properties/                              # Propiedades del proyecto
    ├── 📁 Registro_Login/                          # Lógica de autenticación
    ├── 📁 Singleton/                               # Patrón Singleton
    ├── 📁 bin/                                     # Ejecutables compilados
    ├── 📁 obj/                                     # Archivos temporales
    ├── 🖼️ Ventanas XAML:                           # Interfaces de usuario
    │   ├── Login.xaml                             # Pantalla de login
    │   ├── Registro.xaml                          # Registro de usuarios
    │   ├── InicioAdmin.xaml                       # Panel administrativo
    │   ├── InicioUsuario.xaml                     # Panel de usuario
    │   ├── Escaparate.xaml                        # Catálogo de productos
    │   ├── AdministradorCamisetas.xaml            # Gestión de camisetas
    │   ├── AdministradorImagen.xaml               # Gestión de imágenes
    │   ├── AdministradorUsuarios.xaml             # Gestión de usuarios
    │   ├── ControladorCamiseta.xaml               # Control de camisetas
    │   └── ControladorImagen.xaml                 # Control de imágenes
    ├── App.config                                  # Configuración de la aplicación
    ├── App.xaml                                    # Aplicación WPF principal
    ├── packages.config                             # Configuración de NuGet
    └── Proyecto_Escaparate_Camisetas.csproj       # Archivo de proyecto
```

---

## 🎮 Uso de la Aplicación

### 1. Ejecutar la Aplicación

#### Desde Visual Studio:
1. Abrir la solución `Proyecto_Escaparate_Camisetas.sln`
2. Compilar la solución: `Ctrl + Shift + B`
3. Ejecutar: `F5` o clic en **Iniciar**

#### Desde el Ejecutable:
```bash
# Navegar al directorio de salida
cd "C:\xampp\htdocs\DWes\ProyectoFinDAM_Escaparate_Camisetas\Proyecto_Escaparate_Camisetas\bin\Debug"

# Ejecutar la aplicación
Proyecto_Escaparate_Camisetas.exe
```

### 2. Flujo de Trabajo

#### Login Inicial:
1. **Pantalla de Login:** Introducir credenciales o registrarse
2. **Registro:** Crear nueva cuenta de usuario
3. **Autenticación:** Validación de credenciales

#### Panel de Usuario:
- Navegación por el catálogo
- Visualización de productos
- Búsqueda y filtrado

#### Panel de Administrador:
- Gestión completa de productos
- Administración de usuarios
- Control de imágenes
- Estadísticas del sistema

### 3. Usuarios Predeterminados

**Administrador:**
- Usuario: `admin`
- Contraseña: `admin123`

**Usuario Normal:**
- Usuario: `usuario`
- Contraseña: `user123`

---

## 🏗️ Arquitectura

### Patrón de Arquitectura: **Modelo-Vista-Controlador (MVC)**

```
┌─────────────────┐    ┌─────────────────┐    ┌─────────────────┐
│     VISTA       │    │   CONTROLADOR   │    │     MODELO      │
│   (XAML/WPF)    │◄──►│   (.xaml.cs)    │◄──►│   (Clases/BD)   │
│                 │    │                 │    │                 │
│ • Login.xaml    │    │ • Login.cs      │    │ • Usuarios.cs   │
│ • Escaparate... │    │ • Escaparate... │    │ • Camiseta.cs   │
│ • Admin...      │    │ • Admin...      │    │ • ConexionBD.cs │
└─────────────────┘    └─────────────────┘    └─────────────────┘
```

### Capas de la Aplicación:

1. **Capa de Presentación (UI):**
   - Archivos XAML
   - Controles WPF
   - Eventos de interfaz

2. **Capa de Lógica de Negocio:**
   - Controladores (.xaml.cs)
   - Validaciones
   - Reglas de negocio

3. **Capa de Acceso a Datos:**
   - ConexionBD.cs
   - Modelo.cs
   - Consultas SQL

4. **Capa de Datos:**
   - Base de datos MySQL
   - Tablas y relaciones

---

## 🛠️ Tecnologías Utilizadas

### Frontend:
- **WPF (Windows Presentation Foundation)** - Framework de interfaz de usuario
- **XAML** - Lenguaje de marcado para definir UI
- **C#** - Lenguaje de programación principal

### Backend:
- **.NET Framework 4.7.2** - Plataforma de desarrollo
- **Entity Framework** - ORM para acceso a datos
- **MySQL Connector/NET** - Driver de conexión a MySQL

### Base de Datos:
- **MySQL 8.0+** - Sistema de gestión de base de datos
- **phpMyAdmin** - Interfaz web para MySQL

### Herramientas de Desarrollo:
- **Visual Studio 2019+** - IDE principal
- **XAMPP** - Paquete de servidor web
- **NuGet Package Manager** - Gestor de paquetes

### Librerías y Dependencias:
```xml
<!-- packages.config -->
<package id="MySql.Data" version="8.0.33" />
<package id="EntityFramework" version="6.4.4" />
<package id="System.Runtime.CompilerServices.Unsafe" version="5.0.0" />
```

---

## 🔧 Troubleshooting

### Problemas Comunes:

#### 1. Error de Conexión a la Base de Datos
```
Error: "Unable to connect to any of the specified MySQL hosts"
```
**Solución:**
- Verificar que XAMPP esté ejecutándose
- Comprobar que MySQL esté activo en el panel de XAMPP
- Verificar la configuración en `ConexionBD.cs`

#### 2. Error de Compilación
```
Error: "The type or namespace name 'MySql' could not be found"
```
**Solución:**
```bash
# Restaurar paquetes NuGet
NuGet\NuGet.exe restore

# O desde Visual Studio: Clic derecho en la solución > Restaurar paquetes NuGet
```

#### 3. Base de Datos No Encontrada
```
Error: "Database 'proyecto_escaparate_camisetas' doesn't exist"
```
**Solución:**
- Importar el archivo SQL: `proyecto_escaparate_camisetas.sql`
- Verificar el nombre de la base de datos

#### 4. Imágenes No se Cargan
**Solución:**
- Verificar permisos de la carpeta `Imagenes/`
- Comprobar rutas de archivos
- Verificar formatos de imagen soportados

### Logs y Depuración:
```csharp
// Habilitar logging en ConexionBD.cs
try {
    conex = new MySqlConnection(cadenaConexion);
    conex.Open();
    Console.WriteLine("Conexión exitosa");
} catch (MySqlException e) {
    Console.WriteLine($"Error BD: {e.Message}");
    MessageBox.Show("Error en la base de datos " + e.ToString());
}
```

---



## 📄 Licencia

Este proyecto está bajo la **Licencia MIT**. Ver el archivo `LICENSE` para más detalles.

```
MIT License

Copyright (c) 2023 Proyecto Final DAM - Escaparate de Camisetas

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

---

## 📞 Contacto

**Proyecto Final DAM - Escaparate de Camisetas**

- 📧 **Email:** [pablopianeloxd@gmail.com]
- 🌐 **GitHub:** [[tu-usuario-github](https://github.com/PabloPianelo)]
- 💼 **LinkedIn:** [[tu-perfil-linkedin](https://www.linkedin.com/in/pablopianeloalonso/)]

---

<div align="center">

### 🚀 ¡Gracias por usar Escaparate de Camisetas! 🎽

**Desarrollado con ❤️ como Proyecto Final de DAM**

[![Visual Studio](https://img.shields.io/badge/Made%20with-Visual%20Studio-purple.svg)](https://visualstudio.microsoft.com/)
[![C#](https://img.shields.io/badge/Built%20with-C%23-green.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![MySQL](https://img.shields.io/badge/Database-MySQL-orange.svg)](https://www.mysql.com/)

</div>

