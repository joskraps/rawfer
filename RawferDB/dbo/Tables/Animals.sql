CREATE TABLE [dbo].[Animals] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [userId]       INT           NOT NULL,
    [name]         VARCHAR (200) NOT NULL,
    [breed]        VARCHAR (200) NULL,
    [weight]       DECIMAL (18)  NULL,
    [targetWeight] DECIMAL (18)  NULL,
    CONSTRAINT [PK_Animals] PRIMARY KEY CLUSTERED ([id] ASC)
);



