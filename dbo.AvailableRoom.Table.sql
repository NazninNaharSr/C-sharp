USE [Hotel Management System]
GO
/****** Object:  Table [dbo].[AvailableRoom]    Script Date: 12/24/2019 3:55:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AvailableRoom](
	[Room_NO] [int] IDENTITY(1,1) NOT NULL,
	[Room_Type] [nvarchar](50) NOT NULL,
	[Floor] [int] NOT NULL,
 CONSTRAINT [PK_AvailableRoom] PRIMARY KEY CLUSTERED 
(
	[Room_NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
