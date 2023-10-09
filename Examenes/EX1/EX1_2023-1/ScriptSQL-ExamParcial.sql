-- Eliminando Tablas
DROP TABLE IF EXISTS sede_programa_academico;
DROP TABLE IF EXISTS sede;
DROP TABLE IF EXISTS tipo_sede;
DROP TABLE IF EXISTS ejecutivo;
DROP TABLE IF EXISTS taller;
DROP TABLE IF EXISTS curso;
DROP TABLE IF EXISTS programa_academico;
DROP TABLE IF EXISTS tipo_programa_academico;
-- Creando Tablas
CREATE TABLE tipo_programa_academico(
	id_tipo_programa_academico CHAR,
    descripcion VARCHAR(70),
    PRIMARY KEY(id_tipo_programa_academico)
)ENGINE=InnoDB;
CREATE TABLE programa_academico(
	id_programa_academico INT AUTO_INCREMENT,
    fid_tipo_programa_academico CHAR,
    clave VARCHAR(6),
    nombre VARCHAR(100),
    activo TINYINT,
    PRIMARY KEY(id_programa_academico),
    FOREIGN KEY (fid_tipo_programa_academico) REFERENCES tipo_programa_academico(id_tipo_programa_academico)
)ENGINE=InnoDB;
CREATE TABLE curso(
	id_curso INT,
    cantidad_creditos INT,
    fecha_inicio DATE,
    PRIMARY KEY (id_curso),
    FOREIGN KEY (id_curso) REFERENCES programa_academico(id_programa_academico)
)ENGINE=InnoDB;
CREATE TABLE taller(
	id_taller INT,
    cantidad_horas INT,
    fecha_realizacion DATE,
    PRIMARY KEY(id_taller),
    FOREIGN KEY (id_taller) REFERENCES programa_academico(id_programa_academico)
)ENGINE=InnoDB;
CREATE TABLE ejecutivo(
	id_ejecutivo INT AUTO_INCREMENT,
    DNI VARCHAR(8) UNIQUE,
    nombre VARCHAR(100),
    apellido_paterno VARCHAR(100),
    activo TINYINT,
    PRIMARY KEY(id_ejecutivo)
)ENGINE=InnoDB;
CREATE TABLE tipo_sede(
	id_tipo_sede INT AUTO_INCREMENT,
    nombre VARCHAR(100),
    activo TINYINT,
    PRIMARY KEY(id_tipo_sede)
)ENGINE=InnoDB;
CREATE TABLE sede(
	id_sede INT AUTO_INCREMENT,
    fid_tipo_sede INT,
    fid_ejecutivo_responsable INT,
    nombre VARCHAR(150),
    direccion VARCHAR(300),
    fecha_inauguracion DATETIME,
    cantidad_aulas INT,
    aforo_total INT,
    foto LONGBLOB,
    tiene_auditorio TINYINT,
    tiene_biblioteca TINYINT,
    tiene_estacionamiento TINYINT,
    tiene_salas_estudio TINYINT,
    tiene_cafeteria TINYINT,
    activo INT,
    FOREIGN KEY(fid_tipo_sede) REFERENCES tipo_sede(id_tipo_sede),
    FOREIGN KEY(fid_ejecutivo_responsable) REFERENCES ejecutivo(id_ejecutivo),
    PRIMARY KEY(id_sede)
)ENGINE=InnoDB;
CREATE TABLE sede_programa_academico(
	id_sede_programa_academico INT AUTO_INCREMENT,
    fid_sede INT,
    fid_programa_academico INT,
    activo TINYINT,
    PRIMARY KEY(id_sede_programa_academico),
    FOREIGN KEY(fid_sede) REFERENCES sede(id_sede),
    FOREIGN KEY(fid_programa_academico) REFERENCES programa_academico(id_programa_academico)
)ENGINE=InnoDB;
-- Insertando registros
INSERT INTO tipo_programa_academico(id_tipo_programa_academico,descripcion) VALUES('C','CURSO');
INSERT INTO tipo_programa_academico(id_tipo_programa_academico,descripcion) VALUES('T','TALLER');
INSERT INTO tipo_sede(nombre,activo) VALUES('CAMPUS UNIVERSITARIO',1);
INSERT INTO tipo_sede(nombre,activo) VALUES('EDIFICIO ÚNICO',1);
INSERT INTO tipo_sede(nombre,activo) VALUES('CENTRO DE INNOVACIÓN',1);
INSERT INTO tipo_sede(nombre,activo) VALUES('COMPLEJO DE CIENCIA Y TECNOLOGÍA',1);
INSERT INTO tipo_sede(nombre,activo) VALUES('CENTRO CULTURAL',1);
INSERT INTO ejecutivo(DNI,nombre,apellido_paterno,activo) VALUES('73699283','PATRICIA','ARMENDARIZ',1);
INSERT INTO ejecutivo(DNI,nombre,apellido_paterno,activo) VALUES('32870015','CARLOS','BREMER',1);
INSERT INTO ejecutivo(DNI,nombre,apellido_paterno,activo) VALUES('17063983','RODRIGO','HERRERA',1);
INSERT INTO ejecutivo(DNI,nombre,apellido_paterno,activo) VALUES('17383206','MARCUS','DANTUS',1);
-- Procedimientos Almacenados
DROP PROCEDURE IF EXISTS INSERTAR_CURSO;
DROP PROCEDURE IF EXISTS INSERTAR_TALLER;
-- Creacion de Procedimientos Almacenados
DELIMITER $
CREATE PROCEDURE INSERTAR_CURSO(
	OUT _id_curso INT,
    IN _clave VARCHAR(6),
    IN _nombre VARCHAR(100),
    IN _cantidad_creditos INT,
    IN _fecha_inicio DATE
)
BEGIN
	INSERT INTO programa_academico(fid_tipo_programa_academico,clave,nombre,activo) VALUES('C',_clave,_nombre,1);
    SET _id_curso = @@last_insert_id;
    INSERT INTO curso(id_curso,cantidad_creditos,fecha_inicio) VALUES(_id_curso,_cantidad_creditos,_fecha_inicio);
