﻿using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace MebFinalApp.Model.Entity
{
    public partial class Urunler:AuditableEntity,IBaseDomain
    {
        public Urunler()
        {
            SatisDetaylaris = new HashSet<SatisDetaylari>();
        }

        public int UrunId { get; set; }
        public string UrunAdi { get; set; } = null!;
        public int? TedarikciId { get; set; }
        public int? KategoriId { get; set; }
        public string? BirimdekiMiktar { get; set; }
        public decimal? BirimFiyati { get; set; }
        public short? HedefStokDuzeyi { get; set; }
        public short? YeniSatis { get; set; }
        public short? EnAzYenidenSatisMikatari { get; set; }
        public bool Sonlandi { get; set; }

        public virtual Kategoriler? Kategori { get; set; }
        public virtual Tedarikciler? Tedarikci { get; set; }
        public virtual ICollection<SatisDetaylari> SatisDetaylaris { get; set; }
    }
}
