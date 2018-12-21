CREATE TABLE [dbo].[Person] (
    [ContactID]        INT     Identity(1,1) NOT NULL,
    [Name]             NVARCHAR (50) NULL,
    [Company]          NVARCHAR (50) NULL,
    [Office_Telephone] NVARCHAR (50) NULL,
    [Email]            NVARCHAR (50) NULL,
    [Client]           BIT           NULL,
    [LastCalled]       DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([ContactID] ASC)
);

