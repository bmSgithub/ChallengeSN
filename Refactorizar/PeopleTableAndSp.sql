-- Corregir y refactorizar el script para tener un funcionamiento correcto.
-- Consideraciones: 
---- El SP es para obtener el promedio de edad de las personas en una ciudad, tomando datos de la tabla People
---- El script debe porder ejecutarse n veces en una misma base de datos sin dar error
---- Se pueden agregar tablas y mas datos de pruebas dentro de las tablas

CREATE TABLE People (
    Id INT,
    Name VARCHAR(50),
    Age INT,
    City VARCHAR(50)
)

INSERT INTO People VALUES ('Pepe',50, 'Buenos Aires')
INSERT INTO People VALUES ('Pepa',30, 'Mar del Plata')
INSERT INTO People VALUES ('Pepo',40, 'Buenos Aires')
INSERT INTO People VALUES ('Pipo',60, 'Buenos Aires')

SELECT	Name,
				CASE
        	WHEN Age > 18 THEN 'Adulto'
          WHEN Age <= 18 AND Age > 12 THEN 'Adolescente' 
        	ELSE 'Menor'
        END AS Category,
        Age,
        City
      
	
CREATE PROCEDURE dbo.GetAverageAgeOfPeopleFromACity
    @City VArchar(50)
AS
BEGIN
    DECLARE @Age INT
    DECLARE @AgeSum INT
    DECLARE @Total INT

    -- Inicializar variables
    SET @Total = 0

    -- Declarar el cursor
    DECLARE CursorAge CURSOR FOR
    SELECT Age
    FROM People
    WHERE ISNULL(City,'') = @City

    -- Abrir el cursor
    OPEN CursorAge

    -- Obtener el primer registro
    FETCH NEXT FROM CursorAge INTO @Age

    -- Recorrer los registros
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @AgeSum = @AgeSum + @Age
        SET @Total = @Total + 1

        FETCH NEXT FROM CursorAge INTO @Age
    END

    -- Cerrar y desvincular el cursor
    CLOSE CursorAge
    DEALLOCATE CursorAge

    -- Obtener el promedio
   SELECT @AgeSum / @Total AS PromedioEdad
END