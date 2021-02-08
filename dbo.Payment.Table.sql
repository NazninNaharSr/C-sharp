USE [Hotel Management System]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 12/24/2019 3:55:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[Food_Bill] [int] NOT NULL,
	[Tax] [int] NOT NULL,
	[Reservation_Bill] [int] NOT NULL,
	[Total] [int] NOT NULL,
	[Payment_Type] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
