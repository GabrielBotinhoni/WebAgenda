IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Contacts] (
    [ID] int NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NOT NULL,
    [LastName] nvarchar(max) NOT NULL,
    [PhoneNumber] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NULL,
    [BirthDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Contacts] PRIMARY KEY ([ID])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220113151005_addDbAndContact', N'3.1.22');

GO

CREATE TABLE [ErrorLogs] (
    [Id] int NOT NULL IDENTITY,
    [Date] datetime2 NOT NULL,
    [Details] nvarchar(max) NULL,
    [SystemMessage] nvarchar(max) NULL,
    [StackTrace] nvarchar(max) NULL,
    CONSTRAINT [PK_ErrorLogs] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220113193407_ErrorLog', N'3.1.22');

GO

