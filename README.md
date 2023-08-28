# Reflection Introduction

This repository contains a simple demonstration of using .NET Reflection to explore types, methods, properties, and fields within an assembly. It includes examples using different classes from the "ReflectionIntroLibrary" assembly.

## Table of Contents

- [Introduction](#introduction)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Introduction

Reflection is a powerful feature in .NET that allows you to inspect and manipulate types, methods, properties, and fields at runtime. It enables you to work with the metadata of your assemblies, even if the types are not known at compile time. This is particularly useful when building flexible and extensible applications, implementing plugins, or performing tasks that require dynamic loading of assemblies.

## Usage

1. Clone the repository to your local machine.

2. Open the `ReflectionIntroduction` project in your preferred development environment.

3. Make sure to add a project reference to the `ReflectionIntroLibrary` assembly, which contains the classes used for demonstration.

4. Build and run the program to observe how reflection is utilized to inspect the assembly's types, methods, properties, and fields.

    ```csharp
    // Load the assembly from the referenced class library
    Assembly assembly = Assembly.LoadFrom("ReflectionIntroLibrary.dll");

    // Get all types in the assembly
    Type[] types = assembly.GetTypes();
    foreach (Type type in types)
    {
        Console.WriteLine($"Type: {type.FullName}");

        // Get methods in the type
        MethodInfo[] methods = type.GetMethods();
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine($"    Method: {method.Name}");
        }

        // Get properties in the type
        PropertyInfo[] properties = type.GetProperties();
        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine($"    Property: {property.Name}");
        }

        // Get fields in the type
        FieldInfo[] fields = type.GetFields();
        foreach (FieldInfo field in fields)
        {
            Console.WriteLine($"    Field: {field.Name}");
        }
    }
    ```

## Contributing

Contributions are welcome! If you find issues or have improvements to suggest, feel free to submit pull requests.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE.txt) file for details.

---
# Spanish
---

# Introducción a la Reflexión en .NET

Este repositorio contiene una demostración simple del uso de la Reflexión en .NET para explorar tipos, métodos, propiedades y campos dentro de un ensamblado. Incluye ejemplos utilizando diferentes clases de la biblioteca "ReflectionIntroLibrary".

## Tabla de Contenidos

- [Introducción](#introducción)
- [Uso](#uso)
- [Contribuciones](#contribuciones)
- [Licencia](#licencia)

## Introducción

La Reflexión es una potente característica en .NET que te permite inspeccionar y manipular tipos, métodos, propiedades y campos en tiempo de ejecución. Te permite trabajar con los metadatos de tus ensamblados, incluso si los tipos no se conocen en tiempo de compilación. Esto es especialmente útil al construir aplicaciones flexibles y extensibles, implementar complementos o realizar tareas que requieren la carga dinámica de ensamblados.

## Uso

1. Clona el repositorio en tu máquina local.

2. Abre el proyecto `ReflectionIntroduction` en tu entorno de desarrollo preferido.

3. Asegúrate de añadir una referencia de proyecto a la biblioteca `ReflectionIntroLibrary`, que contiene las clases utilizadas para la demostración.

4. Compila y ejecuta el programa para observar cómo se utiliza la reflexión para inspeccionar los tipos, métodos, propiedades y campos del ensamblado.

    ```csharp
    // Carga el ensamblado de la biblioteca de clases referenciada
    Assembly assembly = Assembly.LoadFrom("ReflectionIntroLibrary.dll");

    // Obtiene todos los tipos en el ensamblado
    Type[] types = assembly.GetTypes();
    foreach (Type type in types)
    {
        Console.WriteLine($"Tipo: {type.FullName}");

        // Obtiene los métodos en el tipo
        MethodInfo[] methods = type.GetMethods();
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine($"    Método: {method.Name}");
        }

        // Obtiene las propiedades en el tipo
        PropertyInfo[] properties = type.GetProperties();
        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine($"    Propiedad: {property.Name}");
        }

        // Obtiene los campos en el tipo
        FieldInfo[] fields = type.GetFields();
        foreach (FieldInfo field in fields)
        {
            Console.WriteLine($"    Campo: {field.Name}");
        }
    }
    ```

## Contribuciones

¡Las contribuciones son bienvenidas! Si encuentras problemas o tienes mejoras para sugerir, no dudes en enviar solicitudes pull.

## Licencia

Este proyecto está bajo la Licencia MIT. Consulta el archivo [LICENSE](LICENSE.txt) para más detalles.

---
# Français
---
# Introduction à la Réflexion (.NET Reflection)

Ce dépôt contient une démonstration simple de l'utilisation de la Réflexion .NET pour explorer les types, méthodes, propriétés et champs au sein d'une assemblée. Il inclut des exemples utilisant différentes classes de la bibliothèque "ReflectionIntroLibrary".

## Table des matières

- [Introduction](#introduction)
- [Utilisation](#utilisation)
- [Contributions](#contributions)
- [Licence](#licence)

## Introduction

La Réflexion est une fonctionnalité puissante dans .NET qui vous permet d'inspecter et de manipuler les types, méthodes, propriétés et champs à l'exécution. Elle vous permet de travailler avec les métadonnées de vos assemblages, même si les types ne sont pas connus au moment de la compilation. Cela est particulièrement utile lors de la construction d'applications flexibles et extensibles, de l'implémentation de plugins ou de l'exécution de tâches nécessitant le chargement dynamique d'assemblages.

## Utilisation

1. Clonez le dépôt sur votre machine locale.

2. Ouvrez le projet `ReflectionIntroduction` dans votre environnement de développement préféré.

3. Assurez-vous d'ajouter une référence de projet à la bibliothèque `ReflectionIntroLibrary`, qui contient les classes utilisées pour la démonstration.

4. Compilez et exécutez le programme pour observer comment la réflexion est utilisée pour inspecter les types, méthodes, propriétés et champs de l'assemblage.

    ```csharp
    // Charge l'assemblage de la bibliothèque de classes référencée
    Assembly assembly = Assembly.LoadFrom("ReflectionIntroLibrary.dll");

    // Obtient tous les types dans l'assemblage
    Type[] types = assembly.GetTypes();
    foreach (Type type in types)
    {
        Console.WriteLine($"Type : {type.FullName}");

        // Obtient les méthodes dans le type
        MethodInfo[] methods = type.GetMethods();
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine($"    Méthode : {method.Name}");
        }

        // Obtient les propriétés dans le type
        PropertyInfo[] properties = type.GetProperties();
        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine($"    Propriété : {property.Name}");
        }

        // Obtient les champs dans le type
        FieldInfo[] fields = type.GetFields();
        foreach (FieldInfo field in fields)
        {
            Console.WriteLine($"    Champ : {field.Name}");
        }
    }
    ```

## Contributions

Les contributions sont les bienvenues ! Si vous rencontrez des problèmes ou avez des améliorations à suggérer, n'hésitez pas à soumettre des demandes de pull.

## Licence

Ce projet est sous licence MIT. Consultez le fichier [LICENSE](LICENSE.txt) pour plus de détails.

---
