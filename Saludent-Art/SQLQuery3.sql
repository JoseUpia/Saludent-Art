---------------------------------------------------------------------------------------------------------------------------------------

DROP TABLE Pacientes
DROP TABLE DatosClinicos
DROP TABLE Procedimientos
DROP TABLE Factura

---------------------------------------------------------------------------------------------------------------------------------------

GO
CREATE TABLE Pacientes(
	IdPaciente INT PRIMARY KEY IDENTITY(1,1),
	Nombre VARCHAR(40) NOT NULL,
	Apellido VARCHAR(40) NOT NULL,
	Edad INT NOT NULL,
	Genero NVARCHAR(1) NOT NULL,
	Correo VARCHAR(30) NOT NULL,
	Telefono NUMERIC(15,0) NOT NULL,
	Direccion VARCHAR(150),
	FechaEntrada Datetime NOT NULL
)

GO
CREATE TABLE DatosClinicos(
	IdDatos INT PRIMARY KEY IDENTITY(1,1),
	IdPaciente INT FOREIGN KEY REFERENCES Pacientes(IdPaciente) ON DELETE CASCADE,
	MedicamentoAlergico VARCHAR(50), 
	IntervencionQuirurgica VARCHAR(50),
	ConsumeMedicamento VARCHAR(50),
	ReacionesAnestecia VARCHAR(2),
	ProblemasSangrado VARCHAR(2),
	PadeceDiabetes VARCHAR(2),
	HipertensionArterial VARCHAR(2), 
	OtraEnfermedad VARCHAR(50),
	Embarazada VARCHAR(2),
	MolestiaBacal VARCHAR(2),
	MalOlor_MalSabor_Boca VARCHAR(2),
	DientesMoviles VARCHAR(2),
	HabitosPerniciosos VARCHAR(2),
	MotivoConsulta VARCHAR(50)
)

GO
CREATE TABLE Procedimientos(
	nom_Procedimiento VARCHAR(50) NOT NULL,
	Precio INT NOT NULL
)

GO
CREATE TABLE Factura(
	IdFactura INT PRIMARY KEY IDENTITY(1,1),
	IdPaciente INT FOREIGN KEY REFERENCES Pacientes(IdPaciente) ON DELETE CASCADE,
	Fecha Datetime NOT NULL
)


INSERT INTO Pacientes VALUES('Pepito', 'Del Rosario', 17, 'M', 'pepito@gmail.com', 8098658757, 'Una direccion cualquiera', GETDATE())
INSERT INTO Pacientes VALUES('Papotico', 'Mejias', 19, 'M', 'papotico@gmail.com', 8095592434, 'Una direccion cualquiera', GETDATE())
INSERT INTO Pacientes VALUES('Pepito', 'Del Rosario', 17, 'M', 'delRosario@gmail.com', 8098658757, 'Una direccion cualquiera', GETDATE())


INSERT INTO DatosClinicos VALUES(2, 'NO', 'SI', 'NO', 'NO', 'SI', 'NO', 'NO', 'SI', 'NO', 'NO', 'SI', 'NO','NO', 'SI')
INSERT INTO DatosClinicos VALUES(3, 'SI', 'SI', 'NO', 'SI', 'NO', 'NO', 'NO', 'NO', 'SI', 'SI', 'SI', 'NO','NO', 'Algo')
INSERT INTO DatosClinicos VALUES(3, 'SI', 'NO', 'NO', 'SI', 'SI', 'NO', 'NO', 'SI', 'SI', 'NO', 'SI', 'SI','NO', 'ALguna cosa')



SELECT IdPaciente AS 'ID', Nombre, Apellido, Edad, Genero, Correo, Telefono, Direccion, FechaEntrada AS 'Fecha de llegada' FROM Pacientes


INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Ortodoncia (Brackets)', 10000)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Endodoncia en molar', 8500)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Endodoncia en molar (premolares)', 6500)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Endodoncia en molar (dientes anteriores)', 4500)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Profilaxis dental', 1300)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Profilaxis dental profunda', 2000)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Blanqueamiento dental', 12000)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Extracciones simples', 1300)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Extracciones de cordales normal', 2500)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Extracciones de cordales', 3000)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Raspaje y alisado (por cuadrante)', 1500)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Pernos de fibra', 1500)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Prótesis total', 15000)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Caries', 1300)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Carillas en resina', 8000)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Carillas indirectas', 25000)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Blanqueamiento dental interno', 4500)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Profilaxis en niños', 700)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Caries en niños', 600)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Aplicación de flúor', 600)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Consultas', 600)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Frenectomia', 8000)
INSERT INTO Procedimientos(nom_Procedimiento, Precio) 
VALUES('Gingivectomia', 9000)


