-- Corregir y refactorizar el script para tener un funcionamiento correcto.
-- Consideraciones: 
---- El SP es para obtener el promedio de edad de las personas en una ciudad, tomando datos de la tabla People
---- El script debe porder ejecutarse n veces en una misma base de datos sin dar error
---- Se pueden agregar tablas y mas datos de pruebas dentro de las tablas
CREATE TABLE People (Id INT AUTO_INCREMENT PRIMARY KEY, Name VARCHAR(50), Age INT, City VARCHAR(50));

INSERT INTO People (Name, Age, City) VALUES 
('Pepe', 50, 'Buenos Aires'),
('Jorge', 19, 'Buenos Aires'),
('Pepa', 30, 'Mar del Plata'),
('Miguel', 14, 'Mar del Plata'),
('Juan', 9, 'Mar del Plata'),
('Pepo', 40, 'Buenos Aires'),
('Martin', 17, 'Miramar'),
('Pipo', 60, 'Buenos Aires'),
('Matias', 11, 'Buenos Aires'),
('Santiago', 16, 'Buenos Aires');

SELECT	Name,
CASE
WHEN Age > 18 THEN 'Adulto'
WHEN Age > 12 THEN 'Adolescente' 
ELSE 'Menor'
END AS Category,
	   Age,
	   City
FROM People;
      
DROP PROCEDURE IF EXISTS GetAverageAgeOfPeopleFromCity;

DELIMITER //
	
CREATE PROCEDURE GetAverageAgeOfPeopleFromCity(IN cityParam VARCHAR(50))
BEGIN
    DECLARE totalPeople INT;
    DECLARE ageSum INT;
    DECLARE avgAge DECIMAL(5,2);
    
    SELECT COUNT(*) INTO totalPeople
    FROM People
    WHERE City = cityParam;

    SELECT SUM(Age) INTO ageSum
    FROM People
    WHERE City = cityParam;

    IF totalPeople > 0 THEN
        SET avgAge = ageSum / totalPeople;
    ELSE
        SET avgAge = NULL;
    END IF;

    SELECT 
        cityParam AS City, 
        totalPeople AS TotalPeople, 
        ageSum AS AgeSum,
        avgAge AS AverageAge;
END //

DELIMITER ;

CALL GetAverageAgeOfPeopleFromCity('Buenos Aires');
CALL GetAverageAgeOfPeopleFromCity('Mar del Plata');
CALL GetAverageAgeOfPeopleFromCity('Miramar');