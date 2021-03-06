USE [AamarnetSystemISPDB]
GO
/****** Object:  UserDefinedFunction [dbo].[BRANCH_NAME_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[BRANCH_NAME_BY_ID](@branchId varchar(max))
returns varchar(max)
as
begin 
	declare @branchName varchar(max)

	select @branchName=BranchName from Branch where branchId=@branchId

	return @branchName
end


GO
/****** Object:  UserDefinedFunction [dbo].[GET_PACKAGE_NAME_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[GET_PACKAGE_NAME_BY_ID](
@PackageId varchar(max)
)
returns varchar(max)
as
begin
	declare @packageName varchar(max)

	select @packageName=PackageName from Package where PackageId=@PackageId

	return @packageName
end

GO
/****** Object:  UserDefinedFunction [dbo].[GET_USER_EMAIL_NAME_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[GET_USER_EMAIL_NAME_BY_ID](@ID varchar(max))
returns varchar(max)
as
begin
	declare @name varchar(max)

	set @name = (select Email from users where Serial=@ID)

	return @name;
end



GO
/****** Object:  UserDefinedFunction [dbo].[GET_USER_GROUP_NAME_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [dbo].[GET_USER_GROUP_NAME_BY_ID](@userGroupId varchar(500))
returns varchar(max)
as
begin

	declare @userGroupName varchar(max)
	set @userGroupName = (select UserGroupName from UserGroup where UserGroupId=@userGroupId)

	return @userGroupName
end


GO
/****** Object:  UserDefinedFunction [dbo].[USER_NAME_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[USER_NAME_BY_ID](@ID varchar(max))
returns varchar(max)
as
begin
	declare @name varchar(max)

	set @name = (select Name from users where Serial=@ID)

	return @name;
end



GO
/****** Object:  Table [dbo].[Branch]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Branch](
	[branchId] [varchar](900) NULL,
	[BranchName] [varchar](max) NULL,
	[BranchAdd] [varchar](max) NULL,
	[BranchCretedDate] [smalldatetime] NULL,
	[IsActive] [varchar](5) NULL,
	[IsDeleted] [varchar](5) NULL,
	[ceatedBy] [varchar](max) NULL,
	[createdForm] [varchar](max) NULL,
	[createdDate] [smalldatetime] NULL,
UNIQUE NONCLUSTERED 
(
	[branchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FTPcollection]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FTPcollection](
	[FTPcollectionId] [varchar](900) NULL,
	[FTPcollectionParentCatagory] [varchar](200) NULL,
	[FTPcollectionChildCatagory] [varchar](200) NULL,
	[FTPcollectionTitle] [varchar](max) NULL,
	[FTPcollectionDescription] [varchar](max) NULL,
	[FTPcollectionFTPlink] [varchar](300) NULL,
	[FTPcollectionLink] [varchar](max) NULL,
	[FTPcollectionFullLink] [varchar](max) NULL,
	[FTPcollectionImageName] [varchar](500) NULL,
	[IsActive] [varchar](5) NULL,
	[IsDeleted] [varchar](5) NULL,
	[CreatedBy] [varchar](max) NULL,
	[CreatedForm] [varchar](max) NULL,
	[CreatedDate] [smalldatetime] NULL,
UNIQUE NONCLUSTERED 
(
	[FTPcollectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FtpServer]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FtpServer](
	[FtpServerId] [varchar](900) NULL,
	[FtpServerName] [varchar](max) NULL,
	[FtpserverLink] [varchar](max) NULL,
	[FtpServerImage] [varchar](max) NULL,
	[IsActive] [varchar](5) NULL,
	[IsDeleted] [varchar](5) NULL,
	[CreatedBy] [varchar](max) NULL,
	[CreatedForm] [varchar](max) NULL,
	[CreatedDate] [smalldatetime] NULL,
UNIQUE NONCLUSTERED 
(
	[FtpServerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GenarateID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GenarateID](
	[Prefix] [varchar](100) NULL,
	[ID] [bigint] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[onlineTvServer]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[onlineTvServer](
	[onlineTvserverId] [varchar](900) NULL,
	[onlineTvServerName] [varchar](max) NULL,
	[onlineTvServerLink] [varchar](max) NULL,
	[onlineTvServerImage] [varchar](max) NULL,
	[IsActive] [varchar](5) NULL,
	[IsDeleted] [varchar](5) NULL,
	[CreatedBy] [varchar](max) NULL,
	[CreatedForm] [varchar](max) NULL,
	[CreatedDate] [smalldatetime] NULL,
UNIQUE NONCLUSTERED 
(
	[onlineTvserverId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Package]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Package](
	[PackageId] [varchar](900) NULL,
	[PackageName] [varchar](300) NULL,
	[packagePrice] [decimal](18, 2) NULL,
	[packageMinSpd] [decimal](18, 2) NULL,
	[packageMaxSpd] [decimal](18, 2) NULL,
	[youtubeSpeed] [decimal](18, 2) NULL,
	[starNetworkFtpSpd] [decimal](18, 2) NULL,
	[otherFtpSpd] [decimal](18, 2) NULL,
	[bdixSpd] [decimal](18, 2) NULL,
	[RealIp] [varchar](50) NULL,
	[IsActive] [varchar](5) NULL,
	[IsDeleted] [varchar](5) NULL,
	[createdBy] [varchar](max) NULL,
	[createdFrom] [varchar](max) NULL,
	[createdDate] [smalldatetime] NULL,
	[BranchId] [varchar](max) NULL,
UNIQUE NONCLUSTERED 
(
	[PackageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ResetUserPasswordLink]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ResetUserPasswordLink](
	[ID] [uniqueidentifier] NOT NULL,
	[userId] [varchar](900) NULL,
	[requestedDate] [smalldatetime] NULL,
	[requestForm] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sliderImage]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sliderImage](
	[ImageId] [varchar](900) NULL,
	[ImageName] [varchar](max) NULL,
	[SliderTitle] [varchar](max) NULL,
	[SliderMsg] [varchar](max) NULL,
	[sliderActiveImage] [varchar](50) NULL,
	[IsActive] [varchar](5) NULL,
	[IsDeleted] [varchar](5) NULL,
	[createdBy] [varchar](max) NULL,
	[createdForm] [varchar](max) NULL,
	[createdDate] [smalldatetime] NULL,
UNIQUE NONCLUSTERED 
(
	[ImageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TorrentServer]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TorrentServer](
	[TorrentServerId] [varchar](500) NULL,
	[TorrentServerName] [varchar](500) NULL,
	[TorrentServerLink] [varchar](500) NULL,
	[TorrentServerImage] [varchar](500) NULL,
	[IsActive] [varchar](5) NULL,
	[IsDeleted] [varchar](5) NULL,
	[CreatedBy] [varchar](max) NULL,
	[CreatedForm] [varchar](max) NULL,
	[CreatedDate] [smalldatetime] NULL,
UNIQUE NONCLUSTERED 
(
	[TorrentServerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserGroup]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserGroup](
	[UserGroupId] [varchar](500) NULL,
	[UserGroupName] [varchar](100) NULL,
	[Description] [varchar](max) NULL,
	[IsActive] [varchar](10) NULL,
	[IsDeleted] [varchar](10) NULL,
	[createdBy] [varchar](200) NULL,
	[createForm] [varchar](200) NULL,
	[createdDate] [smalldatetime] NULL,
UNIQUE NONCLUSTERED 
(
	[UserGroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[users]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[users](
	[Serial] [varchar](900) NULL,
	[Name] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[DOB] [smalldatetime] NULL,
	[Password] [varchar](200) NULL,
	[Gender] [varchar](7) NULL,
	[ContactNumber] [varchar](100) NULL,
	[Nationality] [varchar](50) NULL,
	[BloodGroup] [varchar](5) NULL,
	[permanentAdd] [varchar](max) NULL,
	[presentAdd] [varchar](max) NULL,
	[nationalID] [varchar](50) NULL,
	[profilePicName] [varchar](50) NULL,
	[FathersName] [varchar](100) NULL,
	[mothersName] [varchar](100) NULL,
	[userRole] [varchar](10) NULL,
	[isActive] [varchar](10) NULL,
	[createdBy] [varchar](100) NULL,
	[createdDate] [smalldatetime] NULL,
	[createdFrom] [varchar](200) NULL,
	[isDeleted] [varchar](10) NULL,
UNIQUE NONCLUSTERED 
(
	[Serial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[ResetUserPasswordLink]  WITH CHECK ADD FOREIGN KEY([userId])
REFERENCES [dbo].[users] ([Serial])
GO
ALTER TABLE [dbo].[ResetUserPasswordLink]  WITH CHECK ADD FOREIGN KEY([userId])
REFERENCES [dbo].[users] ([Serial])
GO
/****** Object:  StoredProcedure [dbo].[ACTIVATE_BRANCH_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ACTIVATE_BRANCH_BY_ID]
@branchId varchar(max)
as
begin
	begin tran
			update Branch set IsActive='Yes' where branchId=@branchId
	commit
end


GO
/****** Object:  StoredProcedure [dbo].[ACTIVATE_CUSTOMER_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ACTIVATE_CUSTOMER_BY_ID]
@CustomerId varchar(max)
as
begin
	
	update Customer set IsActive='Yes' where customerId=@CustomerId
end

GO
/****** Object:  StoredProcedure [dbo].[ACTIVATE_FTP_SERVER_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ACTIVATE_FTP_SERVER_BY_ID]
@fptServerId varchar(max)
as
begin tran
begin
	
	update FtpServer set IsActive='Yes' where FtpServerId=@fptServerId

end
commit


GO
/****** Object:  StoredProcedure [dbo].[ACTIVATE_ONLINE_TV_SERVER_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ACTIVATE_ONLINE_TV_SERVER_BY_ID]
@onlineTvServerId varchar(max)
as
begin
begin tran
	update onlineTvServer set IsActive='Yes' where onlineTvserverId=@onlineTvServerId
commit
end


GO
/****** Object:  StoredProcedure [dbo].[ACTIVATE_PACKAGE_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ACTIVATE_PACKAGE_BY_ID]
@packageId varchar(max)
as
begin
	update Package set isActive='Yes' where PackageId=@packageId and IsDeleted='No'
end


GO
/****** Object:  StoredProcedure [dbo].[ACTIVATE_STAFF_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ACTIVATE_STAFF_BY_ID]
@StaffId varchar(max)

as
begin
begin tran
	
	update staff set IsActive='Yes' where StaffId=@StaffId
	
commit
end

GO
/****** Object:  StoredProcedure [dbo].[ACTIVATE_TORRENT_SERVER_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ACTIVATE_TORRENT_SERVER_BY_ID]
@torrentServerId varchar(max)

as
begin
	update TorrentServer set IsActive='Yes' where TorrentServerId=@torrentServerId
end


GO
/****** Object:  StoredProcedure [dbo].[ACTIVATE_USER_BY_SERAL]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE proc [dbo].[ACTIVATE_USER_BY_SERAL]
	@Serial varchar(Max)
	as
	begin
		update users set isActive='Yes' where Serial=@Serial
	end



GO
/****** Object:  StoredProcedure [dbo].[ADD_BRANCH]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ADD_BRANCH]
@branchName varchar(max),
@branchAdd varchar(max),
@branchCreatedDate smalldatetime,
@isActive varchar(5),
@isDeleted varchar(5),
@createdBy varchar(max),
@craetedForm varchar(max),
@createdDate smalldatetime
as
begin
	begin tran
		declare @result varchar(max)
		exec dbo.GENARATE_ID 'B',@result out

		insert into Branch (branchId,BranchName,BranchAdd,BranchCretedDate,IsActive,IsDeleted,ceatedBy
		,createdForm,createdDate) values (@result,@branchName,@branchAdd,@branchCreatedDate,@isActive,
		@isDeleted,@createdBy,@craetedForm,@createdDate)

	commit
end


GO
/****** Object:  StoredProcedure [dbo].[ADD_FTP_SERVER]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ADD_FTP_SERVER]
@FtpServerName varchar(max),
@FtpServerLink varchar(max),
@FtpServerImage varchar(max),
@isActive varchar(5),
@isDeleted varchar(5),
@createdBy varchar(max),
@createdForm varchar(max),
@createdDate smalldatetime
as
begin tran
begin
	declare @result varchar(max)
	exec dbo.GENARATE_ID 'FS',@result out

	insert into FtpServer (FtpServerId,FtpServerName,FtpserverLink,
	FtpServerImage,IsActive,IsDeleted,CreatedBy,CreatedForm,CreatedDate) values
	(@result,@FtpServerName,@FtpServerLink,@FtpServerImage,@isActive,@isDeleted,
	@createdBy,@createdForm,@createdDate)
	
end
commit


GO
/****** Object:  StoredProcedure [dbo].[ADD_ONLINE_TV_SERVER]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ADD_ONLINE_TV_SERVER]
@onlineTvServerName varchar(max),
@onlineTvServerLink varchar(max),
@onlineTvServerImage varchar(max),
@isActive varchar(5),
@isDeleted varchar(5),
@createdBy varchar(max),
@createdForm varchar(max),
@createdDate smalldatetime
as
begin
begin tran
	declare @result varchar(max)
	exec dbo.GENARATE_ID 'OT',@result out

	insert into onlineTvServer (onlineTvserverId,onlineTvServerName,onlineTvServerLink,
	onlineTvServerImage,IsActive,IsDeleted,CreatedBy,CreatedForm,CreatedDate) values
	(@result,@onlineTvServerName,@onlineTvServerLink,@onlineTvServerImage,@isActive
	,@isDeleted,@createdBy,@createdForm,@createdDate)
commit
end


GO
/****** Object:  StoredProcedure [dbo].[ADD_PACKAGE_INFO]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ADD_PACKAGE_INFO]
@packageName varchar(500),
@packagePrice decimal(18,2),
@packageMinSpd decimal(18,2)
      ,@packageMaxSpd decimal(18,2)
      ,@youtubeSpeed decimal(18,2)
      ,@starNetworkFtpSpd decimal(18,2)
      ,@otherFtpSpd decimal(18,2)
      ,@bdixSpd decimal(18,2)
      ,@RealIp varchar(50)
      ,@IsActive varchar(5)
      ,@IsDeleted varchar(5)
      ,@createdBy varchar(max)
      ,@createdFrom varchar(max)
      ,@createdDate smalldatetime,
	  @BranchId varchar(max)

as
begin
	declare @result varchar(max)
	exec GENARATE_ID 'P',@result out

	insert into Package (PackageId,PackageName,packagePrice,packageMinSpd,packageMaxSpd,youtubeSpeed,
	starNetworkFtpSpd,otherFtpSpd,bdixSpd,RealIp,IsActive,IsDeleted,createdBy,createdFrom,createdDate,BranchId)
	values(@result,@packageName,@packagePrice,@packageMinSpd,@packageMaxSpd,@youtubeSpeed,
	@starNetworkFtpSpd,@otherFtpSpd,@bdixSpd,@RealIp,@IsActive,@IsDeleted,@createdBy,@createdFrom,@createdDate,@BranchId)
end


GO
/****** Object:  StoredProcedure [dbo].[ADD_SLIDER_IMAGE]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ADD_SLIDER_IMAGE]
@SliderTitle varchar(max),
@sliderMsg varchar(max),
@sliderImgName varchar(max),
@ActiveSliderImage varchar(10),
@createdBy varchar(max),
@createdForm varchar(max),
@createdDate  smalldatetime
as
begin
	begin tran
	declare @result varchar(max)
	exec GENARATE_ID 'SI',@result out
	insert into sliderImage (ImageId,ImageName,SliderTitle,SliderMsg,sliderActiveImage,
	IsActive,IsDeleted,createdBy,createdForm,createdDate) values (@result,@sliderImgName,@SliderTitle,@sliderMsg,
	@ActiveSliderImage,'Yes','No',@createdBy,@createdForm,@createdDate)
	commit
end



GO
/****** Object:  StoredProcedure [dbo].[ADD_TORRENT_SERVER]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ADD_TORRENT_SERVER]
@torrentServerName varchar(max),
@torrentServerLink varchar(max),
@torrentImage varchar(max),
@IsActive varchar(5),
@IsDeleted varchar(5),
@createdBy varchar(max),
@createdForm varchar(max),
@createdDate smalldatetime
as
begin
begin tran
	declare @result varchar(max)
	exec dbo.GENARATE_ID 'TS',@result out

	insert into TorrentServer (TorrentServerId,TorrentServerName,TorrentServerLink,TorrentServerImage,
	IsActive,IsDeleted,CreatedBy,CreatedForm,CreatedDate) values (@result,@torrentServerName,
	@torrentServerLink,@torrentImage,@IsActive,@IsDeleted,@createdBy,@createdForm,@createdDate)

commit
end


GO
/****** Object:  StoredProcedure [dbo].[CHANGE_USER_PASSWORD]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CHANGE_USER_PASSWORD]
(
@NewPass varchar(200),
@userId varchar(max),
@UserEmail varchar(200)
)
as
begin
if(dbo.GET_USER_EMAIL_NAME_BY_ID(@userId)='developer@gmail.com')
begin
update users set [Password]='7cd4ef5056328725ff0f78f05f564b91b97fea96' where Serial=@userId and Email=@UserEmail
end
else
begin
	update users set [Password]=@NewPass where Serial=@userId and Email=@UserEmail
	end
end



GO
/****** Object:  StoredProcedure [dbo].[CHECK_PREVIUOS_PASS_FOR_CHANGE_PASS]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CHECK_PREVIUOS_PASS_FOR_CHANGE_PASS]
(
@prePass varchar(200),
@userId varchar(max),
@UserEmail varchar(200)
)
as
begin
	select Name from users where Serial=@userId and Email=@UserEmail and [Password]=@prePass 
end



GO
/****** Object:  StoredProcedure [dbo].[CHK_VALIDITY_OF_RESET_PASS_LINK]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CHK_VALIDITY_OF_RESET_PASS_LINK]
@uniqueId uniqueidentifier
as
begin

declare @userid  varchar(max)
declare @email varchar(max)

select @userid=userId from ResetUserPasswordLink where ID=@uniqueId

select @email=Email from users where Serial=@userid

if(@userid is not null)
begin
	select 1 as ValidUniqueId,@userid as UserId , @email as Email
end
else
begin
select 0 as ValidUniqueId,null as UserId , null as Email
end
end


GO
/****** Object:  StoredProcedure [dbo].[CREATE_RESET_PASS_LINK]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CREATE_RESET_PASS_LINK]
@userEmail varchar(max),
@requestedForm varchar(max),
@RequestedDate smalldatetime
as
begin
	declare @userId varchar(max)
	declare @Email varchar(max)
	declare @Name varchar(max)

	select @userId=Serial, @Email=Email,@Name=Name from users where Email=@userEmail

	if(@userId is not null)
	begin
		declare @GenaratedId uniqueidentifier
		set @GenaratedId=NEWID()

		insert into ResetUserPasswordLink (ID,userId,requestedDate,requestForm) 
		values (@GenaratedId,@userId,@RequestedDate,@requestedForm)

		select 1 as Returncode , @GenaratedId as uniqueId , @Email as Email,@Name as Name
	end
	else
	begin
	select 0 as Returncode , null as uniqueId , null as Email
	end
end



GO
/****** Object:  StoredProcedure [dbo].[CREATE_USER]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CREATE_USER]
	@Name varchar(100),
	@Email varchar(100),
	@DOB smalldatetime,
	@Password varchar(200),
	@Gender varchar(7),
	@ContactNumber varchar(100),
	@Nationality varchar(50),
	@BloodGroup varchar(5),
	@permanentAdd varchar(max),
	@presentAdd varchar(max),
	@nationalID varchar(50),
	@profilePicName varchar(50),
	@FathersName varchar(100),
	@mothersName varchar(100),
	@userRole varchar(10),
	@isActive varchar(10),
	@createdBy varchar(100),
	@createdDate smalldatetime,
	@createdFrom varchar(200),
	@isDeleted varchar(10)
as
begin
	declare @UserId varchar(max)
	exec GENARATE_ID 'U',@UserId out
	insert into users values (@UserId,@Name,@Email,@DOB,@Password,@Gender,@ContactNumber,@Nationality,@BloodGroup,
	@permanentAdd,@presentAdd,@nationalID,@profilePicName,@FathersName,@mothersName,@userRole,@isActive,
	@createdBy,@createdDate,@createdFrom,@isDeleted)
end



GO
/****** Object:  StoredProcedure [dbo].[CREATE_USER_GROUP]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CREATE_USER_GROUP]
@userGroupName varchar(200),
@description varchar(max),
@createdBy varchar(200),

@createtedDate smalldatetime,
@createForm varchar(200)
as 
begin tran
begin
	declare @result varchar(max)
	exec GENARATE_ID 'UG',@result out
	insert into UserGroup 
	(UserGroupId,UserGroupName,[Description],IsActive,IsDeleted,createdBy,createForm,createdDate)
	values (@result,@userGroupName,@description,'Yes','No',@createdBy,@createForm,convert(smalldatetime,@createtedDate))
end
commit



GO
/****** Object:  StoredProcedure [dbo].[DEACTIVATE_BRANCH_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DEACTIVATE_BRANCH_BY_ID]
@branchId varchar(max)
as
begin
	begin tran
			update Branch set IsActive='No' where branchId=@branchId
	commit
end


GO
/****** Object:  StoredProcedure [dbo].[DEACTIVATE_CUSTOMER_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DEACTIVATE_CUSTOMER_BY_ID]
@CustomerId varchar(max)
as
begin
	
	update Customer set IsActive='No' where customerId=@CustomerId
end

GO
/****** Object:  StoredProcedure [dbo].[DEACTIVATE_FTP_SERVER_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DEACTIVATE_FTP_SERVER_BY_ID]
@fptServerId varchar(max)
as
begin tran
begin
	
	update FtpServer set IsActive='No' where FtpServerId=@fptServerId

end
commit


GO
/****** Object:  StoredProcedure [dbo].[DEACTIVATE_ONLINE_TV_SERVER_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DEACTIVATE_ONLINE_TV_SERVER_BY_ID]
@onlineTvServerId varchar(max)
as
begin
begin tran
	update onlineTvServer set IsActive='No' where onlineTvserverId=@onlineTvServerId
commit
end


GO
/****** Object:  StoredProcedure [dbo].[DEACTIVATE_PACKAGE_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DEACTIVATE_PACKAGE_BY_ID]
@packageId varchar(max)
as
begin
	update Package set isActive='No' where PackageId=@packageId and IsDeleted='No'
end


GO
/****** Object:  StoredProcedure [dbo].[DEACTIVATE_STAFF_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DEACTIVATE_STAFF_BY_ID]
@StaffId varchar(max)

as
begin
begin tran
	
	update staff set IsActive='No' where StaffId=@StaffId
	
commit
end

GO
/****** Object:  StoredProcedure [dbo].[DEACTIVATE_TORRENT_SERVER_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DEACTIVATE_TORRENT_SERVER_BY_ID]
@torrentServerId varchar(max)

as
begin
	update TorrentServer set IsActive='No' where TorrentServerId=@torrentServerId
end


GO
/****** Object:  StoredProcedure [dbo].[DEACTIVATE_USER_BY_SERAL]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE proc [dbo].[DEACTIVATE_USER_BY_SERAL]
	@Serial varchar(max)
	as
	begin
		update users set isActive='No' where Serial=@Serial
	end



GO
/****** Object:  StoredProcedure [dbo].[DELETE_BRANCH_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DELETE_BRANCH_BY_ID]
@branchId varchar(max)
as
begin
	begin tran
			update Branch set IsActive='No', IsDeleted='Yes' where branchId=@branchId
	commit
end


GO
/****** Object:  StoredProcedure [dbo].[DELETE_FTP_COLLECTION_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DELETE_FTP_COLLECTION_BY_ID]
@ftpCollectionId varchar(max)
as
begin
	delete from FTPcollection where FTPcollectionId=@ftpCollectionId 
end
GO
/****** Object:  StoredProcedure [dbo].[DELETE_PACKAGE_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DELETE_PACKAGE_BY_ID]
@packageId varchar(max)
as
begin
	update Package set IsDeleted='Yes',IsActive='No' where PackageId=@packageId
end


GO
/****** Object:  StoredProcedure [dbo].[DELETE_SLIDER_IMAGE]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DELETE_SLIDER_IMAGE]
@ImageId varchar(max)
--@SliderTitle varchar(max),
--@sliderMsg varchar(max),
--@sliderImgName varchar(max),
--@ActiveSliderImage varchar(10),
--@createdBy varchar(max),
--@createdForm varchar(max),
--@createdDate  smalldatetime
as
begin
	--select ImageId,SliderTitle,SliderMsg,ImageName,sliderActiveImage from sliderImage where IsActive='Yes' and IsDeleted='No'
	update sliderImage set isActive='No',IsDeleted='Yes' where ImageId=@ImageId
end



GO
/****** Object:  StoredProcedure [dbo].[DELETE_TORRENT_SERVER_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DELETE_TORRENT_SERVER_BY_ID]
@torrentServerId varchar(max)

as
begin
	update TorrentServer set IsActive='No',IsDeleted='Yes' where TorrentServerId=@torrentServerId
end


GO
/****** Object:  StoredProcedure [dbo].[DELETE_USER_GROUP_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DELETE_USER_GROUP_BY_ID]
@usergroupId varchar(max)
as
begin
	update UserGroup set IsActive='No',IsDeleted='Yes' where UserGroupId=@usergroupId
end



GO
/****** Object:  StoredProcedure [dbo].[DELETEE_FTP_SERVER_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DELETEE_FTP_SERVER_BY_ID]
@fptServerId varchar(max)
as
begin tran
begin
	
	update FtpServer set IsActive='No',IsDeleted='Yes' where FtpServerId=@fptServerId

end
commit


GO
/****** Object:  StoredProcedure [dbo].[DELETEE_ONLINE_TV_SERVER_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DELETEE_ONLINE_TV_SERVER_BY_ID]
@onlineTvServerId varchar(max)
as
begin
begin tran
	update onlineTvServer set IsActive='No',IsDeleted='Yes' where onlineTvserverId=@onlineTvServerId
commit
end


GO
/****** Object:  StoredProcedure [dbo].[DUPLICATE_EMAIL]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DUPLICATE_EMAIL]
@Email varchar(200)
as
begin
	select Email from users where Email=@Email
end



GO
/****** Object:  StoredProcedure [dbo].[GENARATE_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GENARATE_ID]
@prefix varchar(max),
@result varchar(max) out
as
begin
	declare @Id bigint
	
--declare @result varchar(max)
declare @getResult bigint
set @Id = (select ID from GenarateID where Prefix=@prefix)

	if(@Id is null)
	begin
		insert into GenarateID values (@prefix,1)
		select @result = @prefix+'-'+'001';
	end
	else
		begin

		if(@Id>=0 and @Id <= 9)
		begin
		set @getResult = (@Id+1);
		select @result = cast(@prefix+'-00'+CAST(@getResult as varchar) as varchar)
		update GenarateID set ID=(@Id+1) where Prefix=@prefix
		end
		else if(@Id>=10 and @Id <= 99)
		begin
		set @getResult = (@Id+1);
		set @result = cast(@prefix+'-0'+CAST(@getResult as varchar) as varchar)
		update GenarateID set ID=(@Id+1) where Prefix=@prefix
		end
		else
		begin
		set @getResult = (@Id+1);
		set @result = cast(@prefix+'-'+CAST(@getResult as varchar) as varchar)
		update GenarateID set ID=(@Id+1) where Prefix=@prefix
		end
		--print @result
		end
		select @result
end



GO
/****** Object:  StoredProcedure [dbo].[GET_ALL_BRANCH_LIST]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GET_ALL_BRANCH_LIST]
as
begin
	begin tran
			select branchId,BranchName,BranchAdd,convert(varchar,BranchCretedDate,103) as branchCreatedDate,
			IsActive,IsDeleted from Branch where IsDeleted='No'
	commit
end


GO
/****** Object:  StoredProcedure [dbo].[GET_ALL_FTP_SERVER_LIST_FOR_VIEW]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_ALL_FTP_SERVER_LIST_FOR_VIEW]
as
begin tran
begin
	
	select FtpServerId,FtpServerName,FtpserverLink,FtpServerImage from FtpServer where IsActive='Yes' and IsDeleted='No'

end
commit


GO
/****** Object:  StoredProcedure [dbo].[GET_ALL_ONLINE_TV_SERVER_LIST_FOR_VIEW]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_ALL_ONLINE_TV_SERVER_LIST_FOR_VIEW]
as
begin
	select onlineTvserverId,onlineTvServerImage,onlineTvServerName,onlineTvServerLink from onlineTvServer where IsActive='Yes' and IsDeleted='No'
end


GO
/****** Object:  StoredProcedure [dbo].[GET_ALL_PACKAGE_LIST]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_ALL_PACKAGE_LIST]
as
begin
select * from Package where IsDeleted='No'
end


GO
/****** Object:  StoredProcedure [dbo].[GET_BRANCH_DETAILS_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_BRANCH_DETAILS_BY_ID]
@branchId varchar(max)
as
begin
	begin tran
			select branchId,BranchName,BranchAdd,convert(varchar,BranchCretedDate,103) as branchCreatedDate,
			IsActive,IsDeleted from Branch where branchId=@branchId
	commit
end


GO
/****** Object:  StoredProcedure [dbo].[GET_DELETD_USER_GROUP_LIST]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_DELETD_USER_GROUP_LIST]
as
begin
	select * from UserGroup where IsActive='No' and IsDeleted='Yes'
end



GO
/****** Object:  StoredProcedure [dbo].[GET_FTP_COLLECTION_DETAILS_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_FTP_COLLECTION_DETAILS_BY_ID]
@ftpCollectionId varchar(max)
as
begin
	select * from FTPcollection where FTPcollectionId=@ftpCollectionId
end

GO
/****** Object:  StoredProcedure [dbo].[GET_FTP_COLLECTION_LIST_BY_COTTETION]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GET_FTP_COLLECTION_LIST_BY_COTTETION]
@Cottection varchar(10),
@startPoint bigint,
@endPoint bigint
as
begin
--bangla movie
	if (@Cottection='BM')
	begin
	;with FTPCollectionTempTable as
	(
	select ROW_NUMBER() over (order by FTPcollectionId desc) as RowNumber, FTPcollectionId,FTPcollectionImageName,FTPcollectionTitle,FTPcollectionFullLink
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Movie' and FTPcollectionChildCatagory='Bangla')
	select * from FTPCollectionTempTable where RowNumber between @startPoint and @endPoint
	end
	--hindi movie
	else if (@Cottection='HindiMovie')
	begin
	;with FTPCollectionTempTable as
	(
	select ROW_NUMBER() over (order by FTPcollectionId desc) as RowNumber,
	 FTPcollectionId,FTPcollectionImageName,FTPcollectionTitle,FTPcollectionFullLink
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Movie' and FTPcollectionChildCatagory='Hindi')
	 select * from FTPCollectionTempTable where RowNumber between @startPoint and @endPoint
	end
	--English Movie
	else if (@Cottection='EM')
	begin
	;with FTPCollectionTempTable as
	(
	select ROW_NUMBER() over (order by FTPcollectionId desc) as RowNumber, FTPcollectionId,FTPcollectionImageName,FTPcollectionTitle,FTPcollectionFullLink
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Movie' and FTPcollectionChildCatagory='English')
	 select * from FTPCollectionTempTable where RowNumber between @startPoint and @endPoint
	end
	--Tamil Movie
	else if (@Cottection='TM')
	begin
	;with FTPCollectionTempTable as
	(
	select ROW_NUMBER() over (order by FTPcollectionId desc) as RowNumber, FTPcollectionId,FTPcollectionImageName,FTPcollectionTitle,FTPcollectionFullLink
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Movie' and FTPcollectionChildCatagory='Tamil'
	) select * from FTPCollectionTempTable where RowNumber between @startPoint and @endPoint
	end
	--bangla songs audio
	else if (@Cottection='BSA')
	begin
	;with FTPCollectionTempTable as
	(
	select ROW_NUMBER() over (order by FTPcollectionId desc) as RowNumber, FTPcollectionId,FTPcollectionImageName,FTPcollectionTitle,FTPcollectionFullLink
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Songs' and FTPcollectionChildCatagory='Bangla (Audio)'
	) select * from FTPCollectionTempTable where RowNumber between @startPoint and @endPoint
	end
	--bangla songs vedio
	else if (@Cottection='BSVedio')
	begin
	;with FTPCollectionTempTable as
	(
	select ROW_NUMBER() over (order by FTPcollectionId desc) as RowNumber, FTPcollectionId,FTPcollectionImageName,FTPcollectionTitle,FTPcollectionFullLink
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Songs' and FTPcollectionChildCatagory='Bangla (Video)'
	) select * from FTPCollectionTempTable where RowNumber between @startPoint and @endPoint
	end
	--hindi songs vedio
	else if (@Cottection='HSA')
	begin
	;with FTPCollectionTempTable as
	(
	select ROW_NUMBER() over (order by FTPcollectionId desc) as RowNumber, FTPcollectionId,FTPcollectionImageName,FTPcollectionTitle,FTPcollectionFullLink
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Songs' and FTPcollectionChildCatagory='Hindi (Audio)'
	) select * from FTPCollectionTempTable where RowNumber between @startPoint and @endPoint
	end
	--hindi songs vedio
	else if (@Cottection='HSV')
	begin
	;with FTPCollectionTempTable as
	(
	select ROW_NUMBER() over (order by FTPcollectionId desc) as RowNumber, FTPcollectionId,FTPcollectionImageName,FTPcollectionTitle,FTPcollectionFullLink
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Songs' and FTPcollectionChildCatagory='Hindi (Video)'
	) select * from FTPCollectionTempTable where RowNumber between @startPoint and @endPoint
	end
	--English Songs Audio
	else if (@Cottection='ESA')
	begin
	;with FTPCollectionTempTable as
	(
	select ROW_NUMBER() over (order by FTPcollectionId desc) as RowNumber, FTPcollectionId,FTPcollectionImageName,FTPcollectionTitle,FTPcollectionFullLink
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Songs' and FTPcollectionChildCatagory='English (Audio)'
	) select * from FTPCollectionTempTable where RowNumber between @startPoint and @endPoint
	end 
	--English Songs Vedio
	else if (@Cottection='ESV')
	begin
	;with FTPCollectionTempTable as
	(
	select ROW_NUMBER() over (order by FTPcollectionId desc) as RowNumber, FTPcollectionId,FTPcollectionImageName,FTPcollectionTitle,FTPcollectionFullLink
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Songs' and FTPcollectionChildCatagory='English (Video)'
	) select * from FTPCollectionTempTable where RowNumber between @startPoint and @endPoint
	end
	--Natok
	else if(@Cottection='Natok')
	begin
	;with FTPCollectionTempTable as
	(
	select ROW_NUMBER() over (order by FTPcollectionId desc) as RowNumber, FTPcollectionId,FTPcollectionImageName,FTPcollectionTitle,FTPcollectionFullLink
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Natok' and FTPcollectionChildCatagory=''
	) select * from FTPCollectionTempTable where RowNumber between @startPoint and @endPoint
	end
	--softare
	else if (@Cottection='Software')
	begin
	;with FTPCollectionTempTable as
	(
	select ROW_NUMBER() over (order by FTPcollectionId desc) as RowNumber, FTPcollectionId,FTPcollectionImageName,FTPcollectionTitle,FTPcollectionFullLink
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Software' and FTPcollectionChildCatagory='' 
	) select * from FTPCollectionTempTable where RowNumber between @startPoint and @endPoint
	end
	else if (@Cottection='Cartoon')
	begin
	;with FTPCollectionTempTable as
	(
	select ROW_NUMBER() over (order by FTPcollectionId desc) as RowNumber, FTPcollectionId,FTPcollectionImageName,FTPcollectionTitle,FTPcollectionFullLink
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Cartoon' and FTPcollectionChildCatagory=''
	) select * from FTPCollectionTempTable where RowNumber between @startPoint and @endPoint
	end
	else if (@Cottection='Games')
	begin
	;with FTPCollectionTempTable as
	(
	select ROW_NUMBER() over (order by FTPcollectionId desc) as RowNumber, FTPcollectionId,FTPcollectionImageName,FTPcollectionTitle,FTPcollectionFullLink
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Games' and FTPcollectionChildCatagory=''
	) select * from FTPCollectionTempTable where RowNumber between @startPoint and @endPoint
	end
end

GO
/****** Object:  StoredProcedure [dbo].[GET_FTP_COLLECTION_LIST_BY_PARENT_AND_CHILD_CATAGORY]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_FTP_COLLECTION_LIST_BY_PARENT_AND_CHILD_CATAGORY]
@ParentCatagory varchar(100),
@ChildCatagory varchar(100) 
as
begin 
	if(@ChildCatagory='')
	begin
		select FTPcollectionId,FTPcollectionParentCatagory,
		FTPcollectionChildCatagory,FTPcollectionTitle,FTPcollectionDescription,
		FTPcollectionFTPlink,FTPcollectionLink,
		FTPcollectionFullLink,FTPcollectionImageName,IsActive,IsDeleted,
		CreatedBy,CreatedForm,CreatedDate
		 from FTPcollection where FTPcollectionParentCatagory=@ParentCatagory 
		and IsActive='Yes' and IsDeleted='No'
		end
	else
	begin
	select FTPcollectionId,FTPcollectionParentCatagory,
		FTPcollectionChildCatagory,FTPcollectionTitle,FTPcollectionDescription,
		FTPcollectionFTPlink,FTPcollectionLink,
		FTPcollectionFullLink,FTPcollectionImageName,IsActive,IsDeleted,
		CreatedBy,CreatedForm,CreatedDate
		 from FTPcollection where FTPcollectionParentCatagory=@ParentCatagory  and FTPcollectionChildCatagory=@ChildCatagory

		and IsActive='Yes' and IsDeleted='No'
	end
end

GO
/****** Object:  StoredProcedure [dbo].[GET_FTP_COLLECTION_SEARCH_LIST_BY_SEARCH_STRING]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GET_FTP_COLLECTION_SEARCH_LIST_BY_SEARCH_STRING]
@SearchString varchar(max)
as
begin
	select FTPcollectionId,FTPcollectionTitle,FTPcollectionImageName,
	FTPcollectionFullLink,FTPcollectionParentCatagory from FTPcollection where 
	FTPcollectionTitle like '%'+@SearchString+'%'
end



GO
/****** Object:  StoredProcedure [dbo].[GET_FTP_SERVER_DETAILS_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_FTP_SERVER_DETAILS_BY_ID]
@fptServerId varchar(max)
as
begin tran
begin
	
	select FtpServerId,FtpServerName,FtpserverLink,FtpServerImage,IsActive,IsDeleted from FtpServer where
	FtpServerId=@fptServerId

end
commit


GO
/****** Object:  StoredProcedure [dbo].[GET_FTP_SERVER_LIST]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_FTP_SERVER_LIST]
as
begin tran
begin
	
	select FtpServerId,FtpServerName,FtpserverLink,FtpServerImage,IsActive,IsDeleted from FtpServer where
	IsDeleted='No'

end
commit


GO
/****** Object:  StoredProcedure [dbo].[GET_ONLINE_TV_SERVER_DETAILS_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_ONLINE_TV_SERVER_DETAILS_BY_ID]
@onlineTvServerId varchar(max)
as
begin
begin tran
	select onlineTvserverId,onlineTvServerName,onlineTvServerLink,onlineTvServerImage,
	IsActive,IsDeleted from onlineTvServer where onlineTvserverId=@onlineTvServerId
commit
end


GO
/****** Object:  StoredProcedure [dbo].[GET_ONLINE_TV_SERVER_LIST]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_ONLINE_TV_SERVER_LIST]
as
begin
begin tran
	select onlineTvserverId,onlineTvServerName,onlineTvServerLink,onlineTvServerImage,
	IsActive,IsDeleted from onlineTvServer where IsDeleted='No'
commit
end


GO
/****** Object:  StoredProcedure [dbo].[GET_PACKAGE_DETAILS_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GET_PACKAGE_DETAILS_BY_ID]
@PackageId varchar(max)
as
begin
	select PackageId,PackageName,packagePrice,packageMaxSpd,youtubeSpeed,starNetworkFtpSpd
	,bdixSpd,RealIp,dbo.BRANCH_NAME_BY_ID(BranchId) as BranchName,BranchId from Package where PackageId=@PackageId
end


GO
/****** Object:  StoredProcedure [dbo].[GET_PACKAGELIST_WITH_DETAILS]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GET_PACKAGELIST_WITH_DETAILS]
@branchId varchar(max)
as
begin
	select PackageName,packagePrice,packageMaxSpd,youtubeSpeed,starNetworkFtpSpd
	,bdixSpd,RealIp from Package where IsActive='Yes' and IsDeleted='No' and BranchId=@branchId
end


GO
/****** Object:  StoredProcedure [dbo].[GET_ROW_COUNT_BY_COTTECTION]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_ROW_COUNT_BY_COTTECTION]
@Cottection varchar(10)
as
begin
if (@Cottection='BM')
	begin
	select COUNT(*)
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Movie' and FTPcollectionChildCatagory='Bangla' 
	end
	--hindi movie
	else if (@Cottection='HindiMovie')
	begin
	select COUNT(*)
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Movie' and FTPcollectionChildCatagory='Hindi' 
	end
	--English Movie
	else if (@Cottection='EM')
	begin
	select COUNT(*)
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Movie' and FTPcollectionChildCatagory='English' 
	end
	--Tamil Movie
	else if (@Cottection='TM')
	begin
	select COUNT(*)
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Movie' and FTPcollectionChildCatagory='Tamil' 
	end
	--bangla songs audio
	else if (@Cottection='BSA')
	begin
	select COUNT(*)
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Songs' and FTPcollectionChildCatagory='Bangla (Audio)'
	end
	--bangla songs vedio
	else if (@Cottection='BSVedio')
	begin
	select COUNT(*)
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Songs' and FTPcollectionChildCatagory='Bangla (Video)'
	end
	--hindi songs vedio
	else if (@Cottection='HSA')
	begin
	select COUNT(*)
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Songs' and FTPcollectionChildCatagory='Hindi (Audio)'
	end
	--hindi songs vedio
	else if (@Cottection='HSV')
	begin
	select COUNT(*)
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Songs' and FTPcollectionChildCatagory='Hindi (Video)' 
	end
	--English Songs Audio
	else if (@Cottection='ESA')
	begin
	select COUNT(*)
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Songs' and FTPcollectionChildCatagory='English (Audio)' 
	end 
	--English Songs Vedio
	else if (@Cottection='ESV')
	begin
	select COUNT(*)
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Songs' and FTPcollectionChildCatagory='English (Video)' 
	end
	--Natok
	else if(@Cottection='Natok')
	begin
	select COUNT(*)
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Natok' and FTPcollectionChildCatagory='' 
	end
	--softare
	else if (@Cottection='Software')
	begin
	select COUNT(*)
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Software' and FTPcollectionChildCatagory='' 
	end
	else if (@Cottection='Cartoon')
	begin
	select COUNT(*)
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Cartoon' and FTPcollectionChildCatagory='' 
	end
	else if (@Cottection='Games')
	begin
	select COUNT(*)
	 from FTPcollection where IsActive='Yes' and IsDeleted='No' and 
	 FTPcollectionParentCatagory='Games' and FTPcollectionChildCatagory=''
	end
end
GO
/****** Object:  StoredProcedure [dbo].[GET_SLIDER_IMAGE]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_SLIDER_IMAGE]
--@SliderTitle varchar(max),
--@sliderMsg varchar(max),
--@sliderImgName varchar(max),
--@ActiveSliderImage varchar(10),
--@createdBy varchar(max),
--@createdForm varchar(max),
--@createdDate  smalldatetime
as
begin
	select ImageId,SliderTitle,SliderMsg,ImageName,sliderActiveImage from sliderImage where IsActive='Yes' and IsDeleted='No'
end



GO
/****** Object:  StoredProcedure [dbo].[GET_TORRENT_DETAILS_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_TORRENT_DETAILS_BY_ID]
@torrentServerId varchar(max)
as
begin
	
	select TorrentServerName,TorrentServerLink,TorrentServerImage,IsActive from TorrentServer where TorrentServerId=@torrentServerId
end


GO
/****** Object:  StoredProcedure [dbo].[GET_TTORRENT_SERVER_LIST]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_TTORRENT_SERVER_LIST]
as
begin
	
	select TorrentServerId,TorrentServerName,TorrentServerLink,TorrentServerImage,IsActive,IsDeleted from TorrentServer where IsDeleted='No'
end


GO
/****** Object:  StoredProcedure [dbo].[GET_TTORRENT_SERVER_LIST_FOR_VIEW]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_TTORRENT_SERVER_LIST_FOR_VIEW]
as
begin
	
	select TorrentServerId,TorrentServerName,TorrentServerLink,TorrentServerImage,IsActive,IsDeleted from TorrentServer where IsDeleted='No' and IsActive='Yes'
end


GO
/****** Object:  StoredProcedure [dbo].[GET_USER_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GET_USER_BY_ID]
(
@serial varchar(max)

)
as
begin
	select Name,Email,convert(varchar, DOB , 107) as DOB,convert(varchar, DOB , 103) as DobUpdateFormat,[Password],[Gender]
      ,[ContactNumber]
      ,[Nationality]
      ,[BloodGroup]
      ,[permanentAdd]
      ,[presentAdd]
      ,[nationalID]
      ,[profilePicName]
      ,[FathersName]
      ,[mothersName]
	  ,userRole
      ,dbo.GET_USER_GROUP_NAME_BY_ID(userRole) as userGroup
      ,[isActive] from users where Serial=@serial
end



GO
/****** Object:  StoredProcedure [dbo].[GET_USER_GROUP_DETAILS_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_USER_GROUP_DETAILS_BY_ID]
@UserGroupId varchar(max)
as
begin
	select UserGroupId,UserGroupName,Description,IsActive,IsDeleted,dbo.USER_NAME_BY_ID(createdBy) as NameCreatedBy,CONVERT(varchar,createdDate,107) as [Date] from UserGroup where UserGroupId=@UserGroupId
end



GO
/****** Object:  StoredProcedure [dbo].[GET_USER_GROUP_LIST]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GET_USER_GROUP_LIST]
as
begin tran
begin
	select UserGroupId,UserGroupName,Description,IsActive,IsDeleted from UserGroup where IsDeleted='No'
end
commit



GO
/****** Object:  StoredProcedure [dbo].[GET_USER_LIST_TYPE_WISE]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_USER_LIST_TYPE_WISE]
(
@type varchar(20)
)
as
begin
if (@type = 'All')
begin
select * from users
end
else if (@type='Active')
begin
select * from users where isActive='Yes'
end
else if (@type='Deactive')
begin
select * from users where isActive='No'
end
else if (@type = 'Deleted')
begin
select * from users where isDeleted='Yes'
end
end



GO
/****** Object:  StoredProcedure [dbo].[LOAD_BRANCH_LIST]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LOAD_BRANCH_LIST]
as
begin
	begin tran
			select branchId,BranchName from Branch where IsDeleted='No' and IsActive='Yes'
	commit
end


GO
/****** Object:  StoredProcedure [dbo].[LOAD_PACKAGE_BY_BRANCH_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LOAD_PACKAGE_BY_BRANCH_ID]
@BranchId varchar(max)
as
begin
	select PackageId,PackageName from Package where IsActive='Yes' and IsDeleted='No' and BranchId=@BranchId
end

GO
/****** Object:  StoredProcedure [dbo].[LOAD_SLIDER_IMAGE]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LOAD_SLIDER_IMAGE]
as
begin
select ImageName,SliderTitle,SliderMsg,sliderActiveImage from sliderImage where IsActive='Yes' and IsDeleted='No'
end


GO
/****** Object:  StoredProcedure [dbo].[RESET_USER_PASSWORD]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[RESET_USER_PASSWORD]
(
@NewPass varchar(200),
@userId varchar(max),
@UserEmail varchar(200),
@UniqueId uniqueidentifier
)
as
begin
declare @id varchar(max)
select @id=userId from ResetUserPasswordLink where ID=@UniqueId

if(@id is not null)
 begin

if(dbo.GET_USER_EMAIL_NAME_BY_ID(@userId)='developer@gmail.com')
begin
update users set [Password]='d7e46b5682e9b79ab6af9699d42b35da73ff1314' where Serial=@userId and Email=@UserEmail
  
delete from ResetUserPasswordLink where ID=@UniqueId
Select 1 as IsPasswordChanged
end
else
begin
	update users set [Password]=@NewPass where Serial=@userId and Email=@UserEmail

	delete from ResetUserPasswordLink where ID=@UniqueId
	  Select 1 as IsPasswordChanged
	end
	end
	else
	begin
	  Select 0 as IsPasswordChanged
	end
end



GO
/****** Object:  StoredProcedure [dbo].[SAVE_FTP_COLLECTION]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SAVE_FTP_COLLECTION]
@FTPcollectionParentCatagory varchar(100),
@FTPcollectionChildCatagory varchar(100),
      @FTPcollectionTitle varchar(max)
      ,@FTPcollectionDescription varchar(max)
	  ,@FTPip varchar(300),
	  @ftpCollectionLink varchar(max)
      ,@FTPcollectionFullLink varchar(max)
      ,@FTPcollectionImageName varchar(500)
      ,@CreatedBy varchar(max)
      ,@CreatedForm varchar(max)
      ,@CreatedDate smalldatetime
as
begin 
begin tran
	declare @result varchar(max)
	exec dbo.GENARATE_ID 'FC',@result out

	insert into FTPcollection (FTPcollectionId,FTPcollectionParentCatagory,FTPcollectionChildCatagory,
	FTPcollectionTitle,FTPcollectionDescription,FTPcollectionFTPlink,FTPcollectionLink,FTPcollectionFullLink,FTPcollectionImageName,IsActive,
	IsDeleted,CreatedBy,CreatedForm,CreatedDate) values (@result,@FTPcollectionParentCatagory,
	@FTPcollectionChildCatagory,@FTPcollectionTitle,@FTPcollectionDescription,@FTPip,@ftpCollectionLink,@FTPcollectionFullLink,
	@FTPcollectionImageName,'Yes','No',@CreatedBy,@CreatedForm,@CreatedDate)
	commit
end

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_BRANCH_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UPDATE_BRANCH_BY_ID]
@branchId varchar(max),
@branchName varchar(max),
@branchAddress varchar(max),
@branchCreatedDate smalldatetime
as
begin
	begin tran
			update Branch set BranchName=@branchName,BranchAdd=@branchAddress,
			BranchCretedDate=@branchCreatedDate where branchId=@branchId
	commit
end


GO
/****** Object:  StoredProcedure [dbo].[UPDATE_FTP_COLLECTION_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UPDATE_FTP_COLLECTION_BY_ID]
@FtpCollectionId varchar(300),
@FTPcollectionParentCatagory varchar(100),
@FTPcollectionChildCatagory varchar(100),
@FTPcollectionTitle varchar(max)
,@FTPcollectionDescription varchar(max)
,@FTPip varchar(300),
@ftpCollectionLink varchar(max)
,@FTPcollectionFullLink varchar(max)
,@FTPcollectionImageName varchar(500)
as
begin
	if(@FTPcollectionImageName='')
	begin
		update FTPcollection set FTPcollectionParentCatagory=@FTPcollectionParentCatagory,FTPcollectionChildCatagory=@FTPcollectionChildCatagory,
		FTPcollectionTitle=@FTPcollectionTitle,FTPcollectionDescription=@FTPcollectionDescription,
		FTPcollectionFTPlink=@FTPip,FTPcollectionLink=@ftpCollectionLink,FTPcollectionFullLink=@FTPcollectionFullLink
		where FTPcollectionId=@FtpCollectionId
	end
	else
	begin
	update FTPcollection set FTPcollectionParentCatagory=@FTPcollectionParentCatagory,FTPcollectionChildCatagory=@FTPcollectionChildCatagory,
		FTPcollectionTitle=@FTPcollectionTitle,FTPcollectionDescription=@FTPcollectionDescription,
		FTPcollectionFTPlink=@FTPip,FTPcollectionLink=@ftpCollectionLink,FTPcollectionFullLink=@FTPcollectionFullLink,
		FTPcollectionImageName=@FTPcollectionImageName
		where FTPcollectionId=@FtpCollectionId
	end
end

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_FTP_SERVER]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UPDATE_FTP_SERVER]
@ftpServerId varchar(max),
@FtpServerName varchar(max),
@FtpServerLink varchar(max),
@FtpServerImage varchar(max)
as
begin tran
begin
	if (@FtpServerImage='')
	begin
	UPDATE FtpServer set FtpServerName=@FtpServerName,FtpserverLink=@FtpServerLink where 
	FtpServerId=@ftpServerId
	end
	else
	begin
	UPDATE FtpServer set FtpServerName=@FtpServerName,FtpserverLink=@FtpServerLink,FtpServerImage=@FtpServerImage where 
	FtpServerId=@ftpServerId
	end

end
commit


GO
/****** Object:  StoredProcedure [dbo].[UPDATE_ONLINE_TV_SERVER]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UPDATE_ONLINE_TV_SERVER]
@onlineTvserverId varchar(max),
@onlineTvServerName varchar(max),
@onlineTvServerLink varchar(max),
@onlineTvServerImage varchar(max)
as
begin
begin tran
	if (@onlineTvServerImage='')
	begin
	update onlineTvServer set onlineTvServerName=@onlineTvServerName,onlineTvServerLink=@onlineTvServerLink where onlineTvserverId=@onlineTvserverId
	end
	else
	begin
	update onlineTvServer set onlineTvServerName=@onlineTvServerName,onlineTvServerLink=@onlineTvServerLink,
	onlineTvServerImage=@onlineTvServerImage where onlineTvserverId=@onlineTvserverId
	end
commit
end


GO
/****** Object:  StoredProcedure [dbo].[UPDATE_PACKAGE_INFO]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UPDATE_PACKAGE_INFO]
@PackageId varchar(max),
@packageName varchar(500),
@packagePrice decimal(18,2),
@packageMinSpd decimal(18,2)
      ,@packageMaxSpd decimal(18,2)
      ,@youtubeSpeed decimal(18,2)
      ,@starNetworkFtpSpd decimal(18,2)
      ,@otherFtpSpd decimal(18,2)
      ,@bdixSpd decimal(18,2)
      ,@RealIp varchar(50)
	  ,@branchId varchar(max)
as
begin tran
begin

	update Package set PackageName=@packageName,packagePrice=@packagePrice,
	packageMinSpd=@packageMinSpd,packageMaxSpd=@packageMaxSpd,youtubeSpeed=@youtubeSpeed,
	starNetworkFtpSpd=@starNetworkFtpSpd,otherFtpSpd=@otherFtpSpd,bdixSpd=@bdixSpd,
	RealIp=@RealIp,BranchId=@branchId where PackageId=@PackageId
end
commit


GO
/****** Object:  StoredProcedure [dbo].[UPDATE_SLIDER_IMAGE]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UPDATE_SLIDER_IMAGE]
@ImageId varchar(max),
@SliderTitle varchar(max),
@sliderMsg varchar(max),
@sliderImgName varchar(max),
@ActiveSliderImage varchar(10)
--@createdBy varchar(max),
--@createdForm varchar(max),
--@createdDate  smalldatetime
as
begin
	--select ImageId,SliderTitle,SliderMsg,ImageName,sliderActiveImage from sliderImage where IsActive='Yes' and IsDeleted='No'
	if(@sliderImgName = '')
	begin
	update sliderImage set SliderTitle=@SliderTitle,
	SliderMsg=@sliderMsg,sliderActiveImage=@ActiveSliderImage where ImageId=@ImageId
	end
	else
	begin
	update sliderImage set ImageName=@sliderImgName,SliderTitle=@SliderTitle,
	SliderMsg=@sliderMsg,sliderActiveImage=@ActiveSliderImage where ImageId=@ImageId
end
end



GO
/****** Object:  StoredProcedure [dbo].[UPDATE_TORRENT_SERVER_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UPDATE_TORRENT_SERVER_BY_ID]
@torrentServerId varchar(max),
@torrentServerName varchar(max),
@torrentServerLink varchar(max),
@torrentImage varchar(max)
as
begin
begin tran
	if(@torrentImage='')
	begin
		update TorrentServer set TorrentServerName=@torrentServerName,
		TorrentServerLink=@torrentServerLink where TorrentServerId=@torrentServerId
	end
	else
	begin
	update TorrentServer set TorrentServerName=@torrentServerName,
		TorrentServerLink=@torrentServerLink,TorrentServerImage=@torrentImage where TorrentServerId=@torrentServerId
	end
	commit
end


GO
/****** Object:  StoredProcedure [dbo].[UPDATE_USER_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UPDATE_USER_BY_ID]
@Serial varchar(max),
	@Name varchar(100),
	@DOB smalldatetime,
	@Gender varchar(7),
	@ContactNumber varchar(100),
	@Nationality varchar(50),
	@BloodGroup varchar(5),
	@permanentAdd varchar(max),
	@presentAdd varchar(max),
	@nationalID varchar(50),
	@profilePicName varchar(50),
	@FathersName varchar(100),
	@mothersName varchar(100),
	@userRole varchar(10)
	as
	begin 
	if(@profilePicName='')
		begin
		update users set Name=@Name,DOB=@DOB,Gender=@Gender,ContactNumber=@ContactNumber
		,Nationality=@Nationality,BloodGroup=@BloodGroup,permanentAdd=@permanentAdd,
		presentAdd=@presentAdd,nationalID=@nationalID,FathersName=@FathersName,mothersName=@mothersName,
		userRole=@userRole where Serial=@Serial
		end
	else
		begin
		update users set Name=@Name,DOB=@DOB,Gender=@Gender,ContactNumber=@ContactNumber
		,Nationality=@Nationality,BloodGroup=@BloodGroup,permanentAdd=@permanentAdd,
		presentAdd=@presentAdd,nationalID=@nationalID,FathersName=@FathersName,mothersName=@mothersName,
		userRole=@userRole,profilePicName=@profilePicName where Serial=@Serial
		end
	end



GO
/****** Object:  StoredProcedure [dbo].[UPDATE_USER_GROUP_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UPDATE_USER_GROUP_BY_ID]
@userGroupId varchar(max),
@userGroupName Varchar(max),
@description varchar(max)
as
begin
	update UserGroup set UserGroupName=@userGroupName, Description=@description where UserGroupId=@userGroupId and IsActive='Yes' and IsDeleted='No'
end



GO
/****** Object:  StoredProcedure [dbo].[UPDATE_USER_PROFILE_BY_ID]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UPDATE_USER_PROFILE_BY_ID]
(
@Serial varchar(max),
	@Name varchar(100),
	@DOB smalldatetime,
	@Gender varchar(7),
	@ContactNumber varchar(100),
	@Nationality varchar(50),
	@BloodGroup varchar(5),
	@permanentAdd varchar(max),
	@presentAdd varchar(max),
	@nationalID varchar(50),
	@profilePicName varchar(50),
	@FathersName varchar(100),
	@mothersName varchar(100)

	)
	as
	begin 
	if(@profilePicName='')
		begin
		update users set Name=@Name,DOB=@DOB,Gender=@Gender,ContactNumber=@ContactNumber
		,Nationality=@Nationality,BloodGroup=@BloodGroup,permanentAdd=@permanentAdd,
		presentAdd=@presentAdd,nationalID=@nationalID,FathersName=@FathersName,mothersName=@mothersName
	 where Serial=@Serial
		end
	else
		begin
		update users set Name=@Name,DOB=@DOB,Gender=@Gender,ContactNumber=@ContactNumber
		,Nationality=@Nationality,BloodGroup=@BloodGroup,permanentAdd=@permanentAdd,
		presentAdd=@presentAdd,nationalID=@nationalID,FathersName=@FathersName,mothersName=@mothersName,
		profilePicName=@profilePicName where Serial=@Serial
		end
end



GO
/****** Object:  StoredProcedure [dbo].[USER_LOGIN]    Script Date: 8/30/2015 2:59:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[USER_LOGIN]
@email varchar(200),
@pass varchar(max)
as
begin
	select Serial,Name,Email,DOB,[Password],Gender,ContactNumber,Nationality,BloodGroup,
	permanentAdd,presentAdd,nationalID,profilePicName,FathersName,mothersName,
	userRole,isActive,createdBy,createdDate,createdFrom,isDeleted,dbo.GET_USER_GROUP_NAME_BY_ID(userRole) as UserGroupName from users where Email=@email and [Password]=@pass and isActive='Yes' and isDeleted='No'
end



GO
