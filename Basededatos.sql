create database tablajuegos;

use tablajuegos;

create table datosUsuario(
id_Usuario varchar(3) primary key not null,
nombre_Usuario varchar(25) not null,
contra_Usuario varchar(25) not null,
pais_Usuario varchar(30) not null);

