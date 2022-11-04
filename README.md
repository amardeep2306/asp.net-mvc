# asp.net-mvc

### Execute below SQL query to insert sample data into table `[dbo].[Products]`
```
SET IDENTITY_INSERT [dbo].[Products] ON
INSERT INTO [dbo].[Products] ([ProductId], [ProductName], [Image], [Price]) VALUES (1, N'Scooter', N'/images/scooter.png', 45000)
INSERT INTO [dbo].[Products] ([ProductId], [ProductName], [Image], [Price]) VALUES (2, N'Ebike', N'/images/ebike.jpg', 38000)
INSERT INTO [dbo].[Products] ([ProductId], [ProductName], [Image], [Price]) VALUES (3, N'Bike', N'/images/bike.jpg', 94000)
INSERT INTO [dbo].[Products] ([ProductId], [ProductName], [Image], [Price]) VALUES (4, N'Car', N'/images/car.jpg', 494000)
SET IDENTITY_INSERT [dbo].[Products] OFF
```

### Execute below SQL query to insert sample data into table `[dbo].[Flowers]`
```
SET IDENTITY_INSERT [dbo].[Flowers] ON
INSERT INTO [dbo].[Flowers] ([Id], [Name], [Image]) VALUES (1, N'Rose', N'/images/rose.jpg')
INSERT INTO [dbo].[Flowers] ([Id], [Name], [Image]) VALUES (2, N'Lotus', N'/images/lotus.jpg')
INSERT INTO [dbo].[Flowers] ([Id], [Name], [Image]) VALUES (3, N'Marigold', N'/images/marigold.jpg')
INSERT INTO [dbo].[Flowers] ([Id], [Name], [Image]) VALUES (4, N'Sunflower', N'/images/sunflower.jpg')
INSERT INTO [dbo].[Flowers] ([Id], [Name], [Image]) VALUES (5, N'Lily', N'/images/lily.jpg')
SET IDENTITY_INSERT [dbo].[Flowers] OFF
```
