﻿using System.Collections.Generic;

namespace PsychotherapistWebSite.Core.Models
{
    public class Info
    {
        public int Id { get; set; }
        public string PersonName { get; set; }
        public string PersonTitle { get; set; }
        public string Phone { get; set; }
        public Adress Adress { get; set; }
        public string FaceBookUrl { get; set; }
        public string YouTubeUrl { get; set; }
        public string TweeterUrl { get; set; }
        public string AboutMe { get; set; }
    }
}