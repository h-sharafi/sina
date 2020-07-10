using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class skj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    DisplayName = table.Column<string>(nullable: true),
                    CreationDateTime = table.Column<DateTime>(nullable: false),
                    AboutUsId = table.Column<short>(nullable: true),
                    AccessAbleFileId = table.Column<short>(nullable: true),
                    ActionDataId = table.Column<short>(nullable: true),
                    AudioCmsId = table.Column<short>(nullable: true),
                    CommentId = table.Column<short>(nullable: true),
                    ContentId = table.Column<short>(nullable: true),
                    ContentTypeId = table.Column<short>(nullable: true),
                    ControllerDataId = table.Column<short>(nullable: true),
                    FileCategoryId = table.Column<short>(nullable: true),
                    FileId = table.Column<short>(nullable: true),
                    ImageCmsId = table.Column<short>(nullable: true),
                    ImageCmsTypeId = table.Column<short>(nullable: true),
                    LoggingEventId = table.Column<int>(nullable: true),
                    PaperId = table.Column<short>(nullable: true),
                    PodcastId = table.Column<short>(nullable: true),
                    SideBarId = table.Column<short>(nullable: true),
                    SiteDetailId = table.Column<short>(nullable: true),
                    SiteSettingId = table.Column<short>(nullable: true),
                    SliderId = table.Column<short>(nullable: true),
                    SliderTypeId = table.Column<short>(nullable: true),
                    SocialClassId = table.Column<short>(nullable: true),
                    SocialNetworkId = table.Column<short>(nullable: true),
                    TeamId = table.Column<short>(nullable: true),
                    UploadInfoId = table.Column<short>(nullable: true),
                    VideoId = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccessAbleFiless",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessAbleFiless", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccessAbleFiless_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentTypes",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsMainPage = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContentTypes_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ControllerDatas",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    ControllerName = table.Column<string>(nullable: true),
                    ControllerIcon = table.Column<string>(nullable: true),
                    ControllerNameLocalized = table.Column<string>(nullable: true),
                    ControllerNamespace = table.Column<string>(nullable: true),
                    RequiresAuthorization = table.Column<bool>(nullable: false),
                    Key = table.Column<string>(nullable: true),
                    IsDontSideBarShow = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControllerDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControllerDatas_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FileCategorys",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ParentId = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileCategorys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileCategorys_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FileCategorys_FileCategorys_ParentId",
                        column: x => x.ParentId,
                        principalTable: "FileCategorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImageCmsTypes",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    HtmlText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageCmsTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageCmsTypes_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LoggingEvents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    LogType = table.Column<int>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Result = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoggingEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoggingEvents_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoggingEvents_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Papers",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Papers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Papers_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Podcasts",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Podcasts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Podcasts_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SideBars",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    ParentId = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SideBars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SideBars_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SideBars_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SideBars_SideBars_ParentId",
                        column: x => x.ParentId,
                        principalTable: "SideBars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SiteDetails",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SiteDetails_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SliderTypes",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SampleHtml = table.Column<string>(nullable: true),
                    Interval = table.Column<short>(nullable: false),
                    Keyboard = table.Column<bool>(nullable: false),
                    SliderCarouselType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SliderTypes_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SocialClasses",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    FaClass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialClasses_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Videos_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccessAbleFileModifiedUser",
                columns: table => new
                {
                    AppUserId = table.Column<string>(nullable: false),
                    EntityId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessAbleFileModifiedUser", x => new { x.AppUserId, x.EntityId });
                    table.ForeignKey(
                        name: "FK_AccessAbleFileModifiedUser_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccessAbleFileModifiedUser_AccessAbleFiless_EntityId",
                        column: x => x.EntityId,
                        principalTable: "AccessAbleFiless",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActionDatas",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    ActionName = table.Column<string>(nullable: true),
                    ActionNameLocalized = table.Column<string>(nullable: true),
                    ActionIcon = table.Column<string>(nullable: true),
                    AllowAnonymous = table.Column<bool>(nullable: false),
                    RequiresAuthorization = table.Column<bool>(nullable: false),
                    RequiresHttpPost = table.Column<bool>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    Key = table.Column<string>(nullable: true),
                    IsDontSideBarShow = table.Column<bool>(nullable: false),
                    ControllerDataId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActionDatas_ControllerDatas_ControllerDataId",
                        column: x => x.ControllerDataId,
                        principalTable: "ControllerDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActionDatas_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ControllerDataModifiedUser",
                columns: table => new
                {
                    AppUserId = table.Column<string>(nullable: false),
                    EntityId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControllerDataModifiedUser", x => new { x.AppUserId, x.EntityId });
                    table.ForeignKey(
                        name: "FK_ControllerDataModifiedUser_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ControllerDataModifiedUser_ControllerDatas_EntityId",
                        column: x => x.EntityId,
                        principalTable: "ControllerDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaperModifiedUser",
                columns: table => new
                {
                    AppUserId = table.Column<string>(nullable: false),
                    EntityId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaperModifiedUser", x => new { x.AppUserId, x.EntityId });
                    table.ForeignKey(
                        name: "FK_PaperModifiedUser_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaperModifiedUser_Papers_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Papers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PodcastModifiedUser",
                columns: table => new
                {
                    AppUserId = table.Column<string>(nullable: false),
                    EntityId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PodcastModifiedUser", x => new { x.AppUserId, x.EntityId });
                    table.ForeignKey(
                        name: "FK_PodcastModifiedUser_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PodcastModifiedUser_Podcasts_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Podcasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteDetailModifiedUser",
                columns: table => new
                {
                    AppUserId = table.Column<string>(nullable: false),
                    EntityId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteDetailModifiedUser", x => new { x.AppUserId, x.EntityId });
                    table.ForeignKey(
                        name: "FK_SiteDetailModifiedUser_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiteDetailModifiedUser_SiteDetails_EntityId",
                        column: x => x.EntityId,
                        principalTable: "SiteDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SliderTypeId = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sliders_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sliders_SliderTypes_SliderTypeId",
                        column: x => x.SliderTypeId,
                        principalTable: "SliderTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VideoModifiedUser",
                columns: table => new
                {
                    AppUserId = table.Column<string>(nullable: false),
                    EntityId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoModifiedUser", x => new { x.AppUserId, x.EntityId });
                    table.ForeignKey(
                        name: "FK_VideoModifiedUser_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideoModifiedUser_Videos_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActionDataModifiedUser",
                columns: table => new
                {
                    AppUserId = table.Column<string>(nullable: false),
                    EntityId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionDataModifiedUser", x => new { x.AppUserId, x.EntityId });
                    table.ForeignKey(
                        name: "FK_ActionDataModifiedUser_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActionDataModifiedUser_ActionDatas_EntityId",
                        column: x => x.EntityId,
                        principalTable: "ActionDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CartTitle = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    FileCategoryId = table.Column<short>(nullable: true),
                    Length = table.Column<long>(nullable: false),
                    IsPodcast = table.Column<bool>(nullable: false),
                    FileType = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    SliderId = table.Column<short>(nullable: true),
                    AccessAbleFileId = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Files_AccessAbleFiless_AccessAbleFileId",
                        column: x => x.AccessAbleFileId,
                        principalTable: "AccessAbleFiless",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_FileCategorys_FileCategoryId",
                        column: x => x.FileCategoryId,
                        principalTable: "FileCategorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_Sliders_SliderId",
                        column: x => x.SliderId,
                        principalTable: "Sliders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AudioCmses",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    FileId = table.Column<short>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    AudioCmsType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudioCmses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AudioCmses_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AudioCmses_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Content",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Keywords = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    IsMainPage = table.Column<bool>(nullable: false),
                    ContentTypeId = table.Column<short>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CoverImageId = table.Column<short>(nullable: false),
                    ProfileImageId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Content", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Content_ContentTypes_ContentTypeId",
                        column: x => x.ContentTypeId,
                        principalTable: "ContentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Content_Files_CoverImageId",
                        column: x => x.CoverImageId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Content_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Content_Files_ProfileImageId",
                        column: x => x.ProfileImageId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FileModifiedUser",
                columns: table => new
                {
                    AppUserId = table.Column<string>(nullable: false),
                    EntityId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileModifiedUser", x => new { x.AppUserId, x.EntityId });
                    table.ForeignKey(
                        name: "FK_FileModifiedUser_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileModifiedUser_Files_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageCmses",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    FileId = table.Column<short>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageCmses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageCmses_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ImageCmses_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteSettings",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    SiteLogoId = table.Column<short>(nullable: true),
                    FooterLogoId = table.Column<short>(nullable: true),
                    FavIconId = table.Column<short>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    FooterText = table.Column<string>(nullable: true),
                    RightConditionText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SiteSettings_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SiteSettings_Files_FavIconId",
                        column: x => x.FavIconId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SiteSettings_Files_FooterLogoId",
                        column: x => x.FooterLogoId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SiteSettings_Files_SiteLogoId",
                        column: x => x.SiteLogoId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    TeamAppUserId = table.Column<string>(nullable: true),
                    ProfileImageId = table.Column<short>(nullable: true),
                    BreifKnowledge = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teams_Files_ProfileImageId",
                        column: x => x.ProfileImageId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teams_AspNetUsers_TeamAppUserId",
                        column: x => x.TeamAppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UploadInfos",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    TotalUploads = table.Column<int>(nullable: false),
                    LastUploadDate = table.Column<DateTime>(nullable: false),
                    FileId = table.Column<short>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UploadInfos_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UploadInfos_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UploadInfos_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    ContentId = table.Column<short>(nullable: false),
                    IsRead = table.Column<bool>(nullable: false),
                    IsAccept = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Content_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Content",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AboutUses",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    TeamId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutUses_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AboutUses_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialNetworks",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DisplaySort = table.Column<byte>(nullable: false),
                    CreationUserId = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TotalSeen = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    FaClass = table.Column<string>(nullable: true),
                    SiteSettingId = table.Column<short>(nullable: true),
                    TeamId = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialNetworks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialNetworks_AspNetUsers_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SocialNetworks_SiteSettings_SiteSettingId",
                        column: x => x.SiteSettingId,
                        principalTable: "SiteSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SocialNetworks_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutUses_CreationUserId",
                table: "AboutUses",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutUses_TeamId",
                table: "AboutUses",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_AccessAbleFileModifiedUser_EntityId",
                table: "AccessAbleFileModifiedUser",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_AccessAbleFiless_CreationUserId",
                table: "AccessAbleFiless",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionDataModifiedUser_EntityId",
                table: "ActionDataModifiedUser",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionDatas_ControllerDataId",
                table: "ActionDatas",
                column: "ControllerDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionDatas_CreationUserId",
                table: "ActionDatas",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AboutUsId",
                table: "AspNetUsers",
                column: "AboutUsId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AccessAbleFileId",
                table: "AspNetUsers",
                column: "AccessAbleFileId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ActionDataId",
                table: "AspNetUsers",
                column: "ActionDataId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AudioCmsId",
                table: "AspNetUsers",
                column: "AudioCmsId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CommentId",
                table: "AspNetUsers",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ContentId",
                table: "AspNetUsers",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ContentTypeId",
                table: "AspNetUsers",
                column: "ContentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ControllerDataId",
                table: "AspNetUsers",
                column: "ControllerDataId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FileCategoryId",
                table: "AspNetUsers",
                column: "FileCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FileId",
                table: "AspNetUsers",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ImageCmsId",
                table: "AspNetUsers",
                column: "ImageCmsId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ImageCmsTypeId",
                table: "AspNetUsers",
                column: "ImageCmsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LoggingEventId",
                table: "AspNetUsers",
                column: "LoggingEventId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PaperId",
                table: "AspNetUsers",
                column: "PaperId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PodcastId",
                table: "AspNetUsers",
                column: "PodcastId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SideBarId",
                table: "AspNetUsers",
                column: "SideBarId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SiteDetailId",
                table: "AspNetUsers",
                column: "SiteDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SiteSettingId",
                table: "AspNetUsers",
                column: "SiteSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SliderId",
                table: "AspNetUsers",
                column: "SliderId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SliderTypeId",
                table: "AspNetUsers",
                column: "SliderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SocialClassId",
                table: "AspNetUsers",
                column: "SocialClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SocialNetworkId",
                table: "AspNetUsers",
                column: "SocialNetworkId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TeamId",
                table: "AspNetUsers",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UploadInfoId",
                table: "AspNetUsers",
                column: "UploadInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_VideoId",
                table: "AspNetUsers",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_AudioCmses_CreationUserId",
                table: "AudioCmses",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AudioCmses_FileId",
                table: "AudioCmses",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ContentId",
                table: "Comments",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CreationUserId",
                table: "Comments",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Content_ContentTypeId",
                table: "Content",
                column: "ContentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Content_CoverImageId",
                table: "Content",
                column: "CoverImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Content_CreationUserId",
                table: "Content",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Content_ProfileImageId",
                table: "Content",
                column: "ProfileImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentTypes_CreationUserId",
                table: "ContentTypes",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ControllerDataModifiedUser_EntityId",
                table: "ControllerDataModifiedUser",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ControllerDatas_CreationUserId",
                table: "ControllerDatas",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FileCategorys_CreationUserId",
                table: "FileCategorys",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FileCategorys_ParentId",
                table: "FileCategorys",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_FileModifiedUser_EntityId",
                table: "FileModifiedUser",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_AccessAbleFileId",
                table: "Files",
                column: "AccessAbleFileId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_CreationUserId",
                table: "Files",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_FileCategoryId",
                table: "Files",
                column: "FileCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_SliderId",
                table: "Files",
                column: "SliderId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageCmses_CreationUserId",
                table: "ImageCmses",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageCmses_FileId",
                table: "ImageCmses",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageCmsTypes_CreationUserId",
                table: "ImageCmsTypes",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LoggingEvents_AppUserId",
                table: "LoggingEvents",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LoggingEvents_CreationUserId",
                table: "LoggingEvents",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PaperModifiedUser_EntityId",
                table: "PaperModifiedUser",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Papers_CreationUserId",
                table: "Papers",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PodcastModifiedUser_EntityId",
                table: "PodcastModifiedUser",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Podcasts_CreationUserId",
                table: "Podcasts",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SideBars_AppUserId",
                table: "SideBars",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SideBars_CreationUserId",
                table: "SideBars",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SideBars_ParentId",
                table: "SideBars",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteDetailModifiedUser_EntityId",
                table: "SiteDetailModifiedUser",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteDetails_CreationUserId",
                table: "SiteDetails",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteSettings_CreationUserId",
                table: "SiteSettings",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteSettings_FavIconId",
                table: "SiteSettings",
                column: "FavIconId",
                unique: true,
                filter: "[FavIconId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SiteSettings_FooterLogoId",
                table: "SiteSettings",
                column: "FooterLogoId",
                unique: true,
                filter: "[FooterLogoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SiteSettings_SiteLogoId",
                table: "SiteSettings",
                column: "SiteLogoId",
                unique: true,
                filter: "[SiteLogoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Sliders_CreationUserId",
                table: "Sliders",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sliders_SliderTypeId",
                table: "Sliders",
                column: "SliderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SliderTypes_CreationUserId",
                table: "SliderTypes",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialClasses_CreationUserId",
                table: "SocialClasses",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialNetworks_CreationUserId",
                table: "SocialNetworks",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialNetworks_SiteSettingId",
                table: "SocialNetworks",
                column: "SiteSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialNetworks_TeamId",
                table: "SocialNetworks",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CreationUserId",
                table: "Teams",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ProfileImageId",
                table: "Teams",
                column: "ProfileImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_TeamAppUserId",
                table: "Teams",
                column: "TeamAppUserId",
                unique: true,
                filter: "[TeamAppUserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UploadInfos_CreationUserId",
                table: "UploadInfos",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UploadInfos_FileId",
                table: "UploadInfos",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_UploadInfos_UserId",
                table: "UploadInfos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoModifiedUser_EntityId",
                table: "VideoModifiedUser",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Videos_CreationUserId",
                table: "Videos",
                column: "CreationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Teams_TeamId",
                table: "AspNetUsers",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AccessAbleFiless_AccessAbleFileId",
                table: "AspNetUsers",
                column: "AccessAbleFileId",
                principalTable: "AccessAbleFiless",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ActionDatas_ActionDataId",
                table: "AspNetUsers",
                column: "ActionDataId",
                principalTable: "ActionDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ControllerDatas_ControllerDataId",
                table: "AspNetUsers",
                column: "ControllerDataId",
                principalTable: "ControllerDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AboutUses_AboutUsId",
                table: "AspNetUsers",
                column: "AboutUsId",
                principalTable: "AboutUses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AudioCmses_AudioCmsId",
                table: "AspNetUsers",
                column: "AudioCmsId",
                principalTable: "AudioCmses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Comments_CommentId",
                table: "AspNetUsers",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Content_ContentId",
                table: "AspNetUsers",
                column: "ContentId",
                principalTable: "Content",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ContentTypes_ContentTypeId",
                table: "AspNetUsers",
                column: "ContentTypeId",
                principalTable: "ContentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_FileCategorys_FileCategoryId",
                table: "AspNetUsers",
                column: "FileCategoryId",
                principalTable: "FileCategorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Files_FileId",
                table: "AspNetUsers",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ImageCmses_ImageCmsId",
                table: "AspNetUsers",
                column: "ImageCmsId",
                principalTable: "ImageCmses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ImageCmsTypes_ImageCmsTypeId",
                table: "AspNetUsers",
                column: "ImageCmsTypeId",
                principalTable: "ImageCmsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_LoggingEvents_LoggingEventId",
                table: "AspNetUsers",
                column: "LoggingEventId",
                principalTable: "LoggingEvents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Papers_PaperId",
                table: "AspNetUsers",
                column: "PaperId",
                principalTable: "Papers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Podcasts_PodcastId",
                table: "AspNetUsers",
                column: "PodcastId",
                principalTable: "Podcasts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SideBars_SideBarId",
                table: "AspNetUsers",
                column: "SideBarId",
                principalTable: "SideBars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SiteDetails_SiteDetailId",
                table: "AspNetUsers",
                column: "SiteDetailId",
                principalTable: "SiteDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SiteSettings_SiteSettingId",
                table: "AspNetUsers",
                column: "SiteSettingId",
                principalTable: "SiteSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Sliders_SliderId",
                table: "AspNetUsers",
                column: "SliderId",
                principalTable: "Sliders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SliderTypes_SliderTypeId",
                table: "AspNetUsers",
                column: "SliderTypeId",
                principalTable: "SliderTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SocialClasses_SocialClassId",
                table: "AspNetUsers",
                column: "SocialClassId",
                principalTable: "SocialClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SocialNetworks_SocialNetworkId",
                table: "AspNetUsers",
                column: "SocialNetworkId",
                principalTable: "SocialNetworks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UploadInfos_UploadInfoId",
                table: "AspNetUsers",
                column: "UploadInfoId",
                principalTable: "UploadInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Videos_VideoId",
                table: "AspNetUsers",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutUses_AspNetUsers_CreationUserId",
                table: "AboutUses");

            migrationBuilder.DropForeignKey(
                name: "FK_AccessAbleFiless_AspNetUsers_CreationUserId",
                table: "AccessAbleFiless");

            migrationBuilder.DropForeignKey(
                name: "FK_ActionDatas_AspNetUsers_CreationUserId",
                table: "ActionDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_AudioCmses_AspNetUsers_CreationUserId",
                table: "AudioCmses");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_CreationUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Content_AspNetUsers_CreationUserId",
                table: "Content");

            migrationBuilder.DropForeignKey(
                name: "FK_ContentTypes_AspNetUsers_CreationUserId",
                table: "ContentTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_ControllerDatas_AspNetUsers_CreationUserId",
                table: "ControllerDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_FileCategorys_AspNetUsers_CreationUserId",
                table: "FileCategorys");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_AspNetUsers_CreationUserId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageCmses_AspNetUsers_CreationUserId",
                table: "ImageCmses");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageCmsTypes_AspNetUsers_CreationUserId",
                table: "ImageCmsTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_LoggingEvents_AspNetUsers_AppUserId",
                table: "LoggingEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_LoggingEvents_AspNetUsers_CreationUserId",
                table: "LoggingEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_Papers_AspNetUsers_CreationUserId",
                table: "Papers");

            migrationBuilder.DropForeignKey(
                name: "FK_Podcasts_AspNetUsers_CreationUserId",
                table: "Podcasts");

            migrationBuilder.DropForeignKey(
                name: "FK_SideBars_AspNetUsers_AppUserId",
                table: "SideBars");

            migrationBuilder.DropForeignKey(
                name: "FK_SideBars_AspNetUsers_CreationUserId",
                table: "SideBars");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteDetails_AspNetUsers_CreationUserId",
                table: "SiteDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteSettings_AspNetUsers_CreationUserId",
                table: "SiteSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_AspNetUsers_CreationUserId",
                table: "Sliders");

            migrationBuilder.DropForeignKey(
                name: "FK_SliderTypes_AspNetUsers_CreationUserId",
                table: "SliderTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialClasses_AspNetUsers_CreationUserId",
                table: "SocialClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialNetworks_AspNetUsers_CreationUserId",
                table: "SocialNetworks");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_AspNetUsers_CreationUserId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_AspNetUsers_TeamAppUserId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_UploadInfos_AspNetUsers_CreationUserId",
                table: "UploadInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_UploadInfos_AspNetUsers_UserId",
                table: "UploadInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_Videos_AspNetUsers_CreationUserId",
                table: "Videos");

            migrationBuilder.DropTable(
                name: "AccessAbleFileModifiedUser");

            migrationBuilder.DropTable(
                name: "ActionDataModifiedUser");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ControllerDataModifiedUser");

            migrationBuilder.DropTable(
                name: "FileModifiedUser");

            migrationBuilder.DropTable(
                name: "PaperModifiedUser");

            migrationBuilder.DropTable(
                name: "PodcastModifiedUser");

            migrationBuilder.DropTable(
                name: "SiteDetailModifiedUser");

            migrationBuilder.DropTable(
                name: "VideoModifiedUser");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AboutUses");

            migrationBuilder.DropTable(
                name: "ActionDatas");

            migrationBuilder.DropTable(
                name: "AudioCmses");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ImageCmses");

            migrationBuilder.DropTable(
                name: "ImageCmsTypes");

            migrationBuilder.DropTable(
                name: "LoggingEvents");

            migrationBuilder.DropTable(
                name: "Papers");

            migrationBuilder.DropTable(
                name: "Podcasts");

            migrationBuilder.DropTable(
                name: "SideBars");

            migrationBuilder.DropTable(
                name: "SiteDetails");

            migrationBuilder.DropTable(
                name: "SocialClasses");

            migrationBuilder.DropTable(
                name: "SocialNetworks");

            migrationBuilder.DropTable(
                name: "UploadInfos");

            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropTable(
                name: "ControllerDatas");

            migrationBuilder.DropTable(
                name: "Content");

            migrationBuilder.DropTable(
                name: "SiteSettings");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "ContentTypes");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "AccessAbleFiless");

            migrationBuilder.DropTable(
                name: "FileCategorys");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "SliderTypes");
        }
    }
}
