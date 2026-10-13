Le projet met en œuvre le pattern Stratégie : l'interface `ReductionService` est implémentée par trois stratégies de réduction interchangeables (fixe, variable, basée sur la base de données), injectées par Spring.



\## Utilisation de l'API



| Méthode | URL | Description |

|---|---|---|

| POST | `/api/transactions` | Crée une transaction et calcule le montant après remise |

| GET | `/api/transactions/{id}` | Récupère une transaction |

| PUT | `/api/transactions/{id}` | Met à jour le montant d'une transaction |

| DELETE | `/api/transactions/{id}` | Supprime une transaction |



Une transaction inexistante renvoie `404`. Une `RemiseException` renvoie `400`.



Exemple de création :



```bash

curl -X POST http://localhost:8080/api/transactions \\

&#x20; -H "Content-Type: application/json" \\

&#x20; -d '{"montant": 1000}'

```

