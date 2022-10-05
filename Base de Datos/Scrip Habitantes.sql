create database Habitantes
go
use Habitantes
go

CREATE TABLE Pais(
PaisId INT PRIMARY KEY IDENTITY,
Nombre Varchar(80) not null
)
go

CREATE TABLE Departamento(
DepartamentoId INT PRIMARY KEY IDENTITY,
Nombre varchar(80) not null,
Cantidad int not null,
PaisId int not null,
Foreign key (PaisId) References Pais(PaisId)
)
go

Create table Municipio(
Municipio  INT PRIMARY KEY IDENTITY,
Nombre varchar(80) not null,
Cantidad int not null,
DepartamentoId int not null,
Foreign key(DepartamentoId) References Departamento (DepartamentoId)

)
go