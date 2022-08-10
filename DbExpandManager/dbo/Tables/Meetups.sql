CREATE TABLE [dbo].[Meetups] (
    [MeetupId]    INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (MAX) NULL,
    [Theme]       NVARCHAR (MAX) NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Plan]        NVARCHAR (MAX) NULL,
    [Organizar]   NVARCHAR (MAX) NULL,
    [Speaker]     NVARCHAR (MAX) NULL,
    [MeetupTime]  DATETIME2 (7)  NOT NULL,
    [MeetupPlace] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Meetups] PRIMARY KEY CLUSTERED ([MeetupId] ASC)
);

