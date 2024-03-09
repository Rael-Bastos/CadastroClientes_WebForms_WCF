USE [GTISoftware]
GO

/****** Object:  Table [dbo].[tbl_Cliente]    Script Date: 09/03/2024 16:11:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[CPF] [nvarchar](max) NULL,
	[Nome] [nvarchar](max) NULL,
	[RG] [nvarchar](max) NULL,
	[DataExpedicao] [datetime2](7) NULL,
	[OrgaoExpedicao] [nvarchar](max) NULL,
	[UFExpedicao] [nvarchar](max) NULL,
	[DataNascimento] [datetime2](7) NOT NULL,
	[Sexo] [nvarchar](max) NULL,
	[EstadoCivil] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbl_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


