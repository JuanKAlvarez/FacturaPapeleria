--  STORE PROCEDURE par  la tabla Categoria

USE [PAPELERIA]
GO
-- SP_ConsultarCategoria 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[SP_ConsultarCategoria]
AS
BEGIN
	SET NOCOUNT ON;
	Select	 IdCategoria    As Id,
			 NombreCat      As Categoria,
			 DescripcionCat As Descripcion
    From CATEORIAS
END
GO

-- SP_DeleteCategoria 

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure SP_DeleteCategoria
(
@Id			  int
)
AS
BEGIN
	DELETE FROM CATEORIAS
    WHERE IdCategoria = @Id	
END
GO

--SP_InsertCategoria

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure SP_InsertCategoria
(
@Nombre       Varchar(50),
@Descripcion  Varchar(150)
)
AS
BEGIN
	INSERT 
	INTO   CATEORIAS (NombreCat, DescripcionCat)
	VALUES			 (@Nombre  , @Descripcion)
END
GO

-- SP_UpdateCategoria

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure SP_UpdateCategoria
(
@Id			  int,
@Nombre       Varchar(50),
@Descripcion  Varchar(150)
)
AS
BEGIN
	UPDATE CATEORIAS
    SET   NombreCat       = @Nombre,
          DescripcionCat  = @Descripcion
    WHERE IdCategoria     = @Id	
END