USE [GTISoftware]
GO

/****** Object:  Table [dbo].[tbl_EnderecoCliente]    Script Date: 09/03/2024 16:12:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_EnderecoCliente](
	[IdCliente] [int] NOT NULL,
	[IdEndereco] [int] NOT NULL,
	[CEP] [nvarchar](max) NULL,
	[Logradouro] [nvarchar](max) NULL,
	[Numero] [nvarchar](max) NULL,
	[Complemento] [nvarchar](max) NULL,
	[Bairro] [nvarchar](max) NULL,
	[Cidade] [nvarchar](max) NULL,
	[UF] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbl_EnderecoCliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[tbl_EnderecoCliente]  WITH CHECK ADD  CONSTRAINT [FK_tbl_EnderecoCliente_tbl_Cliente_IdCliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[tbl_Cliente] ([IdCliente])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[tbl_EnderecoCliente] CHECK CONSTRAINT [FK_tbl_EnderecoCliente_tbl_Cliente_IdCliente]
GO


