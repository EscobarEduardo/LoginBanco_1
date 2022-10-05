

CREATE PROC spPaisSelectAll -- Devuelve todos los regustros
AS
BEGIN
	SELECT * FROM Pais	
END
GO

CREATE PROC spPaisSelectById -- Devuelve el registro con el id que le pasa el usuario
(
	@PaisId INT
)
AS
BEGIN
	SELECT * FROM Pais WHERE PaisId = @PaisId
END
GO

CREATE PROC spPaisInsert
(
	@Nombre VARCHAR(80),
	@Cantidad INT
)
AS
BEGIN
	INSERT INTO Pais(Nombre,Cantidad) VALUES(@Nombre,@Cantidad)
END
GO


CREATE PROC spPaisUpdate
(
	@PaisId INT,
	@Nombre VARCHAR(80),
	@Cantidad INT
)
AS
BEGIN
	UPDATE Pais SET Nombre=@Nombre, Cantidad=@Cantidad WHERE PaisId=@PaisId
END
GO

CREATE PROC spPaisDelete
(
	@PaisId INT
)
AS
BEGIN
	DELETE FROM Pais WHERE PaisId=@PaisId
END
GO


-- Pruebas

exec spPaisInsert 'El Salvador', 7400000
exec spPaisInsert 'Guatemala', 12000000
exec spPaisInsert 'Honduras', 9000000

exec spPaisSelectAll
exec spPaisSelectById 2

exec spPaisUpdate 2, 'Guatemala', 14000000
exec spPaisDelete 3




visual
<connectionStrings>
		<add name="conn" 
			 connectionString="Data source=DESKTOP-I48HKUG\SQLEXPRESS; Initial Catalog= Habitantes; Integrated Security=true"/>
	</connectionStrings>

create database HABITANTES
go
use HABITANTES
go

CREATE TABLE Pais
(
	PaisId INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(80) NOT NULL,
	Cantidad INT NOT NULL
)
go

CREATE TABLE Departamento
(
	DepartamentoId INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(80) NOT NULL,
	Cantidad INT NOT NULL,
	PaisId INT NOT NULL,
	FOREIGN KEY (PaisId) REFERENCES Pais(PaisId)
)
GO

CREATE TABLE Municipio
(
	MunicipioId INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(80) NOT NULL,
	DepartamentoId INT NOT NULL,
	FOREIGN KEY (DepartamentoId) REFERENCES Departamento(DepartamentoId)
)
go

CREATE PROC spPaisSelectAll -- Devuelve todos los regustros
AS
BEGIN
	SELECT * FROM Pais	
END
GO

CREATE PROC spPaisSelectById -- Devuelve el registro con el id que le pasa el usuario
(
	@PaisId INT
)
AS
BEGIN
	SELECT * FROM Pais WHERE PaisId = @PaisId
END
GO

CREATE PROC spPaisInsert
(
	@Nombre VARCHAR(80),
	@Cantidad INT
)
AS
BEGIN
	INSERT INTO Pais(Nombre,Cantidad) VALUES(@Nombre,@Cantidad)
END
GO


CREATE PROC spPaisUpdate
(
	@PaisId INT,
	@Nombre VARCHAR(80),
	@Cantidad INT
)
AS
BEGIN
	UPDATE Pais SET Nombre=@Nombre, Cantidad=@Cantidad WHERE PaisId=@PaisId
END
GO

CREATE PROC spPaisDelete
(
	@PaisId INT
)
AS
BEGIN
	DELETE FROM Pais WHERE PaisId=@PaisId
END
GO


- Pruebas

exec spPaisInsert 'El Salvador', 7400000
exec spPaisInsert 'Guatemala', 12000000
exec spPaisInsert 'Honduras', 9000000

exec spPaisSelectAll
exec spPaisSelectById 2

exec spPaisUpdate 2, 'Guatemala', 14000000
exec spPaisDelete 3


visual
<connectionStrings>
		<add name="conn" 
			 connectionString="Data source=DESKTOP-I48HKUG\SQLEXPRESS; Initial Catalog= Habitantes; Integrated Security=true"/>
	</connectionStrings>

create database HABITANTES
go
use HABITANTES
go

CREATE TABLE Pais
(
	PaisId INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(80) NOT NULL,
	Cantidad INT NOT NULL
)
go

CREATE TABLE Departamento
(
	DepartamentoId INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(80) NOT NULL,
	Cantidad INT NOT NULL,
	PaisId INT NOT NULL,
	FOREIGN KEY (PaisId) REFERENCES Pais(PaisId)
)
GO

CREATE TABLE Municipio
(
	MunicipioId INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(80) NOT NULL,
	DepartamentoId INT NOT NULL,
	FOREIGN KEY (DepartamentoId) REFERENCES Departamento(DepartamentoId)
)
go

CREATE PROC spPaisSelectAll -- Devuelve todos los regustros
AS
BEGIN
	SELECT * FROM Pais	
END
GO

CREATE PROC spPaisSelectById -- Devuelve el registro con el id que le pasa el usuario
(
	@PaisId INT
)
AS
BEGIN
	SELECT * FROM Pais WHERE PaisId = @PaisId
END
GO

CREATE PROC spPaisInsert
(
	@Nombre VARCHAR(80),
	@Cantidad INT
)
AS
BEGIN
	INSERT INTO Pais(Nombre,Cantidad) VALUES(@Nombre,@Cantidad)
END
GO


CREATE PROC spPaisUpdate
(
	@PaisId INT,
	@Nombre VARCHAR(80),
	@Cantidad INT
)
AS
BEGIN
	UPDATE Pais SET Nombre=@Nombre, Cantidad=@Cantidad WHERE PaisId=@PaisId
END
GO

CREATE PROC spPaisDelete
(
	@PaisId INT
)
AS
BEGIN
	DELETE FROM Pais WHERE PaisId=@PaisId
END
GO


--Pruebas

exec spPaisInsert 'El Salvador', 7400000
exec spPaisInsert 'Guatemala', 12000000
exec spPaisInsert 'Honduras', 9000000

exec spPaisSelectAll
exec spPaisSelectById 2

exec spPaisUpdate 2, 'Guatemala', 14000000
exec spPaisDelete 3

