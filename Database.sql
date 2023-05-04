CREATE DATABASE PRIME_CINEMA;
USE PRIME_CINEMA;

CREATE TABLE Usuario (
	id_Usuario INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    usuario VARCHAR(50),
    name_Usuario VARCHAR(60) NOT NULL,
    password_Usuario VARCHAR(50) NOT NULL,
    phone_Usuario VARCHAR(15) NOT NULL,
    document_Usuario VARCHAR(15) NOT NULL,
    email_Usuario VARCHAR(100) NOT NULL,
    id_tipoUsuario INT,
    id_estado INT
);

CREATE TABLE tipo_Ususario(
	id_tipo INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre_User VARCHAR(30) NOT NULL
);

CREATE TABLE Estado(
	id_Estado INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    estado_Usuario VARCHAR(40) NOT NULL
);

CREATE TABLE Registro(
	id_Registro INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    id_Sucursal INT,
    fecha_Registro TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

CREATE TABLE Sucursales
(
	id_Sucursal INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    name_Sucursal VARCHAR(65) NOT NULL,
    gerente_Sucursal VARCHAR(50) NOT NULL,
    direccion_Sucursal VARCHAR(50) NOT NULL,
    phone_Sucursal INT NOT NULL,
    id_Sala INT
);

CREATE TABLE Salas
(
	id_Sala INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    number_Sala INT NOT NULL,
    id_Horario INT NOT NULL,
    id_Pelicula INT NOT NULL
);

CREATE TABLE Horario
(
	id_Horario INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    horario TIME
);	
CREATE TABLE Peliculas 
(
	id_Pelicula INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    name_Pelicula VARCHAR(65) NOT NULL,
    gender_Pelicula VARCHAR(65) NOT NULL,
    clasification_Peli VARCHAR (50) NOT NULL,
    foto LONGBLOB,
    id_formato INT,
    id_horario INT
);

CREATE TABLE Formato
(
	id_Formato INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    formato VARCHAR(50) NOT NULL,
    id_valor INT
);

CREATE TABLE Valor
(
	id_valor INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    persona VARCHAR(60) NOT NULL,
    valor_Funcion DOUBLE NOT NULL
);

-- Insercciones básicas
INSERT INTO Estado (estado_Usuario) VALUES("Activo");
    INSERT INTO Estado (estado_Usuario) VALUES("Inactivo");

    INSERT INTO tipo_Ususario (nombre_User) VALUES("Administrador");
    INSERT INTO tipo_Ususario (nombre_User) VALUES("Cliente");

    INSERT INTO Horario(horario) VALUES("7:00");
    INSERT INTO Horario(horario) VALUES("9:00");
    INSERT INTO Horario(horario) VALUES("11:00");
    INSERT INTO Horario(horario) VALUES("13:00");
    INSERT INTO Horario(horario) VALUES("15:00");
    INSERT INTO Horario(horario) VALUES("17:00");
    INSERT INTO Horario(horario) VALUES("19:00");

    INSERT INTO Formato(formato, id_valor) VALUES("Tradicional Tercera Edad", 1);
    INSERT INTO Formato(formato, id_valor) VALUES("Tradicional Adultos", 2);
    INSERT INTO Formato(formato, id_valor) VALUES("3D Tercera Edad", 3);
    INSERT INTO Formato(formato, id_valor) VALUES("3D Adultos", 4);

    INSERT INTO Valor(persona, valor_Funcion) VALUES("Tercera Edad",3.90);
    INSERT INTO Valor(persona, valor_Funcion) VALUES("Adulto", 5.00);
    INSERT INTO Valor(persona, valor_Funcion) VALUES("Tercera Edad", 5.60);
    INSERT INTO Valor(persona, valor_Funcion) VALUES("Adulto", 6.55);

-- Selecciones
SELECT Usuario.id_Usuario AS ID, Usuario.usuario AS Usuario, Usuario.name_Usuario AS Nombre, Usuario.phone_Usuario AS Teléfono, Usuario.document_Usuario AS DUI, Usuario.email_Usuario AS Correo, tipo_Ususario.nombre_User AS Tipo, Estado.estado_Usuario AS Estado 
FROM Usuario 
INNER JOIN tipo_Ususario ON Usuario.id_estado = tipo_Ususario.id_tipo 
INNER JOIN Estado ON Usuario.id_estado = Estado.id_Estado;

SELECT id_Formato AS ID, formato AS Formato, valor_Funcion AS Valor
FROM Formato F
INNER JOIN Valor V ON F.id_valor = V.id_valor;
SELECT * FROM Formato;

SELECT name_Usuario AS Nombre, password_Usuario AS Contraseña, email_Usuario AS Correo, phone_Usuario AS Telefono, nombre_User AS usuario
FROM Usuario C
INNER JOIN tipo_Ususario TP ON C.id_tipoUsuario = TP.id_tipo
WHERE nombre_User LIKE "%Admin%";

SELECT id_Pelicula AS ID, name_Pelicula AS Película, gender_Pelicula AS Género, clasification_Peli AS Clasificación, formato, horario
FROM Peliculas Pe
INNER JOIN Formato Fo ON Pe.id_formato = Fo.id_Formato
INNER JOIN Horario Ho ON Pe.id_horario = Ho.id_Horario;

SELECT id_Sala AS ID, number_Sala AS Número, horario AS Horario, name_Pelicula AS Película, gender_Pelicula AS Género, clasification_Peli AS Clasificación, formato AS Formato, CONCAT('$ ', ROUND(valor_Funcion, 2)) AS ValorFunción
FROM Salas Sa 
INNER JOIN Horario Ho ON Sa.id_Horario = Ho.id_Horario
INNER JOIN Peliculas Pe ON Sa.id_Pelicula = Pe.id_Pelicula
INNER JOIN Formato Fo ON Pe.id_formato = Fo.id_Formato
INNER JOIN Valor Va ON Fo.id_valor = Va.id_valor;

SELECT name_Sucursal AS Nombre ,gerente_Sucursal AS  Gerente,direccion_Sucursal AS Dirección, phone_Sucursal AS Teléfono, number_Sala AS Número_Sala
FROM Sucursales Su
INNER JOIN Salas Sa ON Su.id_Sala = Sa.id_Sala;

SELECT id_Usuario AS ID, usuario AS Usuario,name_Usuario AS Nombre, nombre_User AS Tipo_Usuario, phone_Usuario AS Teléfono, document_Usuario AS DUI, email_Usuario AS Correo,estado_Usuario AS Estado 
FROM Usuario Us
INNER JOIN tipo_Ususario Tp ON Us.id_tipoUsuario = Tp.id_tipo 
INNER JOIN Estado Es ON Us.id_estado = Es.id_Estado;

