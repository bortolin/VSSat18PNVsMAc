SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int]  NOT NULL IDENTITY PRIMARY KEY,
	[ProductsName] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO