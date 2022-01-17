
CREATE PROC SP_MostrarAdministrativo
AS
SELECT TOP 100 * FROM Administrativo
ORDER BY Apellido ASC
GO

CREATE PROC SP_MostrarAreas
AS
SELECT TOP 100 * FROM Areas
ORDER BY Nombre ASC
GO

CREATE PROC SP_MostrarAsignatura
AS
SELECT TOP 100 * FROM Asignatura
ORDER BY Nombre ASC
GO

CREATE PROC SP_MostrarCalificacion
AS
SELECT TOP 100 * FROM Asignatura
ORDER BY Nombre ASC
GO

CREATE PROC SP_MostrarCursos
AS
SELECT TOP 100 * FROM Cursos
ORDER BY Nombre ASC
GO

CREATE PROC SP_MostrarEstudiante
AS
SELECT TOP 100 * FROM Estudiante
ORDER BY Apellido ASC
GO

CREATE PROC SP_MostrarInventario
AS
SELECT TOP 100 * FROM Inventario
ORDER BY Nombre ASC
GO

CREATE PROC SP_MostrarPersonalApoyo
AS
SELECT TOP 100 * FROM PersonalApoyo
ORDER BY Apellido ASC
GO

CREATE PROC SP_MostrarProfesor
AS
SELECT TOP 100 * FROM Profesor
ORDER BY Apellido ASC
GO