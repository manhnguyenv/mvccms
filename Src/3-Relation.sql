/****** Object:  Index [IX_Alias]    Script Date: 05/22/2018 10:41:54 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Alias] ON [dbo].[Article]
(
	[Alias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_BlogID]    Script Date: 05/22/2018 10:41:54 PM ******/
CREATE NONCLUSTERED INDEX [IX_BlogID] ON [dbo].[Article]
(
	[BlogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Alias]    Script Date: 05/22/2018 10:41:54 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Alias] ON [dbo].[Blog]
(
	[Alias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Alias]    Script Date: 05/22/2018 10:41:54 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Alias] ON [dbo].[Category]
(
	[Alias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Alias]    Script Date: 05/22/2018 10:41:54 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Alias] ON [dbo].[Product]
(
	[Alias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CategoryID]    Script Date: 05/22/2018 10:41:54 PM ******/
CREATE NONCLUSTERED INDEX [IX_CategoryID] ON [dbo].[Product]
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Username]    Script Date: 05/22/2018 10:41:54 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Username] ON [dbo].[User]
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PermissionID]    Script Date: 05/22/2018 10:41:54 PM ******/
CREATE NONCLUSTERED INDEX [IX_PermissionID] ON [dbo].[UserGrantPermission]
(
	[PermissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserID]    Script Date: 05/22/2018 10:41:54 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserID] ON [dbo].[UserGrantPermission]
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_BusinessID]    Script Date: 05/22/2018 10:41:54 PM ******/
CREATE NONCLUSTERED INDEX [IX_BusinessID] ON [dbo].[UserPermission]
(
	[BusinessID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Article]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Article_dbo.Blog_BlogID] FOREIGN KEY([BlogID])
REFERENCES [dbo].[Blog] ([BlogID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Article] CHECK CONSTRAINT [FK_dbo.Article_dbo.Blog_BlogID]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Product_dbo.Category_CategoryID] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_dbo.Product_dbo.Category_CategoryID]
GO
ALTER TABLE [dbo].[UserGrantPermission]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UserGrantPermission_dbo.User_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserGrantPermission] CHECK CONSTRAINT [FK_dbo.UserGrantPermission_dbo.User_UserID]
GO
ALTER TABLE [dbo].[UserGrantPermission]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UserGrantPermission_dbo.UserPermission_PermissionID] FOREIGN KEY([PermissionID])
REFERENCES [dbo].[UserPermission] ([PermissionID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserGrantPermission] CHECK CONSTRAINT [FK_dbo.UserGrantPermission_dbo.UserPermission_PermissionID]
GO
ALTER TABLE [dbo].[UserPermission]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UserPermission_dbo.UserBusiness_BusinessID] FOREIGN KEY([BusinessID])
REFERENCES [dbo].[UserBusiness] ([BusinessID])
GO
ALTER TABLE [dbo].[UserPermission] CHECK CONSTRAINT [FK_dbo.UserPermission_dbo.UserBusiness_BusinessID]
GO