-- Veritabanını oluştur
CREATE DATABASE AutismEducationPlatform;
GO

USE AutismEducationPlatform;
GO

-- AspNetRoles tablosu
CREATE TABLE [dbo].[AspNetRoles](
    [Id] [nvarchar](450) NOT NULL,
    [Name] [nvarchar](256) NULL,
    [NormalizedName] [nvarchar](256) NULL,
    [ConcurrencyStamp] [nvarchar](max) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
);
GO

-- AspNetUsers tablosu
CREATE TABLE [dbo].[AspNetUsers](
    [Id] [nvarchar](450) NOT NULL,
    [UserName] [nvarchar](256) NULL,
    [NormalizedUserName] [nvarchar](256) NULL,
    [Email] [nvarchar](256) NULL,
    [NormalizedEmail] [nvarchar](256) NULL,
    [EmailConfirmed] [bit] NOT NULL,
    [PasswordHash] [nvarchar](max) NULL,
    [SecurityStamp] [nvarchar](max) NULL,
    [ConcurrencyStamp] [nvarchar](max) NULL,
    [PhoneNumber] [nvarchar](max) NULL,
    [PhoneNumberConfirmed] [bit] NOT NULL,
    [TwoFactorEnabled] [bit] NOT NULL,
    [LockoutEnd] [datetimeoffset](7) NULL,
    [LockoutEnabled] [bit] NOT NULL,
    [AccessFailedCount] [int] NOT NULL,
    [FullName] [nvarchar](max) NULL,
    [UserType] [int] NOT NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
);
GO

-- EducationalContent tablosu
CREATE TABLE [dbo].[EducationalContents](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Title] [nvarchar](max) NOT NULL,
    [Description] [nvarchar](max) NOT NULL,
    [ContentType] [int] NOT NULL,
    [ImageUrl] [nvarchar](max) NOT NULL,
    [SoundUrl] [nvarchar](max) NULL,
    CONSTRAINT [PK_EducationalContents] PRIMARY KEY ([Id])
);
GO

-- ChildProgress tablosu
CREATE TABLE [dbo].[ChildProgresses](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [UserId] [nvarchar](450) NOT NULL,
    [EducationalContentId] [int] NOT NULL,
    [LastAccessTime] [datetime2](7) NOT NULL,
    [ViewCount] [int] NOT NULL,
    [IsCompleted] [bit] NOT NULL,
    [Notes] [nvarchar](max) NULL,
    CONSTRAINT [PK_ChildProgresses] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ChildProgresses_AspNetUsers] FOREIGN KEY([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ChildProgresses_EducationalContents] FOREIGN KEY([EducationalContentId]) REFERENCES [EducationalContents] ([Id]) ON DELETE CASCADE
);
GO

-- Örnek veri ekleyelim
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp])
VALUES 
(NEWID(), 'Parent', 'PARENT', NEWID()),
(NEWID(), 'Educator', 'EDUCATOR', NEWID());
GO

-- Örnek eğitim içeriği ekleyelim
INSERT INTO [dbo].[EducationalContents] ([Title], [Description], [ContentType], [ImageUrl], [SoundUrl])
VALUES 
('Kedi', 'Sevimli bir kedi', 0, 'https://example.com/cat.jpg', 'https://example.com/cat.mp3'),
('Köpek', 'Sadık bir köpek', 0, 'https://example.com/dog.jpg', 'https://example.com/dog.mp3'),
('Kırmızı', 'Kırmızı renk', 1, 'https://example.com/red.jpg', NULL),
('Üçgen', 'Üçgen şekli', 2, 'https://example.com/triangle.jpg', NULL),
('Sayı 1', 'Bir sayısı', 3, 'https://example.com/one.jpg', NULL);
GO 