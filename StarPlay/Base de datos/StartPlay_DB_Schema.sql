CREATE DATABASE StartPlay_DB;
Use StartPlay_DB;

Create Table Artistas (id_artista Int(10) PRIMARY KEY Auto_increment, nombre Varchar(255) Not Null);

Create Table Generos (id_genero Int(10) PRIMARY KEY Auto_increment, nombre Varchar(255) Not Null);

Create table Albumes (id_album Int(10) PRIMARY KEY Auto_increment, titulo VARCHAR(75) Not Null, id_artista Int(10), año VARCHAR(4));

Create table Canciones (id_cancion Int(10) Primary KEY Auto_increment, titulo Varchar(75) NOT NULL, id_artista Int(10), id_genero Int(10), id_album Int(10), año Varchar(4), ruta Varchar(500) Not Null);

Alter Table Albumes Add Constraint fk_album_artista Foreign Key (id_artista) References Artistas(id_artista);

Alter Table Canciones Add Constraint fk_cancion_artista Foreign Key (id_artista) References Artistas(id_artista);

Alter Table Canciones Add Constraint fk_cancion_album Foreign Key (id_album) References Albumes(id_album);

Alter Table Canciones Add Constraint fk_cancion_genero Foreign Key (id_genero) References Generos(id_genero);