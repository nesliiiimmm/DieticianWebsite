using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DieticianWebSite.Models
{
    public partial class DieticianWebSiteContext : DbContext
    {
        public DieticianWebSiteContext()
        {
        }

        public DieticianWebSiteContext(DbContextOptions<DieticianWebSiteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DanismaSoruları> DanismaSoruları { get; set; }
        public virtual DbSet<DiyetProgrami> DiyetProgrami { get; set; }
        public virtual DbSet<SoruCevap> SoruCevap { get; set; }
        public virtual DbSet<TarifAsama> TarifAsama { get; set; }
        public virtual DbSet<Tarifler> Tarifler { get; set; }
        public virtual DbSet<Uye> Uye { get; set; }
        public virtual DbSet<UyeDurum> UyeDurum { get; set; }
        public virtual DbSet<UyeGiris> UyeGiris { get; set; }
        public virtual DbSet<Yazilar> Yazilar { get; set; }
        public virtual DbSet<Yorum> Yorum { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var b = Startup.Configuration["DbConnection"];
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(b);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanismaSoruları>(entity =>
            {
                entity.Property(e => e.Baslık).HasMaxLength(50);

                entity.Property(e => e.Icerik).HasMaxLength(50);

                entity.Property(e => e.Tarih).HasColumnType("date");

                entity.HasOne(d => d.Uye)
                    .WithMany(p => p.DanismaSoruları)
                    .HasForeignKey(d => d.UyeId)
                    .HasConstraintName("FK_DanismaSoruları_Uye");
            });

            modelBuilder.Entity<DiyetProgrami>(entity =>
            {
                entity.Property(e => e.HaftalikMiAylikMi).HasColumnName("HaftalikMiAylik,Mi");

                entity.Property(e => e.Tarih).HasColumnType("date");

                entity.HasOne(d => d.Uye)
                    .WithMany(p => p.DiyetProgrami)
                    .HasForeignKey(d => d.UyeId)
                    .HasConstraintName("FK_DiyetProgrami_Uye");
            });

            modelBuilder.Entity<SoruCevap>(entity =>
            {
                entity.Property(e => e.SoruMuCevapMi).HasColumnName("SoruMuCevapMI");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.SoruCevapNavigation)
                    .WithMany(p => p.InverseSoruCevapNavigation)
                    .HasForeignKey(d => d.SoruCevapId)
                    .HasConstraintName("FK_SoruCevap_SoruCevap");
            });

            modelBuilder.Entity<TarifAsama>(entity =>
            {
                entity.HasOne(d => d.Tarif)
                    .WithMany(p => p.TarifAsama)
                    .HasForeignKey(d => d.TarifId)
                    .HasConstraintName("FK_TarifAsama_Tarifler");
            });

            modelBuilder.Entity<Tarifler>(entity =>
            {
                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.Tarih).HasColumnType("date");
            });

            modelBuilder.Entity<Uye>(entity =>
            {
                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.DogumTarihi).HasColumnType("date");

                entity.Property(e => e.Eposta)
                    .HasColumnName("EPosta")
                    .HasMaxLength(50);

                entity.Property(e => e.Meslek).HasMaxLength(50);

                entity.Property(e => e.Sehir).HasMaxLength(50);

                entity.Property(e => e.Soyadi).HasMaxLength(50);

                entity.Property(e => e.Tarih).HasMaxLength(10);

                entity.Property(e => e.Telefon).HasMaxLength(50);
            });

            modelBuilder.Entity<UyeDurum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Kilo).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tarih).HasColumnType("date");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.UyeDurum)
                    .HasForeignKey<UyeDurum>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UyeDurum_Uye");
            });

            modelBuilder.Entity<UyeGiris>(entity =>
            {
                entity.HasKey(e => e.UyeId);

                entity.Property(e => e.UyeId).ValueGeneratedNever();

                entity.Property(e => e.KullaniciAdi).HasMaxLength(50);

                entity.Property(e => e.Sifre).HasMaxLength(50);

                entity.HasOne(d => d.Uye)
                    .WithOne(p => p.UyeGiris)
                    .HasForeignKey<UyeGiris>(d => d.UyeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UyeGiris_Uye");
            });

            modelBuilder.Entity<Yazilar>(entity =>
            {
                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.Tarih).HasColumnType("date");
            });

            modelBuilder.Entity<Yorum>(entity =>
            {
                entity.Property(e => e.Icerik).HasMaxLength(10);

                entity.Property(e => e.KullaniciAdi).HasMaxLength(50);

                entity.Property(e => e.KullaniciMail)
                    .HasColumnName("kullaniciMail")
                    .HasMaxLength(50);

                entity.Property(e => e.Yyb).HasColumnName("YYB");
            });
        }
    }
}
