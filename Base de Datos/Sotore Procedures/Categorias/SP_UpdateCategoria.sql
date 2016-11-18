USE [PAPELERIA]
GO
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