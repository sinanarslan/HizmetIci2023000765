using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace MebFinalApp.Model.Entity
{
    public partial class Personeller:AuditableEntity,IBaseDomain
    {
        public Personeller()
        {
            InverseBagliCalistigiKisiNavigation = new HashSet<Personeller>();
            Satislars = new HashSet<Satislar>();
            Territories = new HashSet<Bolgeler>();
        }

        public int PersonelId { get; set; }
        public string SoyAdi { get; set; } = null!;
        public string Adi { get; set; } = null!;
        public string? Unvan { get; set; }
        public string? UnvanEki { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public DateTime? IseBaslamaTarihi { get; set; }
        public string? Adres { get; set; }
        public string? Sehir { get; set; }
        public string? Bolge { get; set; }
        public string? PostaKodu { get; set; }
        public string? Ulke { get; set; }
        public string? EvTelefonu { get; set; }
        public string? Extension { get; set; }
        public byte[]? Fotograf { get; set; }
        public string? Notlar { get; set; }
        public int? BagliCalistigiKisi { get; set; }
        public string? FotografPath { get; set; }
        public string? BenimKolonum { get; set; }

        public virtual Personeller? BagliCalistigiKisiNavigation { get; set; }
        public virtual ICollection<Personeller> InverseBagliCalistigiKisiNavigation { get; set; }
        public virtual ICollection<Satislar> Satislars { get; set; }

        public virtual ICollection<Bolgeler> Territories { get; set; }
    }
}
