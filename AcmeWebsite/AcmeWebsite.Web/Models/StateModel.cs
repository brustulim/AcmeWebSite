﻿namespace AcmeWebsite.Web.Models
{
    public class StateModel 
    {
        public string Acronym { get; set; }
        public string Name { get; set; }

        public StateModel()
        {
            
        }

        public StateModel(string acronym, string name)
        {
            Acronym = acronym;
            Name = name;
        }
    }
}