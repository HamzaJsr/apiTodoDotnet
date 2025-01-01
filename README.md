# Todo API

Une API REST simple pour gérer des tâches (Todo). Cette API permet de créer, lire, mettre à jour et supprimer des tâches.

## Prérequis

- .NET 6 ou supérieur
- Visual Studio Code, Visual Studio ou tout autre IDE compatible
- Postman, Insomnia ou tout autre client pour tester les endpoints

## Installation

1. Clonez le dépôt :

   ```bash
   git clone https://github.com/ton-utilisateur/TodoApi.git
   ```

2. Accédez au dossier du projet :

   ```bash
   cd TodoApi
   ```

3. Restaurez les dépendances :

   ```bash
   dotnet restore
   ```

4. Lancez l'application :
   ```bash
   dotnet run
   ```

## Endpoints de l'API

| Méthode HTTP | Endpoint         | Description                               |
| ------------ | ---------------- | ----------------------------------------- |
| `GET`        | `/api/todo`      | Récupère toutes les tâches                |
| `GET`        | `/api/todo/{id}` | Récupère une tâche par son ID             |
| `POST`       | `/api/todo`      | Crée une nouvelle tâche                   |
| `PUT`        | `/api/todo/{id}` | Met à jour une tâche existante par son ID |
| `DELETE`     | `/api/todo/{id}` | Supprime une tâche par son ID             |

### Exemple de modèle JSON pour une tâche

```json
{
  "id": 1,
  "title": "Apprendre C#",
  "startDate": "2023-11-15T10:00:00",
  "endDate": "2023-11-20T18:00:00"
}
```

## Utilisation

1. Une fois l'application lancée, l'API sera disponible à :

   ```
   http://localhost:5013
   ```

2. Testez les endpoints via un client REST comme Postman ou Insomnia :

   - **Créer une tâche** (POST) :

     - URL : `http://localhost:5013/api/todo`
     - Corps :
       ```json
       {
         "title": "Terminer le projet",
         "startDate": "2025-01-01T10:00:00",
         "endDate": "2025-01-05T18:00:00"
       }
       ```

   - **Mettre à jour une tâche** (PUT) :

     - URL : `http://localhost:5013/api/todo/1`
     - Corps :
       ```json
       {
         "title": "Apprendre ASP.NET Core",
         "startDate": "2025-01-01T10:00:00",
         "endDate": "2025-01-05T18:00:00"
       }
       ```

   - **Supprimer une tâche** (DELETE) :
     - URL : `http://localhost:5013/api/todo/1`

## Fonctionnalités

- Ajouter une tâche avec un titre, une date de début et une date de fin
- Récupérer toutes les tâches ou une tâche spécifique
- Mettre à jour les informations d'une tâche
- Supprimer une tâche

## Licence

Ce projet est sous licence [MIT](https://opensource.org/licenses/MIT).
