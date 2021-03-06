﻿using System;
namespace SpeakerShopApp.Core.Entity
{
    public class Speaker
    {
        public int SpeakerId { get; set; }

        public string SpeakerName { get; set; }

        public string SpeakerDescription { get; set; }

        public double Price { get; set; }

        public string Color { get; set; }

        public string Brand { get; set; }

        public Brand SpeakerBrand { get; set; }

        public string Url { get; set; }
    }

}
