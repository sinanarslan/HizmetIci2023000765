﻿using System;
using System.Collections.Generic;

namespace MebFinalApp.Model.Entity
{
    public partial class Tedarikciler
    {
        public Tedarikciler()
        {
            Urunlers = new HashSet<Urunler>();
        }

        public int TedarikciId { get; set; }
        public string SirketAdi { get; set; } = null!;
        public string? MusteriAdi { get; set; }
        public string? MusteriUnvani { get; set; }
        public string? Adres { get; set; }
        public string? Sehir { get; set; }
        public string? Bolge { get; set; }
        public string? PostaKodu { get; set; }
        public string? Ulke { get; set; }
        public string? Telefon { get; set; }
        public string? Faks { get; set; }
        public string? WebSayfasi { get; set; }

        public virtual ICollection<Urunler> Urunlers { get; set; }
    }
}
