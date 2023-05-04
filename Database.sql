CREATE DATABASE PRIME_CINEMA;
USE PRIME_CINEMA;

DROP DATABASE PRIME_CINEMA;

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
SELECT * FROM Usuario;
SELECT * FROM tipo_Ususario;

SELECT id_Usuario AS ID, usuario AS Usuario,name_Usuario AS Nombre, nombre_User AS Tipo_Usuario, phone_Usuario AS Teléfono, document_Usuario AS DUI, email_Usuario AS Correo,estado_Usuario AS Estado 
FROM Usuario Us
INNER JOIN tipo_Ususario Tp ON Us.id_tipoUsuario = Tp.id_tipo 
INNER JOIN Estado Es ON Us.id_estado = Es.id_Estado;

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
INSERT INTO Sucursales (name_Sucursal,direccion_Sucursal,gerente_Sucursal,phone_Sucursal,id_Sala) VALUES();

SELECT name_Sucursal AS Nombre ,gerente_Sucursal AS  Gerente,direccion_Sucursal AS Dirección, phone_Sucursal AS Teléfono, number_Sala AS Número_Sala
FROM Sucursales Su
INNER JOIN Salas Sa ON Su.id_Sala = Sa.id_Sala;

SELECT * FROM Valor;

SELECT id_Sala AS ID, number_Sala AS Número, horario AS Horario, name_Pelicula AS Película, gender_Pelicula AS Género, clasification_Peli AS Clasificación, formato AS Formato, CONCAT('$ ', ROUND(valor_Funcion, 2)) AS ValorFunción
FROM Salas Sa 
INNER JOIN Horario Ho ON Sa.id_Horario = Ho.id_Horario
INNER JOIN Peliculas Pe ON Sa.id_Pelicula = Pe.id_Pelicula
INNER JOIN Formato Fo ON Pe.id_formato = Fo.id_Formato
INNER JOIN Valor Va ON Fo.id_valor = Va.id_valor;

CREATE TABLE Salas
(
	id_Sala INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    number_Sala INT NOT NULL,
    id_Horario INT NOT NULL,
    id_Pelicula INT NOT NULL
);
INSERT INTO Salas (number_Sala,id_Horario,id_Pelicula) VALUES(1,1,1);
INSERT INTO Salas (number_Sala,id_Horario,id_Pelicula) VALUES(2,3,2);

SELECT id_Sala AS ID, number_Sala AS Sala, horario, name_Pelicula AS Pelicula, gender_Pelicula AS Género, clasification_Peli AS Clasificación
FROM Salas S
INNER JOIN Horario H ON S.id_Horario = H.id_Horario INNER JOIN Peliculas P ON S.id_Pelicula = P.id_Pelicula;

CREATE TABLE Horario
(
	id_Horario INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    horario TIME
);	
SELECT * FROM Formato;
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
SELECT * FROM Peliculas;
INSERT INTO Peliculas (name_Pelicula, gender_Pelicula, clasification_Peli, id_formato, id_horario) 
	VALUES("Rambo","Acción","Adultos",2,2);
INSERT INTO Peliculas (name_Pelicula, gender_Pelicula, clasification_Peli, id_formato, id_horario) 
	VALUES("Cars","Familiar","Infantil",2,1);
    
SELECT id_Pelicula AS ID, name_Pelicula AS Película, gender_Pelicula AS Género, clasification_Peli AS Clasificación, formato, horario
FROM Peliculas Pe
INNER JOIN Formato Fo ON Pe.id_formato = Fo.id_Formato
INNER JOIN Horario Ho ON Pe.id_horario = Ho.id_Horario;
    
SELECT id_Pelicula AS ID,name_Pelicula AS Nombre, gender_Pelicula AS Género, clasification_Peli AS Clasificación, formato, horario
FROM Peliculas P
INNER JOIN Formato F ON p.id_formato = F.id_Formato INNER JOIN Horario H ON P.id_horario = H.id_Horario
UNION
SELECT valor_Funcion AS Valor
FROM Formato F
INNER JOIN Valor V ON F.id_valor = V.id_valor;

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

SELECT id_Formato AS ID, formato AS Formato, valor_Funcion AS Valor
FROM Formato F
INNER JOIN Valor V ON F.id_valor = V.id_valor;
SELECT * FROM Formato;

-- Selecciones
SELECT Usuario.id_Usuario AS ID, Usuario.usuario AS Usuario, Usuario.name_Usuario AS Nombre, Usuario.phone_Usuario AS Teléfono, Usuario.document_Usuario AS DUI, Usuario.email_Usuario AS Correo, tipo_Ususario.nombre_User AS Tipo, Estado.estado_Usuario AS Estado 
FROM Usuario 
INNER JOIN tipo_Ususario ON Usuario.id_estado = tipo_Ususario.id_tipo 
INNER JOIN Estado ON Usuario.id_estado = Estado.id_Estado;

SELECT nombre_User AS usuario, password_Usuario AS Contraseñas
FROM Usuario C
INNER JOIN tipo_Ususario TP ON C.id_tipoUsuario = TP.id_tipo
WHERE nombre_User LIKE "%Admin%";

SELECT * FROM Usuario;

SELECT name_Usuario AS Nombre, password_Usuario AS Contraseña, email_Usuario AS Correo, phone_Usuario AS Telefono, nombre_User AS usuario
FROM Usuario C
INNER JOIN tipo_Ususario TP ON C.id_tipoUsuario = TP.id_tipo
WHERE nombre_User LIKE "%Admin%";

SELECT User_Administrado AS Usuario, password_Admin AS Contraseña FROM Administrador;

SELECT id_Pelicula AS ID, name_Pelicula AS Nombre, gender_Pelicula AS Género, clasification_Peli AS Clasificación, type_Pelicula AS Formato FROM Peliculas;

ALTER TABLE Usuario ADD FOREIGN KEY (id_tipoUsuario) REFERENCES tipo_Ususario(id_tipo) ON DELETE RESTRICT ON UPDATE RESTRICT;
ALTER TABLE Usuario ADD FOREIGN KEY (id_estado) REFERENCES Estado(id_Estado) ON DELETE RESTRICT ON UPDATE RESTRICT;

INSERT INTO Peliculas (name_Pelicula, gender_Pelicula, clasification_Peli, type_Pelicula)
	VALUES("Rambo", "Acción", "Adultos", "2D");
INSERT INTO Usuario(usuario, name_Usuario, password_Usuario, phone_Usuario, document_Usuario, email_Usuario, id_tipoUsuario, id_estado) 
	VALUES();    

