using System;
using System.Collections.Generic;

namespace ideal_rotary_phone.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Card
    {
        public string CardTitle { get; set; }
        public string Image { get; set; }
        public string Subtitle { get; set; }
        public string Body { get; set; }

    }

    public class Homepage
    {
        public string title { get; set; }
        public string languageType { get; set; }
        public string active { get; set; }
        public string footer { get; set; }
        public List<Card> Card { get; set; }

    }

    public class Faq
    {
        public string questions { get; set; }
        public string Whatarethehealthrisk { get; set; }
        public string Whereisthetrialsite { get; set; }
        public string HowdoIqualifyforthetrail { get; set; }
        public string HowmanypaidtrialsamIabletodoayear { get; set; }

    }

    public class FAQS
    {
        public string title { get; set; }
        public string languageType { get; set; }
        public string active { get; set; }
        public List<Faq> faq { get; set; }

    }

    public class InfoCard
    {
        public string email { get; set; }
        public string phone { get; set; }
        public string mapImage { get; set; }
        public string address { get; set; }

    }

    public class Contact
    {
        public string title { get; set; }
        public string languageType { get; set; }
        public string active { get; set; }
        public InfoCard infoCard { get; set; }

    }

    public class TrailQuestions
    {
        public string Questions { get; set; }

    }

    public class TrialResponse
    {
        public string accept { get; set; }
        public string denied { get; set; }

    }

    public class Trials
    {
        public string title { get; set; }
        public string languageType { get; set; }
        public string active { get; set; }
        public TrailQuestions trailQuestions { get; set; }
        public TrialResponse trialResponse { get; set; }

    }

    public class Faq2
    {
        public string questions { get; set; }
        public string whatisapaidtrial { get; set; }

    }

    public class Confirmation
    {
        public bool youareabletotraveltosite { get; set; }
        public bool youdonotregularlytakerecdrugs { get; set; }
        public bool youdonotdrinkexcessively { get; set; }

    }

    public class Participate
    {
        public string languageType { get; set; }
        public string active { get; set; }
        public string mapImage { get; set; }
        public Faq2 faq { get; set; }
        public Confirmation confirmation { get; set; }

    }

    public class CMSModel
    {
        public string primaryColor { get; set; }
        public string secondaryColor { get; set; }
        public string tertiaryColor { get; set; }
        public string quaternary { get; set; }
        public string primaryFont { get; set; }
        public string secondaryFont { get; set; }
        public Homepage Homepage { get; set; }
        public FAQS FAQS { get; set; }
        public Contact Contact { get; set; }
        public Trials Trials { get; set; }
        public Participate participate { get; set; }

    }




}
