CREATE PROC SP_EliminarAdministrativo
@IdAdministrativo int
AS
DELETE FROM Administrativo 
WHERE IdAdministrativo = @IdAdministrativo
GO

CREATE PROC SP_EliminarCursos
@IdCurso int
AS
DELETE FROM Cursos
WHERE IdCurso = @IdCurso
GO

CREATE PROC SP_EliminarProfesor
@IdCurso int
AS
DELETE FROM Profesor
WHERE IdCurso = @IdCurso
GO

CREATE PROC SP_EliminarAreas
@IdArea int
AS
DELETE FROM Areas
WHERE IdAreas = @IdArea
GO

CREATE PROC SP_EliminarAsignatura
@IdAsignatura int
AS
DELETE FROM Asignatura
WHERE IdAsignatura = @IdAsignatura
GO

CREATE PROC SP_EliminarEstudiante
@IdEstudiante int
AS
DELETE FROM Estudiante
WHERE IdEstudiante = @IdEstudiante
GO

CREATE PROC SP_EliminarPersonalApoyo
@IdPersonalApoyo int
AS
DELETE FROM PersonalApoyo
WHERE IdPersonal = @IdPersonalApoyo
GO

CREATE PROC SP_EliminarCalificacion
@IdCalificacion int
AS
DELETE FROM Calificacion
WHERE IdCalificacion = @IdCalificacion
GO

CREATE PROC SP_EliminarInventario
@IdInventario int
AS
DELETE FROM Inventario
WHERE IdInventario = @IdInventario
GO