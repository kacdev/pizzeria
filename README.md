# pizzeria

start docker using
```
docker-compose up -d
```
endpoints works under
```
http://localhost:5036/api/Pizza
```
to test post endpoint use

```json
{
    "pizzaModel": 
    {
        "name": "Pizza Hawajska",
        "description": "Pizza z ananasem",
        "ingredients": ["ananas","szynka"],
        "price": "10"
    }
}
```
