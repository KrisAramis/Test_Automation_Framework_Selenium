﻿namespace WebApplication.API.Modeles.ResponseModels
{
    public class AllBiblesModel
    {
        public Bible[] data { get; set; }
    }
    
    public class Bible
    {
        public string id { get; set; }
        public string dblId { get; set; }
        public string abbreviation { get; set; }
        public string abbreviationLocal { get; set; }
        public Language language { get; set; }
        public Countries[] countries { get; set; }
        public string name { get; set; }
        public string nameLocal { get; set; }
        public string description { get; set; }
        public string descriptionLocal { get; set; }
        public string relatedDbl { get; set; }
        public string type { get; set; }
        public string updatedAt { get; set; }
        public AudioBibles[] audioBibles { get; set; }
    }

    public class Language
    {
        public string id { get; set; }
        public string name { get; set; }
        public string nameLocal { get; set; }
        public string script { get; set; }
        public string scriptDirection { get; set; }
    }

    public class Countries
    {
        public string id { get; set; }
        public string name { get; set; }
        public string nameLocal { get; set; }
    }

    public class AudioBibles
    {
        public string id { get; set; }
        public string name { get; set; }
        public string nameLocal { get; set; }
        public string description { get; set; }
        public string descriptionLocal { get; set; }
    }
    }
    


