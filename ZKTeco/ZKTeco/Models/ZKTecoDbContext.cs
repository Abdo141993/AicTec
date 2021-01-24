using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ZKTeco.Models
{
    public partial class ZKTecoDbContext : DbContext
    {
        //internal object categories;

        public ZKTecoDbContext()
        {
        }

        public ZKTecoDbContext(DbContextOptions<ZKTecoDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AboutU> AboutUs { get; set; }
        public virtual DbSet<AreaEditor> AreaEditors { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Config> Configs { get; set; }
        public virtual DbSet<ContactU> ContactUs { get; set; }
        public virtual DbSet<Dlcontent> Dlcontents { get; set; }
        public virtual DbSet<DownloadLaple> DownloadLaples { get; set; }
        public virtual DbSet<Downloading> Downloadings { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<FooterMaintTitl> FooterMaintTitls { get; set; }
        public virtual DbSet<FooterSubTitle> FooterSubTitles { get; set; }
        public virtual DbSet<HomeSlideImage> HomeSlideImages { get; set; }
        public virtual DbSet<Htmlarea> Htmlareas { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsLetter> NewsLetters { get; set; }
        public virtual DbSet<OnlineSupport> OnlineSupports { get; set; }
        public virtual DbSet<OurClientsDatum> OurClientsData { get; set; }
        public virtual DbSet<OurProductDatum> OurProductData { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductDownload> ProductDownloads { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<QustionAnswer> QustionAnswers { get; set; }
        public virtual DbSet<QustionsTitle> QustionsTitles { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<SupportImg> SupportImgs { get; set; }
        public virtual DbSet<SupportImgMainPage> SupportImgMainPages { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //            if (!optionsBuilder.IsConfigured)
            //            {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            //                optionsBuilder.UseSqlServer("Server=.;Database=NewZKTeco;Trusted_Connection=True;");
            //            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AboutU>(entity =>
            {
                entity.Property(e => e.ParagraphAr)
                    .IsRequired()
                    .HasColumnName("paragraphAr");

                entity.Property(e => e.ParagraphEn)
                    .IsRequired()
                    .HasColumnName("paragraphEn");

                entity.Property(e => e.Photourl).HasColumnName("photourl");

                entity.Property(e => e.SubtitleAr)
                    .IsRequired()
                    .HasColumnName("subtitleAr");

                entity.Property(e => e.SubtitleEn)
                    .IsRequired()
                    .HasColumnName("subtitleEn");

                entity.Property(e => e.TitleAr)
                    .IsRequired()
                    .HasColumnName("titleAr");

                entity.Property(e => e.TitleEn)
                    .IsRequired()
                    .HasColumnName("titleEn");
            });

            modelBuilder.Entity<AreaEditor>(entity =>
            {
                entity.Property(e => e.EditorAr).HasColumnName("editorAR");

                entity.Property(e => e.EditorEg).HasColumnName("editorEG");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles");
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.PasswordHash).IsRequired();

                entity.Property(e => e.PasswordSalt).IsRequired();

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AspNetUserClaims_AspNetUsers");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany()
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetRoles");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetUsers");
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LoginProvider)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AspNetUserTokens_AspNetUsers");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.Adress).IsRequired();

                entity.Property(e => e.AdressAr).IsRequired();

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.Fax).IsRequired();

                entity.Property(e => e.Phone).IsRequired();

                entity.Property(e => e.Website).IsRequired();
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("categories");

                entity.HasIndex(e => e.ParentCategoryId, "IX_categories_ParentCategoryId");

                entity.HasOne(d => d.ParentCategory)
                    .WithMany(p => p.InverseParentCategory)
                    .HasForeignKey(d => d.ParentCategoryId);
            });

            modelBuilder.Entity<Config>(entity =>
            {
                entity.Property(e => e.Adress).IsRequired();

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.Facebook).IsRequired();

                entity.Property(e => e.Fax).IsRequired();

                entity.Property(e => e.FooterLink).IsRequired();

                entity.Property(e => e.FooterTextAr).IsRequired();

                entity.Property(e => e.FooterTextEn).IsRequired();

                entity.Property(e => e.Google).IsRequired();

                entity.Property(e => e.LinkedIn).IsRequired();

                entity.Property(e => e.Location).IsRequired();

                entity.Property(e => e.OurClientsTitleAr).IsRequired();

                entity.Property(e => e.OurClientsTitleEn).IsRequired();

                entity.Property(e => e.OurProductTitleAr).IsRequired();

                entity.Property(e => e.OurProductTitleEn).IsRequired();

                entity.Property(e => e.SupportParagraphAr).IsRequired();

                entity.Property(e => e.SupportParagraphEn).IsRequired();

                entity.Property(e => e.SupportParagraphTitleAr).IsRequired();

                entity.Property(e => e.SupportParagraphTitleEn).IsRequired();

                entity.Property(e => e.SupportTitleAr).IsRequired();

                entity.Property(e => e.SupportTitleEn).IsRequired();

                entity.Property(e => e.Twitter).IsRequired();

                entity.Property(e => e.Youtube).IsRequired();
            });

            modelBuilder.Entity<ContactU>(entity =>
            {
                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.Message).IsRequired();
            });

            modelBuilder.Entity<Dlcontent>(entity =>
            {
                entity.ToTable("DLContents");

                entity.HasIndex(e => e.DownloadingLapleId, "IX_DLContents_DownloadingLapleId");

                entity.Property(e => e.DateTime).HasColumnName("dateTime");

                entity.Property(e => e.DownloadSize).IsRequired();

                entity.Property(e => e.LapleName).IsRequired();

                entity.Property(e => e.LapleNameAr).IsRequired();

                entity.HasOne(d => d.DownloadingLaple)
                    .WithMany(p => p.Dlcontents)
                    .HasForeignKey(d => d.DownloadingLapleId);
            });

            modelBuilder.Entity<DownloadLaple>(entity =>
            {
                entity.HasIndex(e => e.DownloadingId, "IX_DownloadLaples_DownloadingId");

                entity.Property(e => e.LapleName).IsRequired();

                entity.HasOne(d => d.Downloading)
                    .WithMany(p => p.DownloadLaples)
                    .HasForeignKey(d => d.DownloadingId);
            });

            modelBuilder.Entity<Downloading>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.NameAr).IsRequired();
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.ParagraphAr)
                    .IsRequired()
                    .HasColumnName("paragraphAr");

                entity.Property(e => e.ParagraphEn)
                    .IsRequired()
                    .HasColumnName("paragraphEn");

                entity.Property(e => e.TitleAr).IsRequired();

                entity.Property(e => e.TitleEn).IsRequired();
            });

            modelBuilder.Entity<FooterMaintTitl>(entity =>
            {
                entity.Property(e => e.MainTitleAr).IsRequired();

                entity.Property(e => e.MainTitleEn).IsRequired();
            });

            modelBuilder.Entity<FooterSubTitle>(entity =>
            {
                entity.HasIndex(e => e.FooterMainTitleId, "IX_FooterSubTitles_FooterMainTitleId");

                entity.Property(e => e.Link).IsRequired();

                entity.Property(e => e.SubTitleAr).IsRequired();

                entity.Property(e => e.SubTitleEn).IsRequired();

                entity.HasOne(d => d.FooterMainTitle)
                    .WithMany(p => p.FooterSubTitles)
                    .HasForeignKey(d => d.FooterMainTitleId);
            });

            modelBuilder.Entity<HomeSlideImage>(entity =>
            {
                entity.Property(e => e.TextAr).HasColumnName("textAr");

                entity.Property(e => e.TextEn).HasColumnName("textEn");
            });

            modelBuilder.Entity<Htmlarea>(entity =>
            {
                entity.Property(e => e.EditorAr).HasColumnName("editorAR");

                entity.Property(e => e.EditorEg).HasColumnName("editorEG");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.ParagraphAr)
                    .IsRequired()
                    .HasColumnName("paragraphAr");

                entity.Property(e => e.ParagraphEn)
                    .IsRequired()
                    .HasColumnName("paragraphEn");

                entity.Property(e => e.TitleAr).IsRequired();

                entity.Property(e => e.TitleEn).IsRequired();
            });

            modelBuilder.Entity<NewsLetter>(entity =>
            {
                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.NewsLetterLink).IsRequired();

                entity.Property(e => e.ParagraphAr).HasColumnName("paragraphAr");

                entity.Property(e => e.ParagraphEn).HasColumnName("paragraphEn");

                entity.Property(e => e.TitleAr).IsRequired();

                entity.Property(e => e.TitleEn).IsRequired();
            });

            modelBuilder.Entity<OnlineSupport>(entity =>
            {
                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CompanyName).IsRequired();

                entity.Property(e => e.CustomerType).IsRequired();

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.PhoneNumber).IsRequired();

                entity.Property(e => e.ProductModelNumber).IsRequired();
            });

            modelBuilder.Entity<OurProductDatum>(entity =>
            {
                entity.Property(e => e.SubTextAr)
                    .IsRequired()
                    .HasColumnName("subTextAr");

                entity.Property(e => e.SubTextEn)
                    .IsRequired()
                    .HasColumnName("subTextEn");

                entity.Property(e => e.TextAr).IsRequired();

                entity.Property(e => e.TextEn).IsRequired();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.CategoryId, "IX_Products_CategoryId");

                entity.Property(e => e.DescriptionAr).IsRequired();

                entity.Property(e => e.DescriptionEn).IsRequired();

                entity.Property(e => e.ProductNameAr).IsRequired();

                entity.Property(e => e.ProductNameEn).IsRequired();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId);
            });

            modelBuilder.Entity<ProductDownload>(entity =>
            {
                entity.HasIndex(e => e.ProductId, "IX_ProductDownloads_productId");

                entity.Property(e => e.DateTime).HasColumnName("dateTime");

                entity.Property(e => e.DownloadSize).IsRequired();

                entity.Property(e => e.LapleName).IsRequired();

                entity.Property(e => e.LapleNameAr).IsRequired();

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductDownloads)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.HasIndex(e => e.ProductId, "IX_ProductImages_ProductId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductImages)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<QustionAnswer>(entity =>
            {
                entity.HasIndex(e => e.TitleId, "IX_QustionAnswers_TitleId");

                entity.Property(e => e.AnswerAr).IsRequired();

                entity.Property(e => e.AnswerEn).IsRequired();

                entity.Property(e => e.QustionAr).IsRequired();

                entity.Property(e => e.QustionEn).IsRequired();

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.QustionAnswers)
                    .HasForeignKey(d => d.TitleId);
            });

            modelBuilder.Entity<QustionsTitle>(entity =>
            {
                entity.Property(e => e.TitleAr).IsRequired();

                entity.Property(e => e.TitleEn).IsRequired();
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasIndex(e => e.ParentServiceId, "IX_Services_ParentServiceId");

                entity.Property(e => e.ContentAr).IsRequired();

                entity.Property(e => e.ContentEn).IsRequired();

                entity.Property(e => e.ImgUrl).HasColumnName("imgUrl");

                entity.Property(e => e.TitleAr).IsRequired();

                entity.Property(e => e.TitleEn).IsRequired();

                entity.HasOne(d => d.ParentService)
                    .WithMany(p => p.InverseParentService)
                    .HasForeignKey(d => d.ParentServiceId);
            });

            modelBuilder.Entity<SupportImg>(entity =>
            {
                entity.Property(e => e.Faqimg).HasColumnName("FAQImg");
            });

            modelBuilder.Entity<SupportImgMainPage>(entity =>
            {
                entity.ToTable("SupportImgMainPage");

                entity.Property(e => e.IcontextAr).IsRequired();

                entity.Property(e => e.IcontextEn).IsRequired();

                entity.Property(e => e.SupportIconUrl).HasColumnName("SupportIConUrl");
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.HasIndex(e => e.ProductId, "IX_Titles_ProductId");

                entity.Property(e => e.ContentInAr).IsRequired();

                entity.Property(e => e.ContentInEn).IsRequired();

                entity.Property(e => e.TitleNameAr).IsRequired();

                entity.Property(e => e.TitleNameEn).IsRequired();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Titles)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<Training>(entity =>
            {
                entity.Property(e => e.TitleAr).IsRequired();

                entity.Property(e => e.TitleEn).IsRequired();

                entity.Property(e => e.YoutubeLink).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
