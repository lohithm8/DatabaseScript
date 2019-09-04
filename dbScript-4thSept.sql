USE [AdminDB]
GO

/****** Object:  Table [dbo].[Event_Table]    Script Date: 9/4/2019 2:45:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Event_Table](
	[eve_id] [int] NOT NULL,
	[eve_name] [nvarchar](50) NOT NULL,
	[description] [nvarchar](max) NULL,
	[priority] [int] NOT NULL,
	[status] [nvarchar](50) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

CREATE TABLE [dbo].[Participant_Table](
	[par_id] [int] NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[mid_name] [nvarchar](50) NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[dob] [datetime] NOT NULL,
	[gender] [char](7) NOT NULL,
	[mobile] [numeric](10, 0) NOT NULL,
	[email] [nvarchar](50) NULL
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Venue_Table](
	[venue_id] [int] NOT NULL,
	[venue_name] [nvarchar](50) NOT NULL,
	[start_date] [datetime] NOT NULL,
	[end_date] [datetime] NOT NULL,
	[class_size] [int] NOT NULL,
	[location] [nvarchar](70) NOT NULL
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Course_Table](
	[course_id] [int] NOT NULL,
	[course_name] [nvarchar](50) NOT NULL,
	[speaker_id] [int] NOT NULL,
	[cost] [numeric](10, 4) NOT NULL,
	[course_desc] [nvarchar](max) NOT NULL,
	[category] [nvarchar](20) NOT NULL,
	[promo_code] [nvarchar](50) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

CREATE TABLE [dbo].[Speaker_table](
	[speaker_id] [int] NOT NULL,
	[speaker_name] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NULL,
	[contact] [numeric](10, 0) NOT NULL,
	[keyskill] [nvarchar](30) NOT NULL,
	[semail] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO


