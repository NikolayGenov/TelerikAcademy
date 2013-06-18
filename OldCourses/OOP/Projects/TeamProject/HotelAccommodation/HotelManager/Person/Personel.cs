using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Collections.Generic;

namespace HotelManager.Person
{
    public class Personel : Person, IComunicate
    {
        public static uint ID = 100000;

        public ICollection<Languages> CollOfLanguages { get; set; }

        private const string PhraseToTranslate = "How are you today?";

        public Facility.Facility WorkPlace { get; set; }

        public decimal Salary { get; set; }

        protected const Languages BaseLanguage = Languages.EN;

        public Personel(string name, decimal salary) : base(name, salary)
        {
            this.Id = ID++;
            this.Salary = salary;
            this.WorkPlace = null;
            this.Wallet += salary;
        }

        public string Welcome(Languages langCode)
        {
            string phrase = String.Empty;
            switch (langCode)
            {
                case Languages.BG:
                    phrase = "Здравейте и добре дошли! Желаем Ви приятно изкарване!";
                    break;
                case Languages.DE:
                    phrase = "Hallo und herzlich willkommen! Wir wünschen Ihnen einen angenehmen Aufenthalt!"; // Translated by Google
                    break;
                case Languages.EN:
                    phrase = "Hello and Welcome! We wish you pleasant stay!";
                    break;
                case Languages.RU:
                    phrase = "Здравствуйте и добро пожаловать! Желаем Вам приятного отдыха!";
                    break;
                default:
                    break;
            }
            return phrase;
        }

        public string GoodBye(Languages langCode)
        {
            string phrase = String.Empty;
            switch (langCode)
            {
                case Languages.BG:
                    phrase = "Довиждане! Надяваме се отново да бъдете наши гости!";
                    break;
                case Languages.DE:
                    phrase = "Auf Wiedersehen! Wir hoffen, wieder unser Gast zu sein!"; // Translated by Google
                    break;
                case Languages.EN:
                    phrase = "Good bye! We hope to see you again!";
                    break;
                case Languages.RU:
                    phrase = "Досвидания! Мы будем рады приветствовать Вас сново!";
                    break;
                default:
                    break;
            }
            return phrase;
        }

        public string SayIt(Languages langCode, string phrase)
        {
            string languagePair = BaseLanguage.ToString().ToLower() + "|" + langCode.ToString().ToLower();
            string url = String.Format("http://translate.google.com/?hl=ru&ie=UTF8&text={0}&langpair={1}", phrase, languagePair);
            string result = phrase;
            string test = "<span title=\"" + phrase + "\"";
            string codePage = String.Empty;
            if (langCode != BaseLanguage)
            {
                switch (langCode)
                {
                    case Languages.BG:
                        codePage = "ISO-8859-5";
                        break;
                    case Languages.RU:
                        codePage = "KOI8-R";
                        break;
                    default:
                        codePage = "ISO-8859-1";
                        break;
                }
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.Encoding = System.Text.Encoding.GetEncoding(codePage);
                    result = webClient.DownloadString(url);
                    result = result.Substring(result.IndexOf(test));
                    result = result.Substring(result.IndexOf(">") + 1, res