END$
CREATE PROCEDURE INSERTAR_TALLER(
	OUT _id_taller INT,
    IN _clave VARCHAR(6),
    IN _nombre VARCHAR(100),
    IN _cantidad_horas INT,
    IN _fecha_realizacion DATE
)
BEGIN
	INSERT INTO programa_academico(fid_tipo_programa_academico,clave,nombre,activo) VALUES('T',_clave,_nombre,1);
    SET _id_taller = @@last_insert_id;
    INSERT INTO taller(id_taller,cantidad_horas,fecha_realizacion) VALUES(_id_taller,_cantidad_horas,_fecha_realizacion);
END$
-- Insertando registros
DELIMITER ;
CALL INSERTAR_CURSO(@id_curso1,'INF282','LENGUAJE DE PROGRAMACIÓN 2',5,'2023-07-10');
CALL INSERTAR_CURSO(@id_curso2,'INF239','SISTEMAS OPERATIVOS',4,'2023-06-05');
CALL INSERTAR_CURSO(@id_curso3,'IND273','INVESTIGACIÓN OPERATIVA 1',4,'2023-05-22');
CALL INSERTAR_TALLER(@id_taller1,'TAL001','TRABAJO ÉTICO EN INTERACCIÓN HUMANO-COMPUTADOR',4,'2023-06-27');
CALL INSERTAR_TALLER(@id_taller2,'TAL002','EYE TRACKING: APLICACIONES Y ANALÍTICA',4,'2023-07-24');
CALL INSERTAR_TALLER(@id_taller3,'TAL003','DISEÑO DE SISTEMAS PARA UNA MEJOR UX',4,'2023-05-27');
-- Creando procedimientos almacenados a utilizar en el examen parcial
DROP PROCEDURE IF EXISTS LISTAR_TIPOS_SEDE_TODOS;
DROP PROCEDURE IF EXISTS LISTAR_EJECUTIVOS_X_NOMBRE_DNI;
DROP PROCEDURE IF EXISTS LISTAR_PROGRAMAS_ACADEMICOS_X_NOMBRE_CLAVE;
DROP PROCEDURE IF EXISTS INSERTAR_SEDE;
DROP PROCEDURE IF EXISTS INSERTAR_SEDE_PROGRAMA_ACADEMICO;
DROP PROCEDURE IF EXISTS LISTAR_SEDES_X_NOMBRE;
DROP PROCEDURE IF EXISTS LISTAR_PROGRAMAS_ACADEMICOS_X_ID_SEDE;
DELIMITER $
CREATE PROCEDURE LISTAR_TIPOS_SEDE_TODOS()
BEGIN
	SELECT id_tipo_sede, nombre FROM tipo_sede WHERE activo = 1;
END$
CREATE PROCEDURE LISTAR_EJECUTIVOS_X_NOMBRE_DNI(
	IN _nombre_DNI VARCHAR(200)
)
BEGIN
	SELECT e.id_ejecutivo, e.DNI, e.nombre, e.apellido_paterno FROM ejecutivo e where e.activo = 1 AND (e.DNI LIKE CONCAT('%',_nombre_DNI,'%') OR CONCAT(e.nombre,' ',e.apellido_paterno) LIKE CONCAT('%',_nombre_DNI,'%'));
