USE [Essais_EF_Relationships_OneToMany]
GO
SET IDENTITY_INSERT [dbo].[Bibliotheques] ON 

INSERT [dbo].[Bibliotheques] ([Id], [Nom]) VALUES (1, N'Biblio 1')
INSERT [dbo].[Bibliotheques] ([Id], [Nom]) VALUES (2, N'Biblio 2')
SET IDENTITY_INSERT [dbo].[Bibliotheques] OFF
GO
SET IDENTITY_INSERT [dbo].[Livres] ON 

INSERT [dbo].[Livres] ([Id], [Titre], [DatePublication], [BibliothequeId]) VALUES (1, N'Livre1', CAST(N'2022-09-30T14:24:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Livres] ([Id], [Titre], [DatePublication], [BibliothequeId]) VALUES (2, N'Livre 2', CAST(N'2022-10-21T18:12:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Livres] ([Id], [Titre], [DatePublication], [BibliothequeId]) VALUES (3, N'Livre3', NULL, 2)
INSERT [dbo].[Livres] ([Id], [Titre], [DatePublication], [BibliothequeId]) VALUES (4, N'Livre4', CAST(N'2021-09-20T15:16:00.0000000' AS DateTime2), 2)
SET IDENTITY_INSERT [dbo].[Livres] OFF
GO
SET IDENTITY_INSERT [dbo].[Garages] ON 

INSERT [dbo].[Garages] ([Id], [Nom]) VALUES (1, N'Garage1')
INSERT [dbo].[Garages] ([Id], [Nom]) VALUES (2, N'Garage2')
INSERT [dbo].[Garages] ([Id], [Nom]) VALUES (3, N'Garage3')
SET IDENTITY_INSERT [dbo].[Garages] OFF
GO
INSERT [dbo].[Voitures] ([Immatric], [Modele], [GarageId]) VALUES (N'ea7b2bdf-ae5c-4cad-a2bc-1688262e84c2', N'Voiture1', 1)
INSERT [dbo].[Voitures] ([Immatric], [Modele], [GarageId]) VALUES (N'93c572c3-9292-4683-9d49-3e7940480535', N'Voiture5', 3)
INSERT [dbo].[Voitures] ([Immatric], [Modele], [GarageId]) VALUES (N'67b08fe3-a9d5-44ca-874e-52e12c8f6cca', N'Voiture3', 1)
INSERT [dbo].[Voitures] ([Immatric], [Modele], [GarageId]) VALUES (N'5c9bf1d1-b378-4f2f-9d31-b94e2bf97293', N'Voiture4', 2)
INSERT [dbo].[Voitures] ([Immatric], [Modele], [GarageId]) VALUES (N'a73651d1-7225-4e0f-9f20-e97c1be3ffbc', N'Voiture2', 2)
GO
SET IDENTITY_INSERT [dbo].[Trains] ON 

INSERT [dbo].[Trains] ([Id], [Reference]) VALUES (1, N'Train1')
INSERT [dbo].[Trains] ([Id], [Reference]) VALUES (2, N'Train2')
INSERT [dbo].[Trains] ([Id], [Reference]) VALUES (3, N'Train3')
SET IDENTITY_INSERT [dbo].[Trains] OFF
GO
SET IDENTITY_INSERT [dbo].[Passagers] ON 

INSERT [dbo].[Passagers] ([Id], [NumeroSecu], [My_TrainId_FK]) VALUES (1, N'e17f6b13-a5f6-4085-bbcd-58fb373bc57e', 3)
INSERT [dbo].[Passagers] ([Id], [NumeroSecu], [My_TrainId_FK]) VALUES (2, N'54a6dca6-8477-4e2d-8bb8-adc28c4ce10f', 1)
INSERT [dbo].[Passagers] ([Id], [NumeroSecu], [My_TrainId_FK]) VALUES (3, N'45f64d32-ec87-41cf-b134-81d0924f62cb', 3)
INSERT [dbo].[Passagers] ([Id], [NumeroSecu], [My_TrainId_FK]) VALUES (4, N'db7a2e17-8bf8-4e38-a18f-db12d5201e77', 2)
INSERT [dbo].[Passagers] ([Id], [NumeroSecu], [My_TrainId_FK]) VALUES (5, N'bcc3a1e9-7017-44f9-b114-8b0088e049a8', 1)
INSERT [dbo].[Passagers] ([Id], [NumeroSecu], [My_TrainId_FK]) VALUES (7, N'ea7b2bdf-ae5c-4cad-a2bc-1688262e84c2', 2)
SET IDENTITY_INSERT [dbo].[Passagers] OFF
GO
SET IDENTITY_INSERT [dbo].[Paniers] ON 

INSERT [dbo].[Paniers] ([Id], [Reference], [MontantTotal]) VALUES (1, N'Panier1', 0)
INSERT [dbo].[Paniers] ([Id], [Reference], [MontantTotal]) VALUES (2, N'Panier2', 450.78)
SET IDENTITY_INSERT [dbo].[Paniers] OFF
GO
SET IDENTITY_INSERT [dbo].[Articles] ON 

INSERT [dbo].[Articles] ([Id], [Code], [My_PanierId]) VALUES (1, N'Article1', 2)
INSERT [dbo].[Articles] ([Id], [Code], [My_PanierId]) VALUES (2, N'Article2', 1)
INSERT [dbo].[Articles] ([Id], [Code], [My_PanierId]) VALUES (3, N'Article3', 2)
INSERT [dbo].[Articles] ([Id], [Code], [My_PanierId]) VALUES (4, N'Article4', 1)
SET IDENTITY_INSERT [dbo].[Articles] OFF
GO