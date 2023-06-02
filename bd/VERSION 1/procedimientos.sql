CREATE PROCEDURE DEV.pa_IniciarSesion
(
	@usuario AS VARCHAR(20),
	@password AS VARCHAR(100)
)
AS
BEGIN
	DECLARE @usua_Id AS VARCHAR(100);

	IF EXISTS (SELECT usua_Id FROM DEV.USUARIO WHERE usua_Usuario = @usuario AND CAST((DECRYPTBYPASSPHRASE('erp_sglc',usua_Password)) AS VARCHAR(20)) = @password AND usua_Marcabaja = 1 AND usua_Estado = 1)
	BEGIN
		SELECT @usua_Id = usua_Id FROM DEV.USUARIO WHERE usua_Usuario = @usuario AND CAST((DECRYPTBYPASSPHRASE('erp_sglc',usua_Password)) AS VARCHAR(20)) = @password AND usua_Marcabaja = 1 AND usua_Estado = 1
		SELECT usua_Id, usua_Usuario, usua_Estado, trab_Id, usua_FechaAlta, usua_FechaRegistro, usua_UsuarioRegistro, 0 AS codError, 'Inicio de sesión exitoso. Bienvenido' AS Mensaje FROM DEV.USUARIO WHERE usua_Id = @usua_Id;
	END
	ELSE
	BEGIN
		SELECT -1 AS codError, 'CombinaciÓn de usuario y contraseña inválido' As Mensaje
	END
END;
GO
ALTER PROCEDURE DEV.pa_RegistrarError
(
	@cerr_Formulario AS VARCHAR(50),
	@cerr_MensajeError AS VARCHAR(500),
	@cerr_Traza AS VARCHAR(5000),
	@cerr_Usuario AS VARCHAR(20),
	@cerr_Trama AS VARCHAR(5000),
	@cerr_FechaError AS DATE
)
AS
BEGIN
	INSERT INTO DEV.CONTROL_ERROR (cerr_Formulario, cerr_MensajeError, cerr_Traza, cerr_Usuario, cerr_Trama, cerr_FechaError)
	VALUES(@cerr_Formulario, @cerr_MensajeError, @cerr_Traza, @cerr_Usuario, @cerr_Trama, @cerr_FechaError);
	SELECT @@IDENTITY AS codError
END;
GO


CREATE PROCEDURE DEV.pa_ObtenerConcepto
(
	@conc_Prefijo AS INTEGER
)
AS
BEGIN
	SELECT conc_Prefijo, conc_Correlativo, conc_Descripcion, conc_Abreviatura FROM DEV.CONCEPTO WHERE conc_Prefijo = @conc_Prefijo AND conc_Correlativo > 0;
END;
GO


CREATE PROCEDURE DEV.pa_ObtenerUbigeo
(
	@todos AS INT,
	@dept_Ubigeo CHAR(2),
	@prov_Ubigeo CHAR(4),
	@dist_Ubigeo CHAR(6)
)
AS
BEGIN
	IF @todos = 1
	BEGIN
		SELECT dept_Ubigeo as Ubigeo, dept_Descripcion as Descripcion, '' As Referencia FROM DEV.DEPARTAMENTO
	END
	ELSE
	BEGIN
		IF LEN(@dept_Ubigeo)>0
		BEGIN
			SELECT prov_Ubigeo AS Ubigeo, prov_Descripcion AS Descripcion, dept_Ubigeo As Referencia FROM DEV.PROVINCIA WHERE dept_Ubigeo = @dept_Ubigeo;
		END
		ELSE
		BEGIN
			IF LEN(@prov_Ubigeo)>0
			BEGIN
				SELECT dist_Ubigeo AS Ubigeo, dist_Descripcion AS Descripcion, prov_Ubigeo As Referencia FROM DEV.DISTRITO WHERE prov_Ubigeo = @prov_Ubigeo;
			END
			ELSE
			BEGIN
				SELECT dist_Ubigeo AS Ubigeo, dist_Descripcion AS Descripcion, prov_Ubigeo As Referencia FROM DEV.DISTRITO WHERE dist_Ubigeo = @dist_Ubigeo;
			END
		END
	END
END;
GO


CREATE PROCEDURE DEV.pa_Trabajador_IUD
(
	@tipo CHAR(1),
	@trab_Id INT,
	@trab_TipoDocumento AS SMALLINT,
	@trab_Documento AS VARCHAR(15),
	@trab_Nombres VARCHAR(50),
	@trab_ApellidoPaterno VARCHAR(20),
	@trab_ApellidoMaterno VARCHAR(20),
	@trab_EstadoCivil SMALLINT, 
	@trab_Estado INT,
	@trab_Marcabaja INT,
	@trab_FechaNacimiento DATE,
	@trab_Sexo INT,
	@trab_LugarNacimiento CHAR(6),
	@trab_usuarioRegistro VARCHAR(20),
	@empr_Id INT
)
AS
BEGIN

	DECLARE @codrespuesta AS INT;
	DECLARE @mensaje AS VARCHAR(500);
	SET @codrespuesta= 0;
	SET @mensaje = '';
	IF @tipo = 'I'
	BEGIN
		IF NOT EXISTS (SELECT trab_Id FROM DEV.TRABAJADOR WHERE trab_Documento = @trab_Documento)
		BEGIN
			INSERT INTO DEV.TRABAJADOR (trab_TipoDocumento, trab_Documento, trab_Nombres, trab_ApellidoPaterno, trab_ApellidoMaterno, trab_EstadoCivil, trab_Estado, trab_Marcabaja, trab_FechaNacimiento, trab_Sexo, trab_LugarNacimiento, trab_FechaRegistro, trab_UsuarioRegistro, empr_Id)
			VALUES (@trab_TipoDocumento, @trab_Documento, @trab_Nombres, @trab_ApellidoPaterno, @trab_ApellidoMaterno, @trab_EstadoCivil, @trab_Estado, @trab_Marcabaja, @trab_FechaNacimiento, @trab_Sexo, @trab_LugarNacimiento, GETDATE(), @trab_UsuarioRegistro, @empr_Id);
			SET @codrespuesta = 0;
			SET @mensaje = 'REGISTRO EXITOSO';
			SET @trab_Id = @@IDENTITY;
		END
		ELSE
		BEGIN
			SET @codrespuesta = -1;
			SET @mensaje = 'DNI DE TRABAJADOR YA EXISTE';
		END

	END
END;
GO