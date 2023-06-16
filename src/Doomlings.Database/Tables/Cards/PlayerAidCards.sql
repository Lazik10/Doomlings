CREATE TABLE [cards].[PlayerAidCards]
(
    [Id]                        INT                 NOT NULL IDENTITY,
    [Name]                      NVARCHAR(100)       NOT NULL,
    [Description]               NVARCHAR(MAX)       NOT NULL,
    [Type]                      INT                 NOT NULL,
    [Color]                     INT                 NOT NULL,
    [Effect]                    INT                 NOT NULL,
    [Expansion]                 INT                 NOT NULL,
    [IconInfoId]                INT                 NULL,

    CONSTRAINT [PK_PlayerAidCards_Id] UNIQUE ([Id]),
    CONSTRAINT [FK_PlayerAidCards_IconInfo] FOREIGN KEY (IconInfoId) REFERENCES [Icons].[Icons](Id)
)
