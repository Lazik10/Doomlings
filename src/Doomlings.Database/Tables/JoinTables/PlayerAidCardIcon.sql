CREATE TABLE [jointables].[PlayerAidCardIcon]
(
    [Id]                        INT                 NOT NULL IDENTITY,
    [PlayerAidCardId]           INT                 NOT NULL,
    [IconId]                    INT                 NOT NULL,

    CONSTRAINT [PK_PlayerAidCardIcon] PRIMARY KEY ([Id])
)
