IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Player] (
    [PlayerId] int NOT NULL IDENTITY,
    [PlayerName] nvarchar(max) NOT NULL,
    [PlayerTeam] nvarchar(max) NOT NULL,
    [Average] float NOT NULL,
    [PlayerType] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Player] PRIMARY KEY ([PlayerId])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230811111019_FirstMig', N'6.0.21');
GO

COMMIT;
GO

