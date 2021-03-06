USE [HospitalDB]
GO
/****** Object:  Table [dbo].[tbl_Patients]    Script Date: 02/27/2018 06:41:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Patients](
	[Patient_ID] [int] IDENTITY(1,1) NOT NULL,
	[Patient_Fanme] [nvarchar](100) NOT NULL,
	[Patient_Lname] [nvarchar](100) NOT NULL,
	[Patient_Address] [nvarchar](200) NOT NULL,
	[Patient_Date] [date] NOT NULL,
	[Patient_InsertionDateTime] [datetime] NULL,
 CONSTRAINT [PK_tbl_Patients] PRIMARY KEY CLUSTERED 
(
	[Patient_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_Patients] ON
INSERT [dbo].[tbl_Patients] ([Patient_ID], [Patient_Fanme], [Patient_Lname], [Patient_Address], [Patient_Date], [Patient_InsertionDateTime]) VALUES (1, N'Mahmoud', N'Eid', N'Ciro - Giza', CAST(0xD83D0B00 AS Date), CAST(0x0000A894006D4AE4 AS DateTime))
INSERT [dbo].[tbl_Patients] ([Patient_ID], [Patient_Fanme], [Patient_Lname], [Patient_Address], [Patient_Date], [Patient_InsertionDateTime]) VALUES (2, N'Ahmed', N'Eid', N'Ciro - Giza', CAST(0xE23D0B00 AS Date), CAST(0x0000A894006D61EB AS DateTime))
INSERT [dbo].[tbl_Patients] ([Patient_ID], [Patient_Fanme], [Patient_Lname], [Patient_Address], [Patient_Date], [Patient_InsertionDateTime]) VALUES (3, N'Kareem', N'Ahmed', N'Ciro - Maadi', CAST(0xDA3D0B00 AS Date), CAST(0x0000A894006D95B3 AS DateTime))
INSERT [dbo].[tbl_Patients] ([Patient_ID], [Patient_Fanme], [Patient_Lname], [Patient_Address], [Patient_Date], [Patient_InsertionDateTime]) VALUES (4, N'Belal', N'Ragb', N'Salah Salem Str', CAST(0xDA3D0B00 AS Date), CAST(0x0000A894006DB677 AS DateTime))
INSERT [dbo].[tbl_Patients] ([Patient_ID], [Patient_Fanme], [Patient_Lname], [Patient_Address], [Patient_Date], [Patient_InsertionDateTime]) VALUES (5, N'Ahmed', N'Maher', N'Ghamra', CAST(0xDA3D0B00 AS Date), CAST(0x0000A894006DD08E AS DateTime))
INSERT [dbo].[tbl_Patients] ([Patient_ID], [Patient_Fanme], [Patient_Lname], [Patient_Address], [Patient_Date], [Patient_InsertionDateTime]) VALUES (6, N'Hamda', N'Mohammed', N'City Mall', CAST(0xDA3D0B00 AS Date), CAST(0x0000A894006DED6D AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_Patients] OFF
