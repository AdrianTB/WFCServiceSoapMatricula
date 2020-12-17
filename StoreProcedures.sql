
/******** Listar Matriculas ***********/
/* DROP PROCEDURE sp_listar_matriculas; */
CREATE PROCEDURE sp_listar_matriculas
AS
BEGIN
	select * from tb_matricula;
END
GO

EXECUTE sp_listar_matriculas
GO





/******** Buscar Matriculas por ID ***********/
/* DROP PROCEDURE sp_buscar_por_id; */
CREATE PROCEDURE sp_buscar_por_id
@id INT
AS
BEGIN
	SELECT * FROM tb_matricula
	WHERE id_matricula = @id
END
GO

EXECUTE sp_buscar_por_id '3';
GO





/******** Registrar Matriculas ***********/
/* DROP PROCEDURE sp_registrar_matriculas; */
CREATE PROCEDURE sp_registrar_matriculas
@nombre VARCHAR(50),
@apellido VARCHAR(50),
@dni CHAR(8),
@nivel VARCHAR(10), 
@turno VARCHAR(10),
@grado CHAR(1),
@seccion CHAR(1),
@apoderado VARCHAR(120),
@telefono VARCHAR(20)
AS
BEGIN
	INSERT INTO tb_matricula VALUES
	(@nombre, @apellido, @dni, @nivel, @turno, @grado, @seccion, @apoderado, @telefono);
END
GO

EXECUTE sp_registrar_matriculas 'Jenny','Salinas','76615430', 'Inicial', 'Mañana','5','N','Marcela Patricia Marquez Lara','994657891' ;







/******** Actualizar Matriculas ***********/
/* DROP PROCEDURE sp_registrar_matriculas; */
CREATE PROCEDURE sp_actualizar_matriculas
@id INT,
@nombre VARCHAR(50),
@apellido VARCHAR(50),
@dni CHAR(8),
@nivel VARCHAR(10), 
@turno VARCHAR(10),
@grado CHAR(1),
@seccion CHAR(1),
@apoderado VARCHAR(120),
@telefono VARCHAR(20)
AS
BEGIN
	UPDATE tb_matricula SET
	nombre=@nombre, apellido=@apellido, dni=@dni, nivel=@nivel, turno=@turno, grado=@grado, seccion=@seccion, apoderado=@apoderado, telefono=@telefono
	WHERE id_matricula=@id
END
GO

EXECUTE sp_actualizar_matriculas 5,'Gabriel','Drago','74578965', 'Secundaria', 'Mañana','5','C','Memo y Kalibre','015277035' ;






/******** Eliminar Matriculas ***********/
/* DROP PROCEDURE sp_eliminar_matriculas; */
CREATE PROCEDURE sp_eliminar_matriculas
@id INT
AS
BEGIN
	DELETE FROM tb_matricula 
	WHERE id_matricula = @id
END
GO

EXECUTE sp_eliminar_matriculas '5';