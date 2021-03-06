USE [Hotel Management System]
GO
/****** Object:  Table [dbo].[GuestRegistration]    Script Date: 12/24/2019 3:55:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuestRegistration](
	[Guest_ID] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [nvarchar](50) NOT NULL,
	[Last_Name] [nvarchar](50) NOT NULL,
	[Gender] [int] NOT NULL,
	[Phone_no] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Room_Type] [nvarchar](50) NOT NULL,
	[Floor] [int] NOT NULL,
	[Room_No] [int] NOT NULL,
	[Entry_Date] [datetime] NOT NULL,
	[Departure_Date] [datetime] NOT NULL,
 CONSTRAINT [PK_GuestRegistration] PRIMARY KEY CLUSTERED 
(
	[Guest_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
