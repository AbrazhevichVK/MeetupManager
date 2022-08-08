USE [DbMeetups]
GO

/****** Object:  Table [dbo].[Meetups]    Script Date: 08.08.2022 21:38:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Meetups](
	[MeetupId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Theme] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Plan] [nvarchar](max) NULL,
	[Organizar] [nvarchar](max) NULL,
	[Speaker] [nvarchar](max) NULL,
	[MeetupTime] [datetime2](7) NOT NULL,
	[MeetupPlace] [nvarchar](max) NULL,
 CONSTRAINT [PK_Meetups] PRIMARY KEY CLUSTERED 
(
	[MeetupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


