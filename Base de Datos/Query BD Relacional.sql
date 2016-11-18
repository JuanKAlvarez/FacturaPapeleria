USE [PAPELERIA]
GO
CREATE TABLE USUARIOS
(IdUsuario		int		 IDENTITY (1, 1) NOT NULL ,
 NombreCompleto char(50) NOT NULL ,
 Cargo			char(30),
 Celular		int  ,
 UserName		Char ,
 Password		Char ,
 PRIMARY KEY (IdUsuario)
);

CREATE TABLE CATEORIAS
(IdCategoria	 int	  IDENTITY (1, 1) NOT NULL ,
 NombreCat       char(50) NOT NULL ,
 DescripcionCat	 char(150),
 PRIMARY KEY (IdCategoria)
);

CREATE TABLE FACTURAS
(IdFactura		int		 IDENTITY (1, 1) NOT NULL ,
 Fecha			datetime ,
 PRIMARY KEY (IdFactura),
 IdUsuario int FOREIGN KEY REFERENCES USUARIOS(IdUsuario)
);

CREATE TABLE PRODUCTOS
(IdProducto		int		 IDENTITY (1, 1) NOT NULL ,
 NombreProducto char (50) NOT NULL ,
 Precio			float,
 Valor			float,
 Stock		    int ,
 PRIMARY KEY (IdProducto),
 IdCategoria int FOREIGN KEY REFERENCES CATEORIAS(IdCategoria)
);

CREATE TABLE DETALLES
(IdDetalles		int		 IDENTITY (1, 1) NOT NULL ,
 Cantidad		int ,
 Precio			float,
 PRIMARY KEY (IdDetalles),
 IdFactura int FOREIGN KEY REFERENCES FACTURAS(IdFactura),
 IdProducto int FOREIGN KEY REFERENCES PRODUCTOS(IdProducto)
);

 
