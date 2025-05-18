using System;
using System.Collections.Generic;
using LogSheet_API.Models;
using Microsoft.EntityFrameworkCore;

namespace LogSheet_API.Data;

public partial class LogSheetDbContext : DbContext
{
    public LogSheetDbContext()
    {
    }

    public LogSheetDbContext(DbContextOptions<LogSheetDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<APIDataTemp> APIDataTemps { get; set; }

    public virtual DbSet<APIToken> APITokens { get; set; }

    public virtual DbSet<AccessType> AccessTypes { get; set; }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<ArticlesTagJoin> ArticlesTagJoins { get; set; }

    public virtual DbSet<Banner> Banners { get; set; }

    public virtual DbSet<Benchmark> Benchmarks { get; set; }

    public virtual DbSet<BenchmarkHistory> BenchmarkHistories { get; set; }

    public virtual DbSet<CapitalLineLIC_DailyNAV> CapitalLineLIC_DailyNAVs { get; set; }

    public virtual DbSet<CapitalLineLIC_HistoricalNAV> CapitalLineLIC_HistoricalNAVs { get; set; }

    public virtual DbSet<CapitalLineLIC_MFAllHolding> CapitalLineLIC_MFAllHoldings { get; set; }

    public virtual DbSet<CapitalLineLIC_SchemeNAVHistoricalNew> CapitalLineLIC_SchemeNAVHistoricalNews { get; set; }

    public virtual DbSet<CapitalLineLIC_SchemeReturn> CapitalLineLIC_SchemeReturns { get; set; }

    public virtual DbSet<CapitalLine_DailyNAV> CapitalLine_DailyNAVs { get; set; }

    public virtual DbSet<CapitalLine_MFAllHolding> CapitalLine_MFAllHoldings { get; set; }

    public virtual DbSet<CapitalLine_MFAllHolding1> CapitalLine_MFAllHolding1s { get; set; }

    public virtual DbSet<CapitalLine_MFAllHoldingBK26> CapitalLine_MFAllHoldingBK26s { get; set; }

    public virtual DbSet<CapitalLine_MFAllHolding_bk_10Dec> CapitalLine_MFAllHolding_bk_10Decs { get; set; }

    public virtual DbSet<CapitalLine_News> CapitalLine_News { get; set; }

    public virtual DbSet<CapitalLine_SchemeMaster> CapitalLine_SchemeMasters { get; set; }

    public virtual DbSet<CapitalLine_SchemeNAVHistoricalNew> CapitalLine_SchemeNAVHistoricalNews { get; set; }

    public virtual DbSet<CapitalLine_SchemeReturn> CapitalLine_SchemeReturns { get; set; }

    public virtual DbSet<Career> Careers { get; set; }

    public virtual DbSet<CheckerLotBk> CheckerLotBks { get; set; }

    public virtual DbSet<Checkerlot> Checkerlots { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Cobranding> Cobrandings { get; set; }

    public virtual DbSet<ConsoleTrace> ConsoleTraces { get; set; }

    public virtual DbSet<ContentTypeContentJoin> ContentTypeContentJoins { get; set; }

    public virtual DbSet<ContentTypeContentJoinbk_sidkimsai> ContentTypeContentJoinbk_sidkimsais { get; set; }

    public virtual DbSet<ContentTypeProductsJoin> ContentTypeProductsJoins { get; set; }

    public virtual DbSet<ContentTypeTagsJoin> ContentTypeTagsJoins { get; set; }

    public virtual DbSet<Dividend> Dividends { get; set; }

    public virtual DbSet<Downloadable> Downloadables { get; set; }

    public virtual DbSet<DownloadsTagJoin> DownloadsTagJoins { get; set; }

    public virtual DbSet<FAQ> FAQs { get; set; }

    public virtual DbSet<FAQsTagJoin> FAQsTagJoins { get; set; }

    public virtual DbSet<FieldValue> FieldValues { get; set; }

    public virtual DbSet<FileInputTemplate> FileInputTemplates { get; set; }

    public virtual DbSet<FileRegister> FileRegisters { get; set; }

    public virtual DbSet<FileRegisterBk> FileRegisterBks { get; set; }

    public virtual DbSet<FileRegisterBkNew> FileRegisterBkNews { get; set; }

    public virtual DbSet<FileRegisterOld> FileRegisterOlds { get; set; }

    public virtual DbSet<FundManager> FundManagers { get; set; }

    public virtual DbSet<FundManagerHistory> FundManagerHistories { get; set; }

    public virtual DbSet<FundManagerHistoryNew> FundManagerHistoryNews { get; set; }

    public virtual DbSet<GpItem> GpItems { get; set; }

    public virtual DbSet<GpType> GpTypes { get; set; }

    public virtual DbSet<HealthStatus> HealthStatuses { get; set; }

    public virtual DbSet<HistoricalDividend> HistoricalDividends { get; set; }

    public virtual DbSet<IndexConstituent> IndexConstituents { get; set; }

    public virtual DbSet<LetsConnect> LetsConnects { get; set; }

    public virtual DbSet<LogSheet> LogSheets { get; set; }

    public virtual DbSet<LoggedInToken> LoggedInTokens { get; set; }

    public virtual DbSet<MAILTABLE> MAILTABLEs { get; set; }

    public virtual DbSet<MST001> MST001s { get; set; }

    public virtual DbSet<MST0016> MST0016s { get; set; }

    public virtual DbSet<MST002> MST002s { get; set; }

    public virtual DbSet<MST003> MST003s { get; set; }

    public virtual DbSet<MST004> MST004s { get; set; }

    public virtual DbSet<MST005> MST005s { get; set; }

    public virtual DbSet<MST006> MST006s { get; set; }

    public virtual DbSet<MST007> MST007s { get; set; }

    public virtual DbSet<MST008> MST008s { get; set; }

    public virtual DbSet<MST009> MST009s { get; set; }

    public virtual DbSet<MST011> MST011s { get; set; }

    public virtual DbSet<MST012> MST012s { get; set; }

    public virtual DbSet<MST013> MST013s { get; set; }

    public virtual DbSet<MST014> MST014s { get; set; }

    public virtual DbSet<MST015> MST015s { get; set; }

    public virtual DbSet<MailInbox> MailInboxes { get; set; }

    public virtual DbSet<MailTemplate> MailTemplates { get; set; }

    public virtual DbSet<MarketCapClassification> MarketCapClassifications { get; set; }

    public virtual DbSet<MediaCenterResource> MediaCenterResources { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuTag> MenuTags { get; set; }

    public virtual DbSet<MenuTagOption> MenuTagOptions { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<NAV> NAVs { get; set; }

    public virtual DbSet<NavDatum> NavData { get; set; }

    public virtual DbSet<Nifty50> Nifty50s { get; set; }

    public virtual DbSet<Nifty50_bk> Nifty50_bks { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductDatum> ProductData { get; set; }

    public virtual DbSet<ProductInfo> ProductInfos { get; set; }

    public virtual DbSet<ProductTest> ProductTests { get; set; }

    public virtual DbSet<ProductsBK26> ProductsBK26s { get; set; }

    public virtual DbSet<ResetLinkToken> ResetLinkTokens { get; set; }

    public virtual DbSet<ResultTabletemp> ResultTabletemps { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleTag> RoleTags { get; set; }

    public virtual DbSet<SEOBase> SEOBases { get; set; }

    public virtual DbSet<SIPPerformance> SIPPerformances { get; set; }

    public virtual DbSet<SchemeNAVHistoricalDatum> SchemeNAVHistoricalData { get; set; }

    public virtual DbSet<SchemeReturnsFileDump> SchemeReturnsFileDumps { get; set; }

    public virtual DbSet<SenSex> SenSexes { get; set; }

    public virtual DbSet<Sensex_bk> Sensex_bks { get; set; }

    public virtual DbSet<Solution> Solutions { get; set; }

    public virtual DbSet<StaticPageGeneratorDatum> StaticPageGeneratorData { get; set; }

    public virtual DbSet<TABLEFIELDKEYGEN> TABLEFIELDKEYGENs { get; set; }

    public virtual DbSet<TER> TERs { get; set; }

    public virtual DbSet<TableDictionary> TableDictionaries { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<TmpNav> TmpNavs { get; set; }

    public virtual DbSet<Token> Tokens { get; set; }

    public virtual DbSet<TokenLog> TokenLogs { get; set; }

    public virtual DbSet<UploadErrorLog> UploadErrorLogs { get; set; }

    public virtual DbSet<UploadFileLog> UploadFileLogs { get; set; }

    public virtual DbSet<UploadFileRegister> UploadFileRegisters { get; set; }

    public virtual DbSet<UploadFileRegisterAttribute> UploadFileRegisterAttributes { get; set; }

    public virtual DbSet<UploadFileRegisterDatum> UploadFileRegisterData { get; set; }

    public virtual DbSet<UploadFiledatalog> UploadFiledatalogs { get; set; }

    public virtual DbSet<UploadPreFileRegisterDatum> UploadPreFileRegisterData { get; set; }

    public virtual DbSet<UploadTemplate> UploadTemplates { get; set; }

    public virtual DbSet<UploadedFileDatum> UploadedFileData { get; set; }

    public virtual DbSet<UserRoleJoin> UserRoleJoins { get; set; }

    public virtual DbSet<UserTag> UserTags { get; set; }

    public virtual DbSet<apidatapram> apidataprams { get; set; }

    public virtual DbSet<audit_CapitalLine_SchemeMaster> audit_CapitalLine_SchemeMasters { get; set; }

    public virtual DbSet<basic> basics { get; set; }

    public virtual DbSet<disclosure> disclosures { get; set; }

    public virtual DbSet<disclosuretype> disclosuretypes { get; set; }

    public virtual DbSet<downloadabletype> downloadabletypes { get; set; }

    public virtual DbSet<employmenttype> employmenttypes { get; set; }

    public virtual DbSet<goal> goals { get; set; }

    public virtual DbSet<lifecycle> lifecycles { get; set; }

    public virtual DbSet<lifecyclesBK> lifecyclesBKs { get; set; }

    public virtual DbSet<market> markets { get; set; }

    public virtual DbSet<profInfo> profInfos { get; set; }

    public virtual DbSet<requesttable> requesttables { get; set; }

    public virtual DbSet<rohit> rohits { get; set; }

    public virtual DbSet<seo> seos { get; set; }

    public virtual DbSet<tmpDownloadableType> tmpDownloadableTypes { get; set; }

    public virtual DbSet<tmpDownloadablesData2> tmpDownloadablesData2s { get; set; }

    public virtual DbSet<tmpDownloadablesData3> tmpDownloadablesData3s { get; set; }

    public virtual DbSet<tmpDownloadablesData4> tmpDownloadablesData4s { get; set; }

    public virtual DbSet<tmpDownloadablesDatum> tmpDownloadablesData { get; set; }

    public virtual DbSet<user> users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-TNPMMMA\\SQLEXPRESS;Database=LogSheet;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<APIDataTemp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__APIDataT__3214EC07220789AA");

            entity.ToTable("APIDataTemp");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.FUND_TYPE)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.FileId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LNAME)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.MF_COCODE)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.STARTED_ON)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.SumOfTOTNAV)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.address)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.csch)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.dateas)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.email)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.isch)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.nameamc)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.osch)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.telephone)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.website)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<APIToken>(entity =>
        {
            entity.HasKey(e => e.APITokenId).HasName("PK__APIToken__9DADAADAC793B49D");

            entity.ToTable("APIToken");

            entity.Property(e => e.APITokenId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TokenNumber).IsUnicode(false);
            entity.Property(e => e.ValidTill)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AccessType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AccessType");

            entity.Property(e => e.AccessTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Publish)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Read)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RoleCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.View)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Write)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Article>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Article__9C6270C88D0F9517");

            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ArticleInFocus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CheckerlotID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Content).IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FileRegisterId).IsUnicode(false);
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MarkAsDelete)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Summary)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
            entity.Property(e => e.slug).IsUnicode(false);
            entity.Property(e => e.underEditby).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<ArticlesTagJoin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Articles__3214EC07012E4B55");

            entity.ToTable("ArticlesTagJoin");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArticleId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ContentType).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ContentTypePkId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Banner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Banner__3214EC07B468A3EE");

            entity.ToTable("Banner");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CheckerLotId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FileRegisterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MarkAsDelete)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Order).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Path)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Slug)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.isfooter)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.underEditby).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<Benchmark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Benchmar__3214EC07CB89766F");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BenchmarkHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Benchmar__3214EC07CE2756CD");

            entity.ToTable("BenchmarkHistory");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BenchmarkId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<CapitalLineLIC_DailyNAV>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CapitalLineLIC_DailyNAV");

            entity.Property(e => e.AMFICode).IsUnicode(false);
            entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.ISIN).IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NAV).IsUnicode(false);
            entity.Property(e => e.RePurchaseNAV).IsUnicode(false);
            entity.Property(e => e.SellNav).IsUnicode(false);
            entity.Property(e => e.Tax_Type).IsUnicode(false);
            entity.Property(e => e.mf_schcode).IsUnicode(false);
            entity.Property(e => e.mf_schname).IsUnicode(false);
            entity.Property(e => e.navdate).IsUnicode(false);
        });

        modelBuilder.Entity<CapitalLineLIC_HistoricalNAV>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CapitalLineLIC_HistoricalNAV");

            entity.Property(e => e.ADJNAVRS).IsUnicode(false);
            entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MF_COCODE).IsUnicode(false);
            entity.Property(e => e.MF_SCHCODE).IsUnicode(false);
            entity.Property(e => e.NAVDATE).IsUnicode(false);
            entity.Property(e => e.NAVRS).IsUnicode(false);
        });

        modelBuilder.Entity<CapitalLineLIC_MFAllHolding>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CapitalL__3214EC07E6AB641F");

            entity.ToTable("CapitalLineLIC_MFAllHolding");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CO_CODE).IsUnicode(false);
            entity.Property(e => e.CO_NAME).IsUnicode(false);
            entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.IIND_NAME).IsUnicode(false);
            entity.Property(e => e.INVDATE).IsUnicode(false);
            entity.Property(e => e.ISIN).IsUnicode(false);
            entity.Property(e => e.MF_SCHCODE)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.MKTVALUE).IsUnicode(false);
            entity.Property(e => e.NO_SHARES).IsUnicode(false);
            entity.Property(e => e.PERC_HOLD).IsUnicode(false);
            entity.Property(e => e.Rating).IsUnicode(false);
            entity.Property(e => e.RatingAgency).IsUnicode(false);
            entity.Property(e => e.ReportedSector).IsUnicode(false);
            entity.Property(e => e.TYPE).IsUnicode(false);
            entity.Property(e => e.TYPECODE).IsUnicode(false);
            entity.Property(e => e.YTC).IsUnicode(false);
            entity.Property(e => e.YTM).IsUnicode(false);
            entity.Property(e => e.mcaptype).IsUnicode(false);
            entity.Property(e => e.sno).IsUnicode(false);
        });

        modelBuilder.Entity<CapitalLineLIC_SchemeNAVHistoricalNew>(entity =>
        {
            entity.HasKey(e => e.SchemeMasterId).HasName("PK__CapitalL__0EC587744FD0FF84");

            entity.ToTable("CapitalLineLIC_SchemeNAVHistoricalNew");

            entity.Property(e => e.SchemeMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ADJNAVRS).IsUnicode(false);
            entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.FileId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MF_COCODE).IsUnicode(false);
            entity.Property(e => e.MF_SCHCODE).IsUnicode(false);
            entity.Property(e => e.NAVDATE).IsUnicode(false);
            entity.Property(e => e.NAVRS).IsUnicode(false);
        });

        modelBuilder.Entity<CapitalLineLIC_SchemeReturn>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.Day14_Ret).IsUnicode(false);
            entity.Property(e => e.Day1_Ret).IsUnicode(false);
            entity.Property(e => e.Day3_Ret).IsUnicode(false);
            entity.Property(e => e.FileId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Inception_Ret).IsUnicode(false);
            entity.Property(e => e.Month1_Ret).IsUnicode(false);
            entity.Property(e => e.Month3_Ret).IsUnicode(false);
            entity.Property(e => e.Month6_Ret).IsUnicode(false);
            entity.Property(e => e.ReturnDate).IsUnicode(false);
            entity.Property(e => e.SchemeMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Schemecode).IsUnicode(false);
            entity.Property(e => e.Schemename).IsUnicode(false);
            entity.Property(e => e.Week1_Ret).IsUnicode(false);
            entity.Property(e => e.YTD_Ret).IsUnicode(false);
            entity.Property(e => e.Year10_Ret).IsUnicode(false);
            entity.Property(e => e.Year3_Ret).IsUnicode(false);
            entity.Property(e => e.Year5_Ret).IsUnicode(false);
            entity.Property(e => e.Year7_Ret).IsUnicode(false);
            entity.Property(e => e.amficode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.year1_Ret).IsUnicode(false);
        });

        modelBuilder.Entity<CapitalLine_DailyNAV>(entity =>
        {
            entity.HasKey(e => e.SchemeMasterId).HasName("PK__CapitalL__0EC58774A7B6E3FA");

            entity.ToTable("CapitalLine_DailyNAV");

            entity.Property(e => e.SchemeMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AMFICode).IsUnicode(false);
            entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.FileId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ISIN).IsUnicode(false);
            entity.Property(e => e.NAV).IsUnicode(false);
            entity.Property(e => e.RePurchaseNAV).IsUnicode(false);
            entity.Property(e => e.SellNav).IsUnicode(false);
            entity.Property(e => e.Tax_Type).IsUnicode(false);
            entity.Property(e => e.mf_schcode).IsUnicode(false);
            entity.Property(e => e.mf_schname).IsUnicode(false);
            entity.Property(e => e.navdate).IsUnicode(false);
        });

        modelBuilder.Entity<CapitalLine_MFAllHolding>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CapitalLine_MFAllHolding");

            entity.Property(e => e.AMFICode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CO_CODE).IsUnicode(false);
            entity.Property(e => e.CO_NAME).IsUnicode(false);
            entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.FileId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IIND_NAME).IsUnicode(false);
            entity.Property(e => e.INVDATE).IsUnicode(false);
            entity.Property(e => e.ISIN).IsUnicode(false);
            entity.Property(e => e.MKTVALUE).IsUnicode(false);
            entity.Property(e => e.NO_SHARES).IsUnicode(false);
            entity.Property(e => e.PERC_HOLD).IsUnicode(false);
            entity.Property(e => e.Rating).IsUnicode(false);
            entity.Property(e => e.RatingAgency).IsUnicode(false);
            entity.Property(e => e.ReportedSector).IsUnicode(false);
            entity.Property(e => e.SchemeMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TYPE).IsUnicode(false);
            entity.Property(e => e.TYPECODE).IsUnicode(false);
            entity.Property(e => e.YTC).IsUnicode(false);
            entity.Property(e => e.YTM).IsUnicode(false);
            entity.Property(e => e.mcaptype).IsUnicode(false);
            entity.Property(e => e.sno).IsUnicode(false);
        });

        modelBuilder.Entity<CapitalLine_MFAllHolding1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CapitalLine_MFAllHolding1");

            entity.Property(e => e.AMFICode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CO_CODE).IsUnicode(false);
            entity.Property(e => e.CO_NAME).IsUnicode(false);
            entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.FileId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IIND_NAME).IsUnicode(false);
            entity.Property(e => e.INVDATE).IsUnicode(false);
            entity.Property(e => e.ISIN).IsUnicode(false);
            entity.Property(e => e.MKTVALUE).IsUnicode(false);
            entity.Property(e => e.NO_SHARES).IsUnicode(false);
            entity.Property(e => e.PERC_HOLD).IsUnicode(false);
            entity.Property(e => e.Rating).IsUnicode(false);
            entity.Property(e => e.RatingAgency).IsUnicode(false);
            entity.Property(e => e.ReportedSector).IsUnicode(false);
            entity.Property(e => e.SchemeMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TYPE).IsUnicode(false);
            entity.Property(e => e.TYPECODE).IsUnicode(false);
            entity.Property(e => e.YTC).IsUnicode(false);
            entity.Property(e => e.YTM).IsUnicode(false);
            entity.Property(e => e.mcaptype).IsUnicode(false);
            entity.Property(e => e.sno).IsUnicode(false);
        });

        modelBuilder.Entity<CapitalLine_MFAllHoldingBK26>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CapitalLine_MFAllHoldingBK26");

            entity.Property(e => e.AMFICode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CO_CODE).IsUnicode(false);
            entity.Property(e => e.CO_NAME).IsUnicode(false);
            entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.FileId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IIND_NAME).IsUnicode(false);
            entity.Property(e => e.INVDATE).IsUnicode(false);
            entity.Property(e => e.ISIN).IsUnicode(false);
            entity.Property(e => e.MKTVALUE).IsUnicode(false);
            entity.Property(e => e.NO_SHARES).IsUnicode(false);
            entity.Property(e => e.PERC_HOLD).IsUnicode(false);
            entity.Property(e => e.Rating).IsUnicode(false);
            entity.Property(e => e.RatingAgency).IsUnicode(false);
            entity.Property(e => e.ReportedSector).IsUnicode(false);
            entity.Property(e => e.SchemeMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TYPE).IsUnicode(false);
            entity.Property(e => e.TYPECODE).IsUnicode(false);
            entity.Property(e => e.YTC).IsUnicode(false);
            entity.Property(e => e.YTM).IsUnicode(false);
            entity.Property(e => e.mcaptype).IsUnicode(false);
            entity.Property(e => e.sno).IsUnicode(false);
        });

        modelBuilder.Entity<CapitalLine_MFAllHolding_bk_10Dec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CapitalLine_MFAllHolding_bk_10Dec");

            entity.Property(e => e.AMFICode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CO_CODE).IsUnicode(false);
            entity.Property(e => e.CO_NAME).IsUnicode(false);
            entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.FileId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IIND_NAME).IsUnicode(false);
            entity.Property(e => e.INVDATE).IsUnicode(false);
            entity.Property(e => e.ISIN).IsUnicode(false);
            entity.Property(e => e.MKTVALUE).IsUnicode(false);
            entity.Property(e => e.NO_SHARES).IsUnicode(false);
            entity.Property(e => e.PERC_HOLD).IsUnicode(false);
            entity.Property(e => e.Rating).IsUnicode(false);
            entity.Property(e => e.RatingAgency).IsUnicode(false);
            entity.Property(e => e.ReportedSector).IsUnicode(false);
            entity.Property(e => e.SchemeMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TYPE).IsUnicode(false);
            entity.Property(e => e.TYPECODE).IsUnicode(false);
            entity.Property(e => e.YTC).IsUnicode(false);
            entity.Property(e => e.YTM).IsUnicode(false);
            entity.Property(e => e.mcaptype).IsUnicode(false);
            entity.Property(e => e.sno).IsUnicode(false);
        });

        modelBuilder.Entity<CapitalLine_News>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CapitalL__3214EC0717F05064");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.FileId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.arttext).IsUnicode(false);
            entity.Property(e => e.caption).IsUnicode(false);
            entity.Property(e => e.date).IsUnicode(false);
            entity.Property(e => e.heading).IsUnicode(false);
            entity.Property(e => e.section_name).IsUnicode(false);
            entity.Property(e => e.sno).IsUnicode(false);
            entity.Property(e => e.time).IsUnicode(false);
        });

        modelBuilder.Entity<CapitalLine_SchemeMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CapitalLine_SchemeMaster");

            entity.Property(e => e.BMCode).IsUnicode(false);
            entity.Property(e => e.BenchmarkName).IsUnicode(false);
            entity.Property(e => e.Category).IsUnicode(false);
            entity.Property(e => e.ClassCode).IsUnicode(false);
            entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.EntrytLoad).IsUnicode(false);
            entity.Property(e => e.ExitLoad).IsUnicode(false);
            entity.Property(e => e.FileId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.FundManager).IsUnicode(false);
            entity.Property(e => e.FundManager_JoiningDate).IsUnicode(false);
            entity.Property(e => e.FundType).IsUnicode(false);
            entity.Property(e => e.IncrementalInvestment).IsUnicode(false);
            entity.Property(e => e.InvestmentType).IsUnicode(false);
            entity.Property(e => e.LaunchDate).IsUnicode(false);
            entity.Property(e => e.MCAPCategory).IsUnicode(false);
            entity.Property(e => e.MinInvestment).IsUnicode(false);
            entity.Property(e => e.MinInvestment_SIP).IsUnicode(false);
            entity.Property(e => e.SchemeAUM).IsUnicode(false);
            entity.Property(e => e.SchemeInvestmentType).IsUnicode(false);
            entity.Property(e => e.SchemeMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.SchemeName_AMFIReported).IsUnicode(false);
            entity.Property(e => e.SchemeType).IsUnicode(false);
            entity.Property(e => e.amficode).IsUnicode(false);
            entity.Property(e => e.dividend_reinvestment_flag).IsUnicode(false);
            entity.Property(e => e.exit_load_flag).IsUnicode(false);
            entity.Property(e => e.expense_ratio).IsUnicode(false);
            entity.Property(e => e.frequency).IsUnicode(false);
            entity.Property(e => e.isin).IsUnicode(false);
            entity.Property(e => e.isin_Reinvestment).IsUnicode(false);
            entity.Property(e => e.lock_in_period).IsUnicode(false);
            entity.Property(e => e.lock_in_period_flag).IsUnicode(false);
            entity.Property(e => e.maximum_purchase_amount).IsUnicode(false);
            entity.Property(e => e.mf_cocode).IsUnicode(false);
            entity.Property(e => e.mf_schcode).IsUnicode(false);
            entity.Property(e => e.minimum_redemption_qty).IsUnicode(false);
            entity.Property(e => e.navdate).IsUnicode(false);
            entity.Property(e => e.navrs).IsUnicode(false);
            entity.Property(e => e.purchase_allowed).IsUnicode(false);
            entity.Property(e => e.redemption_allowed).IsUnicode(false);
            entity.Property(e => e.redemption_amt_minimum).IsUnicode(false);
            entity.Property(e => e.redemption_amt_multiple).IsUnicode(false);
            entity.Property(e => e.riskometervalue).IsUnicode(false);
            entity.Property(e => e.rtcode).IsUnicode(false);
            entity.Property(e => e.sch_name).IsUnicode(false);
            entity.Property(e => e.sip_flag).IsUnicode(false);
            entity.Property(e => e.stp_flag).IsUnicode(false);
            entity.Property(e => e.swp_flag).IsUnicode(false);
            entity.Property(e => e.swp_mininstallmentnumber).IsUnicode(false);
            entity.Property(e => e.taxation_type).IsUnicode(false);
        });

        modelBuilder.Entity<CapitalLine_SchemeNAVHistoricalNew>(entity =>
        {
            entity.HasKey(e => e.SchemeMasterId).HasName("PK__CapitalL__0EC58774EF8D9D06");

            entity.ToTable("CapitalLine_SchemeNAVHistoricalNew");

            entity.HasIndex(e => new { e.MF_SCHCODE, e.NAVDATE }, "IX_CapitalLine_SchemeNAVHistoricalNew_MF_SCHCODE_NAVDATE");

            entity.Property(e => e.SchemeMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ADJNAVRS).IsUnicode(false);
            entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.FileId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MF_COCODE).IsUnicode(false);
            entity.Property(e => e.MF_SCHCODE)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NAVDATE)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NAVRS)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CapitalLine_SchemeReturn>(entity =>
        {
            entity.HasKey(e => e.SchemeMasterId).HasName("PK__CapitalL__0EC587741D136989");

            entity.Property(e => e.SchemeMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.Day14_Ret).IsUnicode(false);
            entity.Property(e => e.Day1_Ret).IsUnicode(false);
            entity.Property(e => e.Day3_Ret).IsUnicode(false);
            entity.Property(e => e.FileId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Inception_Ret).IsUnicode(false);
            entity.Property(e => e.Month1_Ret).IsUnicode(false);
            entity.Property(e => e.Month3_Ret).IsUnicode(false);
            entity.Property(e => e.Month6_Ret).IsUnicode(false);
            entity.Property(e => e.ReturnDate).IsUnicode(false);
            entity.Property(e => e.Schemecode).IsUnicode(false);
            entity.Property(e => e.Schemename).IsUnicode(false);
            entity.Property(e => e.Week1_Ret).IsUnicode(false);
            entity.Property(e => e.YTD_Ret).IsUnicode(false);
            entity.Property(e => e.Year10_Ret).IsUnicode(false);
            entity.Property(e => e.Year3_Ret).IsUnicode(false);
            entity.Property(e => e.Year5_Ret).IsUnicode(false);
            entity.Property(e => e.Year7_Ret).IsUnicode(false);
            entity.Property(e => e.year1_Ret).IsUnicode(false);
        });

        modelBuilder.Entity<Career>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Careers__3214EC07CFBF77B8");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CheckerLotId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.JobDescription)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.JobLocation)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.LocationType)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.MarkAsDelete)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Slug)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
            entity.Property(e => e.underEditBy).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<CheckerLotBk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CheckerLotBk");

            entity.Property(e => e.CheckedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CheckerDate).HasColumnType("datetime");
            entity.Property(e => e.CheckerLotId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CheckerRemarks)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.CheckerStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleName)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Checkerlot>(entity =>
        {
            entity.HasKey(e => e.CheckerLotId).HasName("PK__Checkerl__AC3DF0016607A370");

            entity.ToTable("Checkerlot");

            entity.Property(e => e.CheckerLotId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CheckedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CheckerDate).HasColumnType("datetime");
            entity.Property(e => e.CheckerRemarks)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.CheckerStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cities__3214EC07EC897FB4");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CheckerLotId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.City1)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("City");
            entity.Property(e => e.CloneOfId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Map)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.MarkAsDelete)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Phone)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.State)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.underEditBy).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Client__3214EC075EB14116");

            entity.ToTable("Client");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ClientCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Client__CreatedB__6A86975B");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.ClientModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Client__Modified__6B7ABB94");
        });

        modelBuilder.Entity<Cobranding>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cobrandi__3214EC07289E2975");

            entity.ToTable("Cobranding");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ARN)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.AddresLine1)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AddresLine2)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AddresLine3)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.FileRegisterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.FundName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(3000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConsoleTrace>(entity =>
        {
            entity.HasKey(e => e.ConsoleTraceId).HasName("PK__ConsoleT__C14890242D2DC5BB");

            entity.ToTable("ConsoleTrace");

            entity.Property(e => e.ConsoleTraceId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.FileId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.SourceName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ContentTypeContentJoin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ContentT__3214EC076F864B71");

            entity.ToTable("ContentTypeContentJoin");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ContentType).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ContentTypePkId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PrimaryContentType).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PrimaryContentTypePkId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<ContentTypeContentJoinbk_sidkimsai>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ContentTypeContentJoinbk_sidkimsai");

            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ContentType).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ContentTypePkId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PrimaryContentType).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PrimaryContentTypePkId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<ContentTypeProductsJoin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ContentTypeProductsJoin");

            entity.Property(e => e.Active)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ContentId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ContentTypeId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<ContentTypeTagsJoin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ContentT__3214EC07772AD932");

            entity.ToTable("ContentTypeTagsJoin");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ContentId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ContentTypeId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TagId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<Dividend>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Dividend__3214EC27E6199EEA");

            entity.ToTable("Dividend");

            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CheckerlotID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FileRegisterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
            entity.Property(e => e.slug).IsUnicode(false);
            entity.Property(e => e.underEditBy).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<Downloadable>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Download__3214EC27DC5E68FB");

            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CheckerlotID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FileRegisterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MarkAsDelete)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
            entity.Property(e => e.slug).IsUnicode(false);
            entity.Property(e => e.underEditBy).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<DownloadsTagJoin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Download__3214EC079961B768");

            entity.ToTable("DownloadsTagJoin");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ContentType).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ContentTypePkId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DownloadableId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<FAQ>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__FAQs__3214EC27E4C11E64");

            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Answer).IsUnicode(false);
            entity.Property(e => e.CheckerlotID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MarkAsDelete)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Question)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.slug).IsUnicode(false);
            entity.Property(e => e.underEditby).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<FAQsTagJoin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FAQsTagJ__3214EC076FEBCDBD");

            entity.ToTable("FAQsTagJoin");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ContentType).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ContentTypePkId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FAQId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<FieldValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FieldVal__3214EC077BBF0C3E");

            entity.ToTable("FieldValue");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Feild)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FileInputTemplate>(entity =>
        {
            entity.HasKey(e => e.FileInputTemplateId).HasName("PK__FileInpu__E1AB30DE90928FEF");

            entity.ToTable("FileInputTemplate");

            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DestinationURL)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FileTypeId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TemplateDescription)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TemplateName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TemplateURL)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.FileType).WithMany(p => p.FileInputTemplates)
                .HasForeignKey(d => d.FileTypeId)
                .HasConstraintName("FK__FileInput__FileT__22800C64");
        });

        modelBuilder.Entity<FileRegister>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FileRegi__3214EC07781CFB3D");

            entity.ToTable("FileRegister");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FileAlt)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FileDisplayName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FileLocation)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.FileTitle)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PublicUrl)
                .HasMaxLength(3999)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FileRegisterBk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FileRegisterBk");

            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FileDisplayName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FileLocation)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PublicUrl)
                .HasMaxLength(3999)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FileRegisterBkNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FileRegisterBkNew");

            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FileDisplayName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FileLocation)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PublicUrl)
                .HasMaxLength(3999)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FileRegisterOld>(entity =>
        {
            entity.HasKey(e => e.FileRegisterId).HasName("PK__FileRegi__FF05F7B7379FAA3E");

            entity.ToTable("FileRegisterOld");

            entity.Property(e => e.FileRegisterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CheckerStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CleanupCommand)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CleanupParams)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CleanupTableName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DelsraFileId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DownloadPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FileDisplayName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FileStatus)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FileUrl)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MarkedForDelete)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UploadErrorLog).IsUnicode(false);
        });

        modelBuilder.Entity<FundManager>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FundMana__3214EC072FC32857");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CheckerlotID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.FileRegisterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MarkAsDelete)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.OtherFundsManaged)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.Photo)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.underEditBy).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<FundManagerHistory>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__FundMana__3214EC27843EE3B3");

            entity.ToTable("FundManagerHistory");

            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.BatchId)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CheckerlotID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FundManagerID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ManagingFrom).HasColumnType("datetime");
            entity.Property(e => e.ManagingTo).HasColumnType("datetime");
            entity.Property(e => e.ProductID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.underEditBy).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<FundManagerHistoryNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FundManagerHistoryNew");

            entity.Property(e => e.Active)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.BatchId)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CheckerlotID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FundManagerID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ManagingFrom).HasColumnType("datetime");
            entity.Property(e => e.ManagingTo).HasColumnType("datetime");
            entity.Property(e => e.ProductID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.underEditBy).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<GpItem>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__GpItem__3214EC274C6EEDCD");

            entity.ToTable("GpItem");

            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CheckerLotId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CheckerStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GpTypeId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LongDescription).HasMaxLength(100);
            entity.Property(e => e.MarkedForDelete)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ShortDescription).HasMaxLength(100);

            entity.HasOne(d => d.CheckerLot).WithMany(p => p.GpItems)
                .HasForeignKey(d => d.CheckerLotId)
                .HasConstraintName("FK__GpItem__CheckerL__53A33203");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.GpItemCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__GpItem__CreatedB__50C6C558");

            entity.HasOne(d => d.GpType).WithMany(p => p.GpItems)
                .HasForeignKey(d => d.GpTypeId)
                .HasConstraintName("FK__GpItem__GpTypeId__52AF0DCA");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.GpItemModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__GpItem__Modified__51BAE991");
        });

        modelBuilder.Entity<GpType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GpType__3214EC074765717B");

            entity.ToTable("GpType");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GpTypeCode).HasMaxLength(100);
            entity.Property(e => e.GpTypeDescription).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SystemDataFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.GpTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__GpType__CreatedB__342A86AA");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.GpTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__GpType__Modified__351EAAE3");
        });

        modelBuilder.Entity<HealthStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HealthStatus");

            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AgentAbsolutePath)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.AgentName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AgentType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ApplicationName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HealthStatusId).ValueGeneratedOnAdd();
            entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            entity.Property(e => e.LastReminderSentOn).HasColumnType("datetime");
            entity.Property(e => e.NextScheduledRestart).HasColumnType("datetime");
            entity.Property(e => e.PostClosure)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PreClosure)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.additionalStats)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HistoricalDividend>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Historic__3214EC0774E98CCE");

            entity.ToTable("HistoricalDividend");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Date)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.IndividualDividendPerUnit)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.IndividualDividendPercentage)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Nav)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.NonIndividualDividendPerUnit)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.NonIndividualDividendPercentage)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.PlanType)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(3999)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IndexConstituent>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__IndexCon__3213E83FCF6DD1BC");

            entity.ToTable("IndexConstituent");

            entity.Property(e => e.id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.isin)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.scheme_code)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.security_name)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.upload_date)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.weightage)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LetsConnect>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LetsConn__3214EC076BDA6C84");

            entity.ToTable("LetsConnect");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.City).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Comments)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.LetsConnectType)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LogSheet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LogSheet__3214EC07E6C72424");

            entity.ToTable("LogSheet");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ClientId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LogDescription).IsUnicode(false);
            entity.Property(e => e.SolutionId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TaskId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.WorkStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Client).WithMany(p => p.LogSheets)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK__LogSheet__Client__7BB1235D");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.LogSheets)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__LogSheet__Create__79C8DAEB");

            entity.HasOne(d => d.Solution).WithMany(p => p.LogSheets)
                .HasForeignKey(d => d.SolutionId)
                .HasConstraintName("FK__LogSheet__Soluti__7ABCFF24");

            entity.HasOne(d => d.Task).WithMany(p => p.LogSheets)
                .HasForeignKey(d => d.TaskId)
                .HasConstraintName("FK__LogSheet__TaskId__7CA54796");
        });

        modelBuilder.Entity<LoggedInToken>(entity =>
        {
            entity.HasKey(e => e.TokenId).HasName("PK__LoggedIn__658FEEEAC53BD25F");

            entity.ToTable("LoggedInToken");

            entity.Property(e => e.TokenId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");
            entity.Property(e => e.TokenNo)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ValidTill).HasColumnType("datetime");
        });

        modelBuilder.Entity<MAILTABLE>(entity =>
        {
            entity.HasKey(e => e.MAILID).HasName("PK__MAILTABL__3CF720F7B95FAB51");

            entity.ToTable("MAILTABLE");

            entity.Property(e => e.ATTACHMENT)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.ATTACHMENTFORMAT)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.BCCADDRESS)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BCCNAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CCADDRESS)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CCNAME)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CREATEDBY).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CREATEDDATE).HasColumnType("datetime");
            entity.Property(e => e.DELSRAURL)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.ENDDATE).HasColumnType("datetime");
            entity.Property(e => e.FAILEDADDRESS)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MAILDATE)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MESSAGE).IsUnicode(false);
            entity.Property(e => e.PICKDATE).HasColumnType("numeric(8, 0)");
            entity.Property(e => e.PICKTIME).HasColumnType("numeric(4, 0)");
            entity.Property(e => e.RECIPIENTADDRESS)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RECIPIENTNAME)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SENDERADDRESS)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SENDERNAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SENTDATETIME).HasColumnType("datetime");
            entity.Property(e => e.STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)");
            entity.Property(e => e.SUBJECT)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MST001>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("MST001");

            entity.Property(e => e.UserId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InvalidAttempts).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");
            entity.Property(e => e.LockedDate).HasColumnType("datetime");
            entity.Property(e => e.LoginId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UserLocked)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MST0016>(entity =>
        {
            entity.HasKey(e => e.AccessTypeId).HasName("PK__MST0016__50AA73DA2111E4C8");

            entity.ToTable("MST0016");

            entity.Property(e => e.AccessTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Publish)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Read)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RoleCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.View)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Write)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<MST002>(entity =>
        {
            entity.HasKey(e => e.UserDetailId).HasName("PK__MST002__564F56B2DD0EC31C");

            entity.ToTable("MST002");

            entity.Property(e => e.UserDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InvalidAttemptAllowed).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Mobile).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ProfileImageUrl)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UserAccessTypeId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UserId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<MST003>(entity =>
        {
            entity.HasKey(e => e.GPTypeId).HasName("PK__MST003__B7D3F8F3FBCE7954");

            entity.ToTable("MST003");

            entity.Property(e => e.GPTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Field1)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Field2)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Field3)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Field4)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Field5)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SystemCode)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MST004>(entity =>
        {
            entity.HasKey(e => e.GPId).HasName("PK__MST004__5E7D7DB426ECA436");

            entity.ToTable("MST004");

            entity.Property(e => e.GPId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Field1)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Field2)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Field3)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Field4)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Field5)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.GPTypeId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ParentGPId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.SystemCode)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MST005>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK__MST005__2D971CAC6CA8CF6A");

            entity.ToTable("MST005");

            entity.Property(e => e.CompanyId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Logo)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MST006>(entity =>
        {
            entity.HasKey(e => e.OfficeId).HasName("PK__MST006__4B61932F7E143CD3");

            entity.ToTable("MST006");

            entity.Property(e => e.OfficeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CountryId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CurrencyId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Logo).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.OfficeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OfficeName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MST007>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__MST007__8AFACE1A65D36B77");

            entity.ToTable("MST007");

            entity.Property(e => e.RoleId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SystemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MST008>(entity =>
        {
            entity.HasKey(e => e.UserOfficeRoleJoinId).HasName("PK__MST008__FFEA1E79A6156E2A");

            entity.ToTable("MST008");

            entity.Property(e => e.UserOfficeRoleJoinId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DefaultFlag)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OfficeId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoleId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ValidFrom).HasColumnType("datetime");
            entity.Property(e => e.ValidTill).HasColumnType("datetime");
        });

        modelBuilder.Entity<MST009>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__MST009__10D1609F56342666");

            entity.ToTable("MST009");

            entity.Property(e => e.CountryId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CurrencyId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<MST011>(entity =>
        {
            entity.HasKey(e => e.EndPointId).HasName("PK__MST011__C12FEF8F23B221DB");

            entity.ToTable("MST011");

            entity.Property(e => e.EndPointId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DisplayEndPoint)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DisplayName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EndPointTypeId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MenuIcon)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MenuKey)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MenuOrder).HasColumnType("numeric(5, 0)");
            entity.Property(e => e.ParentEndPointId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.SystemCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.URL)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MST012>(entity =>
        {
            entity.HasKey(e => e.EPAuthTagId).HasName("PK__MST012__45F5733F7BA63A2F");

            entity.ToTable("MST012");

            entity.Property(e => e.EPAuthTagId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DataSource)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.EndPointId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.SystemTag)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TagName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TagTypeId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<MST013>(entity =>
        {
            entity.HasKey(e => e.EPAuthTagDetailId).HasName("PK__MST013__41B00A5C2E3776EA");

            entity.ToTable("MST013");

            entity.Property(e => e.EPAuthTagDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.EPAuthTagId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Field1)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Field2)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Field3)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.RefData)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MST014>(entity =>
        {
            entity.HasKey(e => e.RoleEPTagId).HasName("PK__MST014__4F4C147AADCF9C32");

            entity.ToTable("MST014");

            entity.Property(e => e.RoleEPTagId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.EPAuthTagId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.RoleId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<MST015>(entity =>
        {
            entity.HasKey(e => e.RoleEPTagDetailId).HasName("PK__MST015__F84C03227C6EA835");

            entity.ToTable("MST015");

            entity.Property(e => e.RoleEPTagDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.EPAuthTagDetailId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.RoleEPTagId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<MailInbox>(entity =>
        {
            entity.HasKey(e => e.MailInboxId).HasName("PK__MailInbo__D2D94ED0B5A51E3C");

            entity.ToTable("MailInbox");

            entity.Property(e => e.ErrorLog).IsUnicode(false);
            entity.Property(e => e.IsMailHTML)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastAttempt).HasColumnType("datetime");
            entity.Property(e => e.MailAttachments)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.MailAttachmentsActual)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.MailBodyHTML).IsUnicode(false);
            entity.Property(e => e.MailBodyText).IsUnicode(false);
            entity.Property(e => e.MailCCId)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MailCCName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MailDate).HasColumnType("datetime");
            entity.Property(e => e.MailEmbeddedFiles)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.MailEmbeddedFilesActual)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.MailFromId)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MailFromName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MailReceivedDate).HasColumnType("datetime");
            entity.Property(e => e.MailSubject)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MailToId)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RouterName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<MailTemplate>(entity =>
        {
            entity.HasKey(e => e.MailTemplateId).HasName("PK_MAILTEMPLATE_MAILTEMPLATEID");

            entity.ToTable("MailTemplate");

            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MailBody).IsUnicode(false);
            entity.Property(e => e.MailSubject)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TemplateName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TemplateTypeId).HasColumnType("numeric(18, 0)");

            entity.HasOne(d => d.TemplateType).WithMany(p => p.MailTemplates)
                .HasForeignKey(d => d.TemplateTypeId)
                .HasConstraintName("FK_MAILTEMPLATE_MST004_GpId");
        });

        modelBuilder.Entity<MarketCapClassification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MarketCa__3214EC07301CA708");

            entity.ToTable("MarketCapClassification");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Classification)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.ISIN)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MediaCenterResource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MediaCen__3214EC0743F688E8");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CheckerlotID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExternalMediaUrl)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.FileRegisterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MarkAsDelete)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Title).HasMaxLength(2000);
            entity.Property(e => e.slug)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.underEditby).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Menu__3214EC077F465DB1");

            entity.ToTable("Menu");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ContentType)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsCheckerMaker)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsMenu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsPublishDraft)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PageComp)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PageUrl)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ParentMenuId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<MenuTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MenuTag__3214EC07BE4305CC");

            entity.ToTable("MenuTag");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MenuId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MenuTagOptionId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<MenuTagOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MenuTagO__3214EC0798F7DA4A");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TagName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TagTypeId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.ToTable("Module");

            entity.Property(e => e.ModuleID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DaysBefore).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MailDescription).IsUnicode(false);
            entity.Property(e => e.MailSubject)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NAV>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__NAV__3214EC27F2013726");

            entity.ToTable("NAV");

            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CheckerlotID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FileRegisterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
            entity.Property(e => e.slug).IsUnicode(false);
            entity.Property(e => e.underEditBy).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<NavDatum>(entity =>
        {
            entity.HasKey(e => e.NavDataId).HasName("PK__NavData__7CBA8757A2AD4C9B");

            entity.Property(e => e.NavDataId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AMFICode)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FileRegisterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NAV).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.NAVDate)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Nifty50>(entity =>
        {
            entity.HasKey(e => e.Nifty50id).HasName("PK__Nifty50__AF5635EF7318AD3F");

            entity.ToTable("Nifty50");

            entity.Property(e => e.Nifty50id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PDate).HasColumnType("datetime");
            entity.Property(e => e.Value).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<Nifty50_bk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Nifty50_bk");

            entity.Property(e => e.Nifty50id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PDate).HasColumnType("datetime");
            entity.Property(e => e.Value).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AUM)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Active)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CheckerlotID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CoverImage).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DBSchemeCode)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.DirectInception).HasColumnType("datetime");
            entity.Property(e => e.EntryLoadText).IsUnicode(false);
            entity.Property(e => e.ExitLoad)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ExitLoadText).IsUnicode(false);
            entity.Property(e => e.ExpenseRatio)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FileRegisterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.FundInFocus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FundSize)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.InvestmentHorizon)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InvestmentHorizonCard).IsUnicode(false);
            entity.Property(e => e.InvestmentObjective)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InvestmentObjectiveCard).IsUnicode(false);
            entity.Property(e => e.InvestmentStyle)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MarkAsDelete)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NAV)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PRCId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ProductLabel).IsUnicode(false);
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.RegularInception).HasColumnType("datetime");
            entity.Property(e => e.ReturnPA)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Risk)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SCBSchemeCode)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SIPAvailability)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SchemeCategoryId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.UnderEditBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.WhyThisFund)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.isNFO)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.isRelated)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.schcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.slug).IsUnicode(false);
        });

        modelBuilder.Entity<ProductDatum>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__ProductD__3214EC279F755D99");

            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CARD1).IsUnicode(false);
            entity.Property(e => e.CARD10).IsUnicode(false);
            entity.Property(e => e.CARD11).IsUnicode(false);
            entity.Property(e => e.CARD12).IsUnicode(false);
            entity.Property(e => e.CARD13).IsUnicode(false);
            entity.Property(e => e.CARD14).IsUnicode(false);
            entity.Property(e => e.CARD15).IsUnicode(false);
            entity.Property(e => e.CARD16).IsUnicode(false);
            entity.Property(e => e.CARD17).IsUnicode(false);
            entity.Property(e => e.CARD18).IsUnicode(false);
            entity.Property(e => e.CARD19).IsUnicode(false);
            entity.Property(e => e.CARD2).IsUnicode(false);
            entity.Property(e => e.CARD20).IsUnicode(false);
            entity.Property(e => e.CARD21).IsUnicode(false);
            entity.Property(e => e.CARD22).IsUnicode(false);
            entity.Property(e => e.CARD23).IsUnicode(false);
            entity.Property(e => e.CARD24).IsUnicode(false);
            entity.Property(e => e.CARD25).IsUnicode(false);
            entity.Property(e => e.CARD3).IsUnicode(false);
            entity.Property(e => e.CARD4).IsUnicode(false);
            entity.Property(e => e.CARD5).IsUnicode(false);
            entity.Property(e => e.CARD6).IsUnicode(false);
            entity.Property(e => e.CARD7).IsUnicode(false);
            entity.Property(e => e.CARD8).IsUnicode(false);
            entity.Property(e => e.CARD9).IsUnicode(false);
            entity.Property(e => e.ProductID).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<ProductInfo>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__ProductI__3214EC270C98508D");

            entity.ToTable("ProductInfo");

            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Amficode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BatchId)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CheckerlotID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ISIN)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProductID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.SchemeCategoryId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.mf_schcode)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProductTest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProductT__3214EC07C5187625");

            entity.ToTable("ProductTest");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Name)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Price)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProductsBK26>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProductsBK26");

            entity.Property(e => e.AUM)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Active)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CoverImage).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DBSchemeCode)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.DirectInception).HasColumnType("datetime");
            entity.Property(e => e.EntryLoadText).IsUnicode(false);
            entity.Property(e => e.ExitLoad)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ExitLoadText).IsUnicode(false);
            entity.Property(e => e.ExpenseRatio)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FileRegisterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.FundInFocus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FundSize)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.InvestmentHorizon)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InvestmentHorizonCard).IsUnicode(false);
            entity.Property(e => e.InvestmentObjective)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InvestmentObjectiveCard).IsUnicode(false);
            entity.Property(e => e.InvestmentStyle)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NAV)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ProductLabel).IsUnicode(false);
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.RegularInception).HasColumnType("datetime");
            entity.Property(e => e.ReturnPA)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Risk)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SCBSchemeCode)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SIPAvailability)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SchemeCategoryId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.UnderEditBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.schcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.slug).IsUnicode(false);
        });

        modelBuilder.Entity<ResetLinkToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ResetLin__3214EC07C38885C5");

            entity.ToTable("ResetLinkToken");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Token)
                .HasMaxLength(800)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ValidFrom).HasColumnType("datetime");
            entity.Property(e => e.ValidTill).HasColumnType("datetime");
        });

        modelBuilder.Entity<ResultTabletemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ResultTabletemp");

            entity.Property(e => e.MatrixConfigId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ResultExpression)
                .HasMaxLength(1999)
                .IsUnicode(false);
            entity.Property(e => e.ResultFactorName)
                .HasMaxLength(1999)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SystemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RoleTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RoleTag__3214EC0702DBC21B");

            entity.ToTable("RoleTag");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MenuTagId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.RoleId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<SEOBase>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__SEOBase__3214EC27F4257FB1");

            entity.ToTable("SEOBase");

            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.underEditBy).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<SIPPerformance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SIPPerfo__3214EC07C4F46A1A");

            entity.ToTable("SIPPerformance");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.FactDate)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Mapping)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.SinceInception)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year1)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year10)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year3)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year5)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year7)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.fundcode)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.fundname)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.sipinvestments)
                .HasMaxLength(3999)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SchemeNAVHistoricalDatum>(entity =>
        {
            entity.HasKey(e => e.SchemeMasterId).HasName("PK__SchemeNA__0EC58774639FB269");

            entity.HasIndex(e => new { e.AMFICode, e.NAVDATE, e.NAVRS }, "idx_AMFICODE_NAVDATE_NAVRS");

            entity.Property(e => e.SchemeMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ADJNAVRS).IsUnicode(false);
            entity.Property(e => e.AMFICode)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.FileId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MF_COCODE).IsUnicode(false);
            entity.Property(e => e.MF_SCHCODE)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NAVDATE)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NAVRS)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SchemeReturnsFileDump>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SchemeRe__3214EC07D207DABE");

            entity.ToTable("SchemeReturnsFileDump");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AddnlBenchmark)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Disclaimer)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Fundcode)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.InceptionAddnlBM10KValue)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.InceptionPrimaryBM10KValue)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.InceptionReturn)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.InceptionReturnAddnlBM)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.InceptionReturnPrimaryBM)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.InceptionScheme10KValue)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.PlanType)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.PrimaryBenchmark)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year1AddnlBM10KValue)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year1PrimaryBM10KValue)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year1Return)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year1ReturnAddnlBM)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year1ReturnPrimaryBM)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year1Scheme10KValue)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year3AddnlBM10KValue)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year3PrimaryBM10KValue)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year3Return)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year3ReturnAddnlBM)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year3ReturnPrimaryBM)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year3Scheme10KValue)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year5AddnlBM10KValue)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year5PrimaryBM10KValue)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year5Return)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year5ReturnAddnlBM)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year5ReturnPrimaryBM)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Year5Scheme10KValue)
                .HasMaxLength(3999)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SenSex>(entity =>
        {
            entity.HasKey(e => e.SenSexid).HasName("PK__SenSex__09D3773A901DFD4C");

            entity.ToTable("SenSex");

            entity.Property(e => e.SenSexid)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PDate).HasColumnType("datetime");
            entity.Property(e => e.Value).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<Sensex_bk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sensex_bk");

            entity.Property(e => e.PDate).HasColumnType("datetime");
            entity.Property(e => e.SenSexid)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Value).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<Solution>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Solution__3214EC07296FF6E0");

            entity.ToTable("Solution");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.SolutionCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Solution__Create__5C387804");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.SolutionModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Solution__Modifi__5D2C9C3D");
        });

        modelBuilder.Entity<StaticPageGeneratorDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StaticPa__3214EC075738EFF4");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CheckerlotID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Slug)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.content).IsUnicode(false);
            entity.Property(e => e.underEditby).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<TABLEFIELDKEYGEN>(entity =>
        {
            entity.HasKey(e => e.TABLEFIELDKEYGEN_ID).HasName("PK__TABLEFIE__F7D165B647A0B259");

            entity.ToTable("TABLEFIELDKEYGEN");

            entity.Property(e => e.TABLEFIELDKEYGEN_ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.FIELD)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KEYGENEXPRESSION)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OFFICEID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.RESETAT)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RUNNINGNUMBER).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TABLENAME)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TER>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__TER__3214EC27781B6A49");

            entity.ToTable("TER");

            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CheckerlotID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FileRegisterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
            entity.Property(e => e.slug).IsUnicode(false);
            entity.Property(e => e.underEditBy).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<TableDictionary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TableDictionary");

            entity.Property(e => e.AliasName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TableName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tags__3214EC076F3BB387");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ParentTagId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TagName).IsUnicode(false);
        });

        modelBuilder.Entity<TmpNav>(entity =>
        {
            entity.HasKey(e => e.TmpNavId).HasName("PK__TmpNav__272B1A3230A62C00");

            entity.ToTable("TmpNav");

            entity.Property(e => e.TmpNavId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AMFICode)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ErrorRemarks)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.FileRegisterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NAV)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NAVDate)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Token>(entity =>
        {
            entity.HasKey(e => e.TokenId).HasName("PK__Token__658FEEEA390B9D60");

            entity.ToTable("Token");

            entity.Property(e => e.TokenId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TokenNo)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ValidFrom).HasColumnType("datetime");
            entity.Property(e => e.ValidTill).HasColumnType("datetime");
        });

        modelBuilder.Entity<TokenLog>(entity =>
        {
            entity.HasKey(e => e.TokenId).HasName("PK__TokenLog__658FEEEAC6BE8185");

            entity.ToTable("TokenLog");

            entity.Property(e => e.TokenId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.IssueDate).HasColumnType("datetime");
            entity.Property(e => e.TokenNo).IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<UploadErrorLog>(entity =>
        {
            entity.HasKey(e => e.ErrorLogId).HasName("PK__ErrorLog__D65247C28B7D187C");

            entity.ToTable("UploadErrorLog");

            entity.Property(e => e.ErrorLogId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.UploadFileLogId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<UploadFileLog>(entity =>
        {
            entity.HasKey(e => e.UploadFileLogId).HasName("PK__FileLog__AAB6B761D4E243AA");

            entity.ToTable("UploadFileLog");

            entity.Property(e => e.UploadFileLogId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.FileName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FilePath)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UploadTypeId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UploadedDataTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<UploadFileRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UploadFileRegister");

            entity.Property(e => e.ApprovedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CleanupCommand)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CompletionDataTime).HasColumnType("datetime");
            entity.Property(e => e.CompletionDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.DuplicateRecords).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ErrorRecords).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.FileName)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.FilePath)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.FileRegisterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.InputOutputFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ParentFileRegisterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PendingForApproval)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.ScheduledDateTime)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TableName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TotalRecords).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UploadType)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ValidRecords).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<UploadFileRegisterAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UploadFi__3214EC0798FC896A");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Daily_Execution)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DependentId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.FileRegisterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Monthly_Execution)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.OneTime_Execution)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Weekly_Execution)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UploadFileRegisterDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Column1)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column10)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column11)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column12)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column13)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column14)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column15)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column16)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column17)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column18)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column19)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column2)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column20)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column21)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column22)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column23)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column24)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column25)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column26)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column27)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column28)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column29)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column3)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column30)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column31)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column32)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column33)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column34)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column35)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column36)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column37)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column38)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column39)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column4)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column40)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column41).IsUnicode(false);
            entity.Property(e => e.Column42).IsUnicode(false);
            entity.Property(e => e.Column43).IsUnicode(false);
            entity.Property(e => e.Column44).IsUnicode(false);
            entity.Property(e => e.Column45).IsUnicode(false);
            entity.Property(e => e.Column46).IsUnicode(false);
            entity.Property(e => e.Column47).IsUnicode(false);
            entity.Property(e => e.Column48).IsUnicode(false);
            entity.Property(e => e.Column49).IsUnicode(false);
            entity.Property(e => e.Column5)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column6)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column7)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column8)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column9)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.FileRegisterDataId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.FileRegisterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UploadFiledatalog>(entity =>
        {
            entity.HasKey(e => e.UploadedFileDataLogId).HasName("PK__Uploaded__214F2D03464EF8E3");

            entity.ToTable("UploadFiledatalog");

            entity.Property(e => e.UploadedFileDataLogId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.COL1)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL10)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL11)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL12)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL13)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL14)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL15)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL16)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL17)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL18)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL19)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL2)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL20)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL3)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL4)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL5)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL6)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL7)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL8)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL9)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Message)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UploadFileLogId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<UploadPreFileRegisterDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Column1)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column10)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column11)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column12)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column13)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column14)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column15)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column16)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column17)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column18)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column19)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column2)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column20)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column21)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column22)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column23)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column24)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column25)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column26)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column27)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column28)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column29)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column3)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column30)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column31)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column32)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column33)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column34)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column35)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column36)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column37)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column38)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column39)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column4)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column40)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column41).IsUnicode(false);
            entity.Property(e => e.Column42).IsUnicode(false);
            entity.Property(e => e.Column43).IsUnicode(false);
            entity.Property(e => e.Column44).IsUnicode(false);
            entity.Property(e => e.Column45).IsUnicode(false);
            entity.Property(e => e.Column46).IsUnicode(false);
            entity.Property(e => e.Column47).IsUnicode(false);
            entity.Property(e => e.Column48).IsUnicode(false);
            entity.Property(e => e.Column49).IsUnicode(false);
            entity.Property(e => e.Column5)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column6)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.Column7).IsUnicode(false);
            entity.Property(e => e.Column8).IsUnicode(false);
            entity.Property(e => e.Column9).IsUnicode(false);
            entity.Property(e => e.FileRegisterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PreFileRegisterDataId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UploadTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UploadTe__3214EC0787880B8E");

            entity.ToTable("UploadTemplate");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DestinationUrl)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TemplateUrl)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UploadType)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UploadedFileDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.COL1)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL10)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL11)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL12)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL13)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL14)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL15)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL16)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL17)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL18)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL19)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL2)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL20)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL3)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL4)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL5)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL6)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL7)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL8)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.COL9)
                .HasMaxLength(3999)
                .IsUnicode(false);
            entity.Property(e => e.FileRegisterDataId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.FileRegisterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UserRoleJoin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserRole__3214EC071028391C");

            entity.ToTable("UserRoleJoin");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RoleId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UserId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<UserTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserTag__3214EC0729345250");

            entity.ToTable("UserTag");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MenuTagId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UserId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<apidatapram>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__apidatap__3214EC07EC4469CC");

            entity.ToTable("apidatapram");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.FileId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MainCategory)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.VCLASS)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.VCLASSCODE)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<audit_CapitalLine_SchemeMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("audit_CapitalLine_SchemeMaster");

            entity.Property(e => e.BMCode).IsUnicode(false);
            entity.Property(e => e.BenchmarkName).IsUnicode(false);
            entity.Property(e => e.Category).IsUnicode(false);
            entity.Property(e => e.ClassCode).IsUnicode(false);
            entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.EntrytLoad).IsUnicode(false);
            entity.Property(e => e.ExitLoad).IsUnicode(false);
            entity.Property(e => e.FileId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.FundManager).IsUnicode(false);
            entity.Property(e => e.FundManager_JoiningDate).IsUnicode(false);
            entity.Property(e => e.FundType).IsUnicode(false);
            entity.Property(e => e.IncrementalInvestment).IsUnicode(false);
            entity.Property(e => e.InvestmentType).IsUnicode(false);
            entity.Property(e => e.LaunchDate).IsUnicode(false);
            entity.Property(e => e.MCAPCategory).IsUnicode(false);
            entity.Property(e => e.MinInvestment).IsUnicode(false);
            entity.Property(e => e.MinInvestment_SIP).IsUnicode(false);
            entity.Property(e => e.SchemeAUM).IsUnicode(false);
            entity.Property(e => e.SchemeInvestmentType).IsUnicode(false);
            entity.Property(e => e.SchemeMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.SchemeName_AMFIReported).IsUnicode(false);
            entity.Property(e => e.SchemeType).IsUnicode(false);
            entity.Property(e => e.amficode).IsUnicode(false);
            entity.Property(e => e.dividend_reinvestment_flag).IsUnicode(false);
            entity.Property(e => e.exit_load_flag).IsUnicode(false);
            entity.Property(e => e.expense_ratio).IsUnicode(false);
            entity.Property(e => e.frequency).IsUnicode(false);
            entity.Property(e => e.isin).IsUnicode(false);
            entity.Property(e => e.isin_Reinvestment).IsUnicode(false);
            entity.Property(e => e.lock_in_period).IsUnicode(false);
            entity.Property(e => e.lock_in_period_flag).IsUnicode(false);
            entity.Property(e => e.maximum_purchase_amount).IsUnicode(false);
            entity.Property(e => e.mf_cocode).IsUnicode(false);
            entity.Property(e => e.mf_schcode).IsUnicode(false);
            entity.Property(e => e.minimum_redemption_qty).IsUnicode(false);
            entity.Property(e => e.navdate).IsUnicode(false);
            entity.Property(e => e.navrs).IsUnicode(false);
            entity.Property(e => e.purchase_allowed).IsUnicode(false);
            entity.Property(e => e.redemption_allowed).IsUnicode(false);
            entity.Property(e => e.redemption_amt_minimum).IsUnicode(false);
            entity.Property(e => e.redemption_amt_multiple).IsUnicode(false);
            entity.Property(e => e.riskometervalue).IsUnicode(false);
            entity.Property(e => e.rtcode).IsUnicode(false);
            entity.Property(e => e.sch_name).IsUnicode(false);
            entity.Property(e => e.sip_flag).IsUnicode(false);
            entity.Property(e => e.stp_flag).IsUnicode(false);
            entity.Property(e => e.swp_flag).IsUnicode(false);
            entity.Property(e => e.swp_mininstallmentnumber).IsUnicode(false);
            entity.Property(e => e.taxation_type).IsUnicode(false);
        });

        modelBuilder.Entity<basic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__basics__3214EC0701D04CC0");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<disclosure>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Disclosu__3214EC2769DA174F");

            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CheckerlotID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FileRegisterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
            entity.Property(e => e.underEditBy).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<disclosuretype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__disclosu__3214EC0774DE2EDB");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ParentId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.slug)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.underEditBy).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<downloadabletype>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CheckerlotID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MarkAsDelete)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ParentId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.slug)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.underEditBy).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<employmenttype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__employem__3214EC07390DE924");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<goal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__goals__3214EC07406B277F");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<lifecycle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lifecycl__3214EC07F356F15F");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<lifecyclesBK>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("lifecyclesBK");

            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<market>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__markets__3214EC07D6EB1DE3");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<profInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("profInfo");

            entity.Property(e => e.Active)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Amficode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CheckerlotID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ISIN)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProductID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.SchemeCategoryId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.mf_schcode)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<requesttable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("requesttable");

            entity.Property(e => e.ProcessCompleteDateTime).HasColumnType("datetime");
            entity.Property(e => e.ProcessFileName)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.RequestDateTime).HasColumnType("datetime");
            entity.Property(e => e.RequestID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.RequestNo).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.SocketNo).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.URL).IsUnicode(false);
        });

        modelBuilder.Entity<rohit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("rohit");

            entity.Property(e => e.dateOfOriginalPublish)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.downloadsTitle)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.fileurl)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.slug)
                .HasMaxLength(2000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<seo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seo");

            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CheckerLotId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CloneOfId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MarkAsDelete)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PublishStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.underEditBy).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<tmpDownloadableType>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__tmpDownl__3213E83FC38FDA6C");

            entity.Property(e => e.id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.downloadablesId)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.slug)
                .HasMaxLength(4000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tmpDownloadablesData2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpDownloadablesData2");

            entity.Property(e => e.dateOfOriginalPublish)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.downloableTypes)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.downloadsTitle)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.fileurl)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.slug)
                .HasMaxLength(3000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tmpDownloadablesData3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpDownloadablesData3");

            entity.Property(e => e.dateOfOriginalPublish)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.downloableTypes)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.downloadsTitle)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.fileurl)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.slug)
                .HasMaxLength(3000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tmpDownloadablesData4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpDownloadablesData4");

            entity.Property(e => e.dateOfOriginalPublish)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.downloableTypes)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.downloadsTitle)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.fileurl)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.slug)
                .HasMaxLength(3000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tmpDownloadablesDatum>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__tmpDownl__3213E83F006F64BE");

            entity.Property(e => e.id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.dateOfOriginalPublish)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.downloableTypes)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.downloadsTitle)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.fileurl)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.slug)
                .HasMaxLength(3000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<user>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__1788CC4CC1327D87");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ContactNo)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.LastName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");
            entity.Property(e => e.LockedDate).HasColumnType("datetime");
            entity.Property(e => e.LoginId)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.ProfileImageUrl).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.RoleId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UserLocked)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
