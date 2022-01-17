CREATE PROC SP_BuscarApellidoAdministrativo
@textobuscar VARCHAR(50)
AS
SELECT * FROM Administrativo
WHERE Apellido LIKE @textobuscar + '%'
ORDER BY Apellido ASC
GO

CREATE PROC SP_BuscarCedulaAdministrativo
@textobuscar VARCHAR(50)
AS
SELECT * FROM Administrativo
WHERE Cedula LIKE @textobuscar + '%'
ORDER BY Apellido ASC
GO

CREATE PROC SP_BuscarAreas
@textobuscar VARCHAR(50)
AS
SELECT * FROM Areas
WHERE Nombre LIKE @textobuscar + '%'
ORDER BY Nombre ASC
GO

CREATE PROC SP_BuscarAsignatura
@textobuscar VARCHAR(50)
AS
SELECT * FROM Asignatura
WHERE Nombre LIKE @textobuscar + '%'
ORDER BY Nombre ASC
GO

CREATE PROC SP_BuscarCursos
@textobuscar VARCHAR(50)
AS
SELECT * FROM Cursos
WHERE Nombre LIKE @textobuscar + '%'
ORDER BY Nombre ASC
GO