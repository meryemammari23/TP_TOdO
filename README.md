# aspnet-mvc-todo

Application de gestion de tâches développée avec ASP.NET Core MVC dans le cadre de ma formation d'ingénieure en génie informatique (EHEI Oujda). Projet académique (TP).

## Aperçu
Application web MVC permettant de gérer une liste de tâches. [À COMPLÉTER : énoncé du TP]

## Fonctionnalités
- Gestion de tâches (modèle `Todo`, contrôleur `TodoController`)
- Gestion d'utilisateurs (`UsersController`)
- Gestion de cookies et de sessions via des services dédiés
- [À COMPLÉTER : fonctionnalités réellement présentes]

## Technologies
- C#, ASP.NET Core MVC
- .NET 7 (`net7.0`)

## Structure du projet
| Dossier / fichier | Rôle |
|---|---|
| `Controllers` | Contrôleurs : Todo, Users, ViewConfig |
| `Models` | Modèles : `Todo`, `ErrorViewModel` |
| `Services` | Gestion des cookies et des sessions (interfaces et implémentations) |
| `ViewModels` | Modèles de vues |
| `Views` | Vues |
| `Filters` | Filtres |
| `wwwroot` | Fichiers statiques |
| `Program.cs` | Point d'entrée |

## Installation
Prérequis : SDK .NET 7 (`dotnet --version`). Le projet cible `net7.0` ; avec un SDK plus récent, adapter `TargetFramework` dans `TP_TODO.csproj`.

```bash
git clone https://github.com/meryemammari23/TP_TOdO.git
cd TP_TOdO
```

## Configuration
Aucune configuration particulière : `appsettings.json` ne contient que les paramètres de journalisation.

## Lancement
Le dépôt contient deux fichiers projet : il faut préciser lequel utiliser.

```bash
dotnet run --project TP_TODO.csproj
```

## Captures d'écran
[À COMPLÉTER]

## Améliorations futures
- [À COMPLÉTER : 1 ou 2 idées réalistes]

## Auteure
Meryem Ammari — [LinkedIn](https://www.linkedin.com/in/meryem-a-4627aa227)