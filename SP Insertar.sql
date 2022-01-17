CREATE PROC SP_InsertarAdministrativo
@IdAdministrativo int output,
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
INSERT INTO Administrativo (Nombre, Apellido, Telefono, Direccion, Cedula, Genero, 
Condicion_Medica, Fecha_Nacimiento, Fecha_Ingreso, Correo_Electronico, Nacionalidad, 
Titulo, Estatus, Funcion)
VALUES
(@Nombre, @Apellido, @Telefono, @Direccion, @Cedula, @Genero, @Condicion_Medica, 
@Fecha_Nacimiento, @Fecha_Ingreso, @Correo_Electronico, @Nacionalidad, @Titulo, @Estatus,
 @Funcion)
GO

 CREATE PROC SP_InsertarCursos
@IdCursos int output,
@Nombre nvarchar(30)
AS
INSERT INTO Cursos(Nombre)
VALUES
(@Nombre)
GO

CREATE PROC SP_InsertarProfesor
@IdProfesor int output,
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
INSERT INTO Profesor(Nombre, Apellido, Telefono, Direccion, Cedula, Genero, 
Condicion_Medica, Fecha_Nacimiento, Fecha_Ingreso, Correo_Electronico, Nacionalidad, 
Titulo, Estatus)
VALUES
(@Nombre, @Apellido, @Telefono, @Direccion, @Cedula, @Genero, @Condicion_Medica, 
@Fecha_Nacimiento, @Fecha_Ingreso, @Correo_Electronico, @Nacionalidad, @Titulo, @Estatus)
GO

CREATE PROC SP_InsertarAreas
@IdAreas int output,
@Nombre nvarchar(30)
AS
INSERT INTO Cursos(Nombre)
VALUES
(@Nombre)
GO

CREATE PROC SP_InsertarAsignatura
@IdAsignatura int output,
@Nombre nvarchar(30),
@Descripcion nvarchar(50)
AS
INSERT INTO Asignatura(Nombre, Descripcion)
VALUES
(@Nombre, @Descripcion)
GO

CREATE PROC SP_InsertarEstudiante
@IdEstudiante int output,
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
INSERT INTO Estudiante(Nombre, Apellido, Telefono, Direccion, Cedula, Genero, 
Condicion_Medica, Fecha_Nacimiento, Fecha_Ingreso, Correo_Electronico, Nacionalidad, Estatus, AñoEscolar)
VALUES
(@Nombre, @Apellido, @Telefono, @Direccion, @Cedula, @Genero, @Condicion_Medica, 
@Fecha_Nacimiento, @Fecha_Ingreso, @Correo_Electronico, @Nacionalidad, @Estatus, @AñoEscolar)
GO

CREATE PROC SP_InsertarPersonalApoyo
@IdPersonal int output,
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
INSERT INTO PersonalApoyo(Nombre, Apellido, Telefono, Direccion, Cedula, Genero, 
Condicion_Medica, Fecha_Nacimiento, Fecha_Ingreso, Correo_Electronico, Nacionalidad, Estatus, Funcion)
VALUES
(@Nombre, @Apellido, @Telefono, @Direccion, @Cedula, @Genero, @Condicion_Medica, 
@Fecha_Nacimiento, @Fecha_Ingreso, @Correo_Electronico, @Nacionalidad, @Estatus, @Funcion)
GO

CREATE PROC SP_InsertarCalificacion
@IdCalificacion int output,
@PrimerPeriodo int,
@SegundoPeriodo int, 
@TercerPeriodo int,
@CuartoPeriodo int,
@CalificacionFinal int,
@AnoEscolar nvarchar(30)
AS
INSERT INTO Calificacion(PrimerPeriodo, SegundoPeriodo, TercerPeriodo, CuartoPeriodo, CalificacionFinal, AnoEscolar)
VALUES
(@PrimerPeriodo, @SegundoPeriodo, @TercerPeriodo, @CuartoPeriodo, @CalificacionFinal, @AnoEscolar)
GO

CREATE PROC SP_InsertarInventario
@IdInventario int output,
@Nombre nvarchar(30),
@CantidadInicial int,
@CantidadTotal int,
@Provedor nvarchar(30),
@Descripcion nvarchar(50)
AS
INSERT INTO Inventario(Nombre, CantidadInicial, CantidadTotal, Provedor, Descripcion)
VALUES
(@Nombre, @CantidadInicial, @CantidadTotal, @Provedor, @Descripcion)
GO