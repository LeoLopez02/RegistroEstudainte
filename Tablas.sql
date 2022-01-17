CREATE TABLE Cursos (
IdCurso int primary key identity(1,1),
Nombre nvarchar(30) not null
)

CREATE TABLE Profesor (
IdProfesor int primary key identity(1,1),
Nombre nvarchar(30) not null,
Apellido nvarchar(30) not null,
Telefono nvarchar(12) not null,
Direccion nvarchar(100) not null,
Cedula nvarchar(13) not null,
Genero nvarchar(1) not null,
Condicion_Medica nvarchar(30) null,
Fecha_Nacimiento datetime,
Fecha_Ingreso datetime,
Correo_Electronico nvarchar(30) not null,
Nacionalidad nvarchar(30) not null,
Titulo nvarchar(30) null,
Estatus nvarchar(30) null,
--Relaciones
IdCurso int foreign key references Cursos(IdCurso) not null
)

CREATE TABLE Areas (
IdAreas int primary key identity(1,1),
Nombre nvarchar(30) not null,
--Relaciones
IdCurso int foreign key references Cursos(IdCurso) not null
)

CREATE TABLE Asignatura (
IdAsignatura int primary key identity(1,1),
Nombre nvarchar(30) not null,
Descripcion nvarchar(50) null,
-- Relaciones
IdProfesor int foreign key references Profesor(IdProfesor) not null,
IdCurso int foreign key references Cursos(IdCurso) not null
)

CREATE TABLE Estudiante (
IdEstudiante int primary key identity(1,1),
Nombre nvarchar(30) not null,
Apellido nvarchar(30) not null,
Telefono nvarchar(12)  null,
Direccion nvarchar(50)  null,
Cedula nvarchar(13) null, 
Genero nvarchar(1) not null,
Condicion_Medica nvarchar(50) null,
Fecha_Nacimiento datetime not null,
Fecha_Ingreso datetime not null,
Correo_Electronico nvarchar(30) null,
Nacionalidad nvarchar(50) not null,
Estatus nvarchar(30) not null,
AñoEscolar nvarchar(30),
--Relaciones
IdCurso int foreign key references Cursos(IdCurso) not null,
IdAreas int foreign key references Areas(IdAreas) not null,
IdAsignatura int foreign key references Asignatura(IdAsignatura) not null,
IdProfesor int foreign key references Profesor(IdProfesor) not null
)


-- TABLAS SIN RELACIONES

CREATE TABLE PersonalApoyo (
IdPersonal int identity(1,1) primary key,
Nombre nvarchar(30) not null,
Apellido nvarchar(30) not null,
Telefono nvarchar(12)  null,
Direccion nvarchar(50)  null,
Cedula nvarchar(13) null, 
Genero nvarchar(1) not null,
Condicion_Medica nvarchar(50) null,
Fecha_Nacimiento datetime not null,
Fecha_Ingreso datetime not null,
Correo_Electronico nvarchar(30) null,
Nacionalidad nvarchar(50) not null,
Estatus nvarchar(30) not null,
Funcion nvarchar(30) not null
)

CREATE TABLE Administrativo (
IdAdministrativo int identity(1,1) primary key,
Nombre nvarchar(30) not null,
Apellido nvarchar(30) not null,
Telefono nvarchar(12)  null,
Direccion nvarchar(50)  null,
Cedula nvarchar(13) null, 
Genero nvarchar(1) not null,
Condicion_Medica nvarchar(50) null,
Fecha_Nacimiento datetime not null,
Fecha_Ingreso datetime not null,
Correo_Electronico nvarchar(30) null,
Nacionalidad nvarchar(50) not null,
Titulo nvarchar(30) null,
Estatus nvarchar(30) not null,
Funcion nvarchar(30) not null
)

CREATE TABLE Calificacion (
IdCalificacion int identity(1,1) primary key,
IdAsignatura int foreign key references Asignatura(IdAsignatura) not null,
PrimerPeriodo int,
SegundoPeriodo int, 
TercerPeriodo int,
CuartoPeriodo int,
CalificacionFinal int,
AnoEscolar nvarchar(30)
)

CREATE TABLE Inventario (
IdInventario int identity(1,1) primary key,
Nombre nvarchar(30) not null,
CantidadInicial int,
CantidadTotal int,
Provedor nvarchar(30) not null,
Descripcion nvarchar(50) not null
)

