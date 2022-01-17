CREATE PROC SP_EditarAdministrativo
@IdAdministrativo int,
@Nombre nvarchar(30),
@Apellido nvarchar(30),
@Telefono nvarchar(12),
@Direccion nvarchar(50),
@Cedula nvarchar(13), 
@Genero nvarchar(1),
@Condicion_Medica nvarchar(50),
@Fecha_Nacimiento datetime,
@Fecha_Ingreso datetime,
@Correo_Electronico nvarchar(30),
@Nacionalidad nvarchar(50),
@Titulo nvarchar(30),
@Estatus nvarchar(30),
@Funcion nvarchar(30)
AS
UPDATE Administrativo SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Direccion = @Direccion, 
Cedula = @Cedula, Genero = @Genero, Condicion_Medica = @Condicion_Medica, Fecha_Nacimiento = @Fecha_Nacimiento, 
Fecha_Ingreso = @Fecha_Ingreso, Correo_Electronico = @Correo_Electronico, Nacionalidad = @Nacionalidad, 
Titulo = @Titulo, Estatus = @Estatus, Funcion = @Funcion
WHERE IdAdministrativo = @IdAdministrativo
GO

CREATE PROC SP_EditarCursos
@IdCurso int,
@Nombre nvarchar(30)
AS
UPDATE Cursos SET Nombre = @Nombre
WHERE IdCurso = @IdCurso
GO

CREATE PROC SP_EditarProfesor
@IdCurso int,
@Nombre nvarchar(30),
@Apellido nvarchar(30),
@Telefono nvarchar(12),
@Direccion nvarchar(100),
@Cedula nvarchar(13),
@Genero nvarchar(1),
@Condicion_Medica nvarchar(30),
@Fecha_Nacimiento datetime,
@Fecha_Ingreso datetime,
@Correo_Electronico nvarchar(30),
@Nacionalidad nvarchar(30),
@Titulo nvarchar(30),
@Estatus nvarchar(30)
AS
UPDATE Profesor SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Direccion = @Direccion, Cedula = @Cedula, Genero = @Genero, 
Condicion_Medica = @Condicion_Medica, Fecha_Nacimiento = @Fecha_Nacimiento, Fecha_Ingreso = @Fecha_Ingreso, Correo_Electronico = @Correo_Electronico, Nacionalidad = Nacionalidad, 
Titulo = @Titulo, Estatus = @Estatus
WHERE IdCurso = @IdCurso
GO

CREATE PROC SP_EditarAreas
@IdArea int,
@Nombre nvarchar(30)
AS
UPDATE Areas SET Nombre = @Nombre
WHERE IdAreas = @IdArea
GO

CREATE PROC SP_EditarAsignatura
@IdAsignatura int,
@Nombre nvarchar(30),
@Descripcion nvarchar(50)
AS
UPDATE Asignatura SET Nombre = @Nombre, Descripcion = @Descripcion
WHERE IdAsignatura = @IdAsignatura
GO

CREATE PROC SP_EditarEstudiante
@IdEstudiante int,
@Nombre nvarchar(30),
@Apellido nvarchar(30),
@Telefono nvarchar(12),
@Direccion nvarchar(50),
@Cedula nvarchar(13), 
@Genero nvarchar(1),
@Condicion_Medica nvarchar(50),
@Fecha_Nacimiento datetime,
@Fecha_Ingreso datetime,
@Correo_Electronico nvarchar(30),
@Nacionalidad nvarchar(50),
@Estatus nvarchar(30),
@AñoEscolar nvarchar(30)
AS
UPDATE Estudiante SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Direccion = @Direccion, Cedula = @Cedula, Genero = @Genero, 
Condicion_Medica = @Condicion_Medica, Fecha_Nacimiento = Fecha_Nacimiento, Fecha_Ingreso = @Fecha_Ingreso, Correo_Electronico = @Correo_Electronico, Nacionalidad = Nacionalidad, Estatus = @Estatus, AñoEscolar = @AñoEscolar
WHERE IdEstudiante = @IdEstudiante
GO

CREATE PROC SP_EditarPersonalApoyo
@IdPersonalApoyo int,
@Nombre nvarchar(30),
@Apellido nvarchar(30),
@Telefono nvarchar(12),
@Direccion nvarchar(50),
@Cedula nvarchar(13), 
@Genero nvarchar(1),
@Condicion_Medica nvarchar(50),
@Fecha_Nacimiento datetime,
@Fecha_Ingreso datetime,
@Correo_Electronico nvarchar(30),
@Nacionalidad nvarchar(50),
@Estatus nvarchar(30),
@Funcion nvarchar(30)
AS
UPDATE PersonalApoyo SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Direccion = @Direccion, 
Cedula = @Cedula, Genero = @Genero, Condicion_Medica = @Condicion_Medica, Fecha_Nacimiento = @Fecha_Nacimiento, 
Fecha_Ingreso = @Fecha_Ingreso, Correo_Electronico = @Correo_Electronico, Nacionalidad = @Nacionalidad, 
Estatus = @Estatus, Funcion = @Funcion
WHERE IdPersonal = @IdPersonalApoyo
GO

CREATE PROC SP_EditarCalificacion
@IdCalificacion int,
@PrimerPeriodo int,
@SegundoPeriodo int, 
@TercerPeriodo int,
@CuartoPeriodo int,
@CalificacionFinal int,
@AnoEscolar nvarchar(30)
AS
UPDATE Calificacion SET PrimerPeriodo = @PrimerPeriodo, SegundoPeriodo = @SegundoPeriodo, TercerPeriodo = @TercerPeriodo, CuartoPeriodo = @CuartoPeriodo, CalificacionFinal = @CalificacionFinal, AnoEscolar = @AnoEscolar
WHERE IdCalificacion = @IdCalificacion
GO

CREATE PROC SP_EditarInventario
@IdInventario int,
@Nombre nvarchar(30),
@CantidadInicial int,
@CantidadTotal int,
@Provedor nvarchar(30),
@Descripcion nvarchar(50)
AS
UPDATE Inventario SET Nombre = @Nombre, CantidadInicial = @CantidadInicial, CantidadTotal = @CantidadTotal, Provedor = @Provedor, Descripcion = @Descripcion
WHERE IdInventario = @IdInventario
GO