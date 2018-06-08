CREATE TABLE [dbo].[FoodItems] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [Name]            VARCHAR (150) NOT NULL,
    [Type]            INT           NOT NULL,
    [ProteinPercent]  DECIMAL (18)  NULL,
    [FatPercent]      DECIMAL (18)  NULL,
    [FiberPercent]    DECIMAL (18)  NULL,
    [MoisturePercent] DECIMAL (18)  NULL,
    [UserId]          INT           CONSTRAINT [DF_FoodItems_UserId] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_FoodItems] PRIMARY KEY CLUSTERED ([Id] ASC)
);

