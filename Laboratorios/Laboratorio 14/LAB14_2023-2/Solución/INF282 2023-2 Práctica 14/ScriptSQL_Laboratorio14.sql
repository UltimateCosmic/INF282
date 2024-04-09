DROP TABLE IF EXISTS evento;
DROP TABLE IF EXISTS artista;
DROP TABLE IF EXISTS establecimiento;
CREATE TABLE establecimiento(
	id_establecimiento INT AUTO_INCREMENT,
    nombre_establecimiento VARCHAR(300),
    capacidad_asientos INT,
    tiene_estacionamiento TINYINT,
    activo TINYINT,
    PRIMARY KEY(id_establecimiento)
)ENGINE=innodb;
CREATE TABLE artista(
	id_artista INT AUTO_INCREMENT,
    nombre_artista VARCHAR(300),
    nacionalidad_artista VARCHAR(300),
    PRIMARY KEY(id_artista)
)ENGINE=innodb;
CREATE TABLE evento(
	id_evento INT AUTO_INCREMENT,
    fid_establecimiento INT,
    fid_artista INT,
    nombre_evento VARCHAR(300),
    tipo_evento ENUM('CONCIERTO', 'TEATRO'),
    fecha_evento DATE,
    hora_evento TIME,
    costo_realizacion DECIMAL(14,2),
    cantidad_entradas_disponibles INT,
    descripcion_evento VARCHAR(3000),
    foto LONGBLOB,
    activo TINYINT,
    PRIMARY KEY(id_evento),
    FOREIGN KEY(fid_establecimiento) REFERENCES establecimiento(id_establecimiento),
    FOREIGN KEY(fid_artista) REFERENCES artista(id_artista)
)ENGINE=innodb;
-- Insertando los registros
INSERT INTO establecimiento(nombre_establecimiento,capacidad_asientos,tiene_estacionamiento,activo) VALUES('GRAN TEATRO NACIONAL DEL PERU',1500,1,1);
INSERT INTO establecimiento(nombre_establecimiento,capacidad_asientos,tiene_estacionamiento,activo) VALUES('ESTADIO NACIONAL DEL PERU',53000,1,1);
INSERT INTO establecimiento(nombre_establecimiento,capacidad_asientos,tiene_estacionamiento,activo) VALUES('TEATRO PIRANDELLO',700,0,1);
INSERT INTO establecimiento(nombre_establecimiento,capacidad_asientos,tiene_estacionamiento,activo) VALUES('TEATRO CANOUT',500,0,1);
INSERT INTO establecimiento(nombre_establecimiento,capacidad_asientos,tiene_estacionamiento,activo) VALUES('TEATRO BRITANICO',260,0,1);
INSERT INTO establecimiento(nombre_establecimiento,capacidad_asientos,tiene_estacionamiento,activo) VALUES('TEATRO PERUANO JAPONES',1025,0,1);
INSERT INTO establecimiento(nombre_establecimiento,capacidad_asientos,tiene_estacionamiento,activo) VALUES('TEATRO MARSANO',500,0,1);
INSERT INTO artista(nombre_artista,nacionalidad_artista) VALUES('WENDY RAMOS','PERUANA');
INSERT INTO artista(nombre_artista,nacionalidad_artista) VALUES('MAR DE COPAS','PERUANA');
INSERT INTO artista(nombre_artista,nacionalidad_artista) VALUES('GIANMARCO','PERUANA');
INSERT INTO artista(nombre_artista,nacionalidad_artista) VALUES('MANA','MEXICANA');
INSERT INTO artista(nombre_artista,nacionalidad_artista) VALUES('THE ROLLING STONES','BRITANICA');
INSERT INTO artista(nombre_artista,nacionalidad_artista) VALUES('TAYLOR SWIFT','ESTADOUNIDENSE');
INSERT INTO artista(nombre_artista,nacionalidad_artista) VALUES('ADELE','BRITANICA');
INSERT INTO artista(nombre_artista,nacionalidad_artista) VALUES('LANA DEL REY','ESTADOUNIDENSE');
INSERT INTO artista(nombre_artista,nacionalidad_artista) VALUES('LAURA PAUSINI','ITALIANA');
INSERT INTO artista(nombre_artista,nacionalidad_artista) VALUES('THE CURE','BRITANICA');
INSERT INTO artista(nombre_artista,nacionalidad_artista) VALUES('MAROON 5','ESTADOUNIDENSE');
INSERT INTO artista(nombre_artista,nacionalidad_artista) VALUES('JOHANNA SAN MIGUEL','PERUANA');
-- Creación de Procedimientos Almacenados
DROP PROCEDURE IF EXISTS LISTAR_ARTISTAS_X_NOMBRE;
DROP PROCEDURE IF EXISTS LISTAR_ESTABLECIMIENTOS_X_NOMBRE;
DROP PROCEDURE IF EXISTS INSERTAR_EVENTO;
DROP PROCEDURE IF EXISTS LISTAR_EVENTOS_X_NOMBRE;
DELIMITER $
CREATE PROCEDURE LISTAR_ARTISTAS_X_NOMBRE(
	_nombre VARCHAR(300)
)
BEGIN
	SELECT id_artista, nombre_artista, nacionalidad_artista FROM artista WHERE nombre_artista LIKE CONCAT('%',_nombre,'%');
END$
CREATE PROCEDURE LISTAR_ESTABLECIMIENTOS_X_NOMBRE(
	_nombre VARCHAR(300)
)
BEGIN
	SELECT id_establecimiento, nombre_establecimiento, capacidad_asientos, tiene_estacionamiento FROM establecimiento WHERE activo = 1 AND nombre_establecimiento LIKE CONCAT('%',_nombre,'%');
END$
CREATE PROCEDURE INSERTAR_EVENTO(
	OUT _id_evento INT,
    IN _fid_establecimiento INT,
    IN _fid_artista INT,
    IN _nombre_evento VARCHAR(300),
    IN _tipo_evento enum('CONCIERTO','TEATRO'),
    IN _fecha_evento DATE,
    IN _hora_evento TIME,
    IN _costo_realizacion DECIMAL(14,2),
    IN _cantidad_entradas_disponibles INT,
    IN _descripcion_evento VARCHAR(3000),
    IN _foto LONGBLOB
)
BEGIN
	INSERT INTO evento(fid_establecimiento,fid_artista,nombre_evento,tipo_evento,fecha_evento,hora_evento,costo_realizacion,cantidad_entradas_disponibles,descripcion_evento,foto,activo) VALUES(_fid_establecimiento,_fid_artista,_nombre_evento,_tipo_evento,_fecha_evento,_hora_evento,_costo_realizacion,_cantidad_entradas_disponibles,_descripcion_evento,_foto,1);
    SET _id_evento = @@last_insert_id;
END$
DELIMITER $
CREATE PROCEDURE LISTAR_EVENTOS_X_NOMBRE(
	IN _nombre VARCHAR(300)
)
BEGIN
	SELECT ev.id_evento, est.id_establecimiento, est.nombre_establecimiento, est.capacidad_asientos, est.tiene_estacionamiento, art.id_artista, art.nombre_artista, art.nacionalidad_artista, ev.nombre_evento, ev.tipo_evento, ev.fecha_evento, ev.hora_evento, ev.costo_realizacion, ev.cantidad_entradas_disponibles, ev.descripcion_evento, ev.foto FROM evento ev INNER JOIN establecimiento est ON ev.fid_establecimiento = est.id_establecimiento INNER JOIN artista art ON art.id_artista = ev.fid_artista WHERE ev.activo = 1 and ev.nombre_evento LIKE CONCAT('%',_nombre,'%'); 
END$