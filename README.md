# UnisysRestApi
 Prueba para unisys

# Configuracion
-Instalar SQL Server 2019 y Visual Studio 2019
-Importar la base de datos unisysDB.sql
-Importar el proyecto a Visual Studio 2019
-Configurar el archivo appsettings.json con la conexion con la base de datos.
-Ejecutar

# Consultas de prueba

-POST:
 localhost:56767/api/clients

{
    "idCard": 117040802,
    "name": "Daniel",
    "LastName": "Alvarez"
}

localhost:56767/api/clients
{
    "idCard": 157040502,
    "name": "Isabella",
    "LastName": "Alvarez"
}

localhost:56767/api/movies
{
    "name": "Matrix"   
}
localhost:56767/api/movies
{
    "name": "Dune"   
}

localhost:56767/api/movies
{
    "name": "Lord of The Rings"   
}

localhost:56767/api/favorites

{
    "ClientId": 117040802,
    "MovieId": 1
}

localhost:56767/api/favorites

{
    "ClientId": 117040802,
    "MovieId": 2
}

localhost:56767/api/favorites
{
    "ClientId": 157040502,
    "MovieId": 3
}

-GET

localhost:56767/api/clients

localhost:56767/api/clients/117040802

localhost:56767/api/clients/getfavorite/117040802

localhost:56767/api/clients/getfavorite/157040502
