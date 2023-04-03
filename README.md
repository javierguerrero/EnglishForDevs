# EnglishForDevs - Software Guidebook

## Introduction
This software guidebook provides an overview of the **EnglishForDevs** application. It includes a summary of the following:
- The requirements, constraints and principles behind the solution.
- The software architecture, including the high-level technology choices and structure of the software.
- The infrastructure architecture and how the software is deployed.
- Operational and support aspects of the application.

## Context

EnglishForDevs is an application designed specifically to help software developers improve their English skills and achieve more effective communication with their team. The application focuses on learning English terminology through real-life dialogues, allowing users to practice simulated situations that may arise in the workplace. With EnglishForDevs, software developers can effectively and practically improve their English skills.

![](https://drive.google.com/uc?id=1QizNWZf3IteBKEzokHmdZbKZqudfGfqo)

### Users
1. Authenticated users
2. Admin

### External Systems
1. OpenAI API
2. Amazon Polly 
3. Google Authorization Server


## Functional Overview

```
Característica: Catálogo de diálogos
  Como usuario 
  Quiero ser capaz de ver los diálogos organizados en categorías y subtcategorías
  Para encontrar los diálogos que necesito de manera más eficiente
  
  Escenario: Mostrar categorías disponibles
    Cuando: ingreso a la aplicación
    Entonces: visualizo una lista de categorías disponibles: Software Requirements, Software Design, Software Construction, etc.
  
  Escenario: Mostrar contenido de categoría "Software Design"
    Cuando: selecciono categoría "Design"
    Entonces: visualizo la lista de subcategorías para esa categoría: Design Patterns, SOLID Principles, AntiPatterns, etc.

  Escenario: Mostrar contenido de subcategoría "SOLID principles"
    Cuando: selecciono subcategoría "SOLID principles"
    Entonces: visualizo una lista de diálogos disponibles en esa subcategoría: SRP, OCP, LSP, ISP, DIP.
    
    
```


```
Característica: Generación de diálogo
  Como usuario 
  Quiero generar un diálogo real a partir de un tópico seleccionado
  Para experimentar el idioma tal como se habla en la vida real
  
  Regla: Debería ser una conversación alternada de 10 frases cortas entre dos personas.
  
    Escenario: generar diálogo para un nivel B2
      Cuando: selecciono el nivel B2
        Y: solicito la generación del diálogo
      Entonces: debería ver un diálogo de 10 frases cortas para un nivel B2  
```

```
Característica: Autenticación de usuario
  Como usuario 
  Quiero 
  Para
```

```
Característica: Traducción de diálogo
  Como usuario 
  Quiero 
  Para
```

```
Característica: Reproducción de diálogo
  Como usuario 
  Quiero 
  Para
```

```
Característica: Flascards
  Como
  Quiero 
  Para
```

```
Característica:
  Como
  Quiero
  Para
```


Diagrams:
https://app.diagrams.net/#G1P88Az-hHvznkhSB0KIn7fVVlExcVvhw7