END$
CREATE PROCEDURE LISTAR_PROGRAMAS_ACADEMICOS_X_NOMBRE_CLAVE(
	IN _nombre_clave VARCHAR(100)
)
BEGIN
	SELECT pa.id_programa_academico, pa.fid_tipo_programa_academico, pa.clave, pa.nombre, c.cantidad_creditos, c.fecha_inicio, t.cantidad_horas, t.fecha_realizacion FROM programa_academico pa LEFT JOIN curso c ON c.id_curso = pa.id_programa_academico LEFT JOIN taller t ON pa.id_programa_academico = t.id_taller WHERE (pa.nombre LIKE CONCAT('%',_nombre_clave,'%') OR pa.clave LIKE CONCAT('%',_nombre_clave,'%')) and pa.activo = 1;
END$
CREATE PROCEDURE INSERTAR_SEDE(
	OUT _id_sede INT,
    IN _fid_tipo_sede INT,
    IN _fid_ejecutivo_responsable INT,
    IN _nombre VARCHAR(150),
    IN _direccion VARCHAR(300),
    IN _fecha_inauguracion DATETIME,
    IN _cantidad_aulas INT,
    IN _aforo_total INT,
    IN _foto LONGBLOB,
    IN _tiene_auditorio TINYINT,
    IN _tiene_biblioteca TINYINT,
    IN _tiene_estacionamiento TINYINT,
    IN _tiene_salas_estudio TINYINT,
    IN _tiene_cafeteria TINYINT
)
BEGIN
	INSERT INTO sede(fid_tipo_sede,fid_ejecutivo_responsable,nombre,direccion,fecha_inauguracion,cantidad_aulas,aforo_total,foto,tiene_auditorio,tiene_biblioteca,tiene_estacionamiento,tiene_salas_estudio,tiene_cafeteria,activo) VALUES(_fid_tipo_sede,_fid_ejecutivo_responsable,_nombre,_direccion,_fecha_inauguracion,_cantidad_aulas,_aforo_total,_foto,_tiene_auditorio,_tiene_biblioteca,_tiene_estacionamiento,_tiene_salas_estudio,_tiene_cafeteria,1);
    SET _id_sede = @@last_insert_id;
END$
CREATE PROCEDURE INSERTAR_SEDE_PROGRAMA_ACADEMICO(
	OUT _id_sede_programa_academico INT,
    IN _fid_sede INT,
    IN _fid_programa_academico INT
)
BEGIN
	INSERT INTO sede_programa_academico(fid_sede,fid_programa_academico, activo) VALUES(_fid_sede,_fid_programa_academico, 1);
    SET _id_sede_programa_academico = @@last_insert_id;
END$
CREATE PROCEDURE LISTAR_SEDES_X_NOMBRE(
	_nombre VARCHAR(150)
)
BEGIN
	SELECT s.id_sede, tp.id_tipo_sede, tp.nombre as nombre_tipo_sede, s.nombre as nombre_sede, s.direccion, s.fecha_inauguracion, s.cantidad_aulas, s.aforo_total, s.foto, s.tiene_auditorio, s.tiene_biblioteca, s.tiene_estacionamiento, s.tiene_salas_estudio, s.tiene_cafeteria, e.id_ejecutivo, e.DNI, e.nombre as nombre_ejecutivo, e.apellido_paterno FROM sede s INNER JOIN tipo_sede tp ON s.fid_tipo_sede = tp.id_tipo_sede INNER JOIN ejecutivo e ON e.id_ejecutivo = s.fid_ejecutivo_responsable WHERE s.activo = 1 AND s.nombre LIKE CONCAT('%',_nombre,'%');
END$
CREATE PROCEDURE LISTAR_PROGRAMAS_ACADEMICOS_X_ID_SEDE(
	IN _id_sede INT
)
BEGIN
	SELECT pa.id_programa_academico, pa.fid_tipo_programa_academico, pa.clave, pa.nombre, c.cantidad_creditos, c.fecha_inicio, t.cantidad_horas, t.fecha_realizacion FROM programa_academico pa LEFT JOIN curso c ON c.id_curso = pa.id_programa_academico LEFT JOIN taller t ON pa.id_programa_academico = t.id_taller INNER JOIN sede_programa_academico spa ON pa.id_programa_academico = spa.fid_programa_academico WHERE spa.fid_sede = _id_sede;
END$