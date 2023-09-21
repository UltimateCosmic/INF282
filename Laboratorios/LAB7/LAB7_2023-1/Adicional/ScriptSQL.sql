-- Eliminando Tablas
DROP TABLE IF EXISTS local;
DROP TABLE IF EXISTS estilo_arquitectonico;
-- Creando Tablas
CREATE TABLE estilo_arquitectonico(
	id_estilo_arquitectonico INT AUTO_INCREMENT,
    nombre VARCHAR(200),
    activo TINYINT,
    PRIMARY KEY(id_estilo_arquitectonico)
)ENGINE=InnoDB;
CREATE TABLE local(
	id_local INT AUTO_INCREMENT,
    fid_estilo_arquitectonico INT,
    nombre VARCHAR(200),
    direccion VARCHAR(500),
    fecha_construccion DATE,
    aforo INT,
    tiene_palco TINYINT,
    tiene_proyector TINYINT,
    tiene_vestibulo TINYINT,
    resenha VARCHAR(3000),
    foto LONGBLOB,
    plano LONGBLOB,
    activo TINYINT,
    PRIMARY KEY(id_local),
    FOREIGN KEY(fid_estilo_arquitectonico) REFERENCES estilo_arquitectonico(id_estilo_arquitectonico)
)ENGINE=InnoDB;
-- Creando registros
INSERT INTO estilo_arquitectonico(nombre,activo) VALUES('ESTILO CLASICO',1);
INSERT INTO estilo_arquitectonico(nombre,activo) VALUES('ESTILO RENACENTISTA',1);
INSERT INTO estilo_arquitectonico(nombre,activo) VALUES('ESTILO BARROCO',1);
INSERT INTO estilo_arquitectonico(nombre,activo) VALUES('ESTILO ROCOCÓ',1);
INSERT INTO estilo_arquitectonico(nombre,activo) VALUES('ESTILO ART NOUVEAU',1);
INSERT INTO estilo_arquitectonico(nombre,activo) VALUES('ESTILO MODERNO',1);
INSERT INTO estilo_arquitectonico(nombre,activo) VALUES('ESTILO POST-MODERNO',1);
-- Eliminando Procedimientos Almacenados
DROP PROCEDURE IF EXISTS LISTAR_ESTILOS_ARQUITECTONICOS_TODOS;
DROP PROCEDURE IF EXISTS INSERTAR_LOCAL;
DROP PROCEDURE IF EXISTS LISTAR_LOCALES_X_NOMBRE;
-- Creando Procedimientos Almacenados
DELIMITER $
CREATE PROCEDURE LISTAR_ESTILOS_ARQUITECTONICOS_TODOS()
BEGIN
	SELECT id_estilo_arquitectonico, nombre, activo FROM estilo_arquitectonico WHERE activo = 1;
END$
CREATE PROCEDURE INSERTAR_LOCAL(
	OUT _id_local INT,
    IN _fid_estilo_arquitectonico INT,
    IN _nombre VARCHAR(200),
    IN _direccion VARCHAR(500),
    IN _fecha_construccion DATE,
    IN _aforo INT,
    IN _tiene_palco TINYINT,
    IN _tiene_proyector TINYINT,
    IN _tiene_vestibulo TINYINT,
    IN _resenha VARCHAR(3000),
    IN _foto LONGBLOB,
    IN _plano LONGBLOB
)
BEGIN
	INSERT INTO local(fid_estilo_arquitectonico,nombre,direccion,fecha_construccion,aforo,tiene_palco,tiene_proyector,tiene_vestibulo,resenha,foto,plano,activo) VALUES(_fid_estilo_arquitectonico,_nombre,_direccion,_fecha_construccion,_aforo,_tiene_palco,_tiene_proyector,_tiene_vestibulo,_resenha,_foto,_plano,1);
    SET _id_local = @@last_insert_id;
END$
CREATE PROCEDURE LISTAR_LOCALES_X_NOMBRE(
	IN _nombre VARCHAR(200)
)
BEGIN
	SELECT l.id_local, e.id_estilo_arquitectonico, l.nombre as nombre_local, l.direccion, l.fecha_construccion, l.aforo, l.tiene_palco, l.tiene_proyector, l.tiene_vestibulo, l.resenha, l.foto, l.plano, e.nombre as nombre_estilo_arquitectonico FROM local l INNER JOIN estilo_arquitectonico e ON l.fid_estilo_arquitectonico = e.id_estilo_arquitectonico WHERE l.activo = 1 AND l.nombre LIKE CONCAT('%',_nombre,'%'); 
END$