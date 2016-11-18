USE [PAPELERIA]
GO
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