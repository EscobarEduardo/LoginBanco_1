CREATE PROC spTerritoriesSelectAll -- Devuelve todos los regustros
AS
BEGIN
	SELECT * FROM 	Territories
END

GO

CREATE PROC spTerritoriesSelectById -- Devuelve el registro con el id que le pasa el usuario
(
	@TerritoryID INT
)
AS
BEGIN
	SELECT * FROM Territories WHERE TerritoryID = @TerritoryID
END

GO

CREATE PROC spRegionSelectAll -- Devuelve todos los regustros
AS
BEGIN
  SELECT * FROM   Region
END

GO
