using System;
using System.Linq;
using System.Net;
using System.Text;
using HotelManager.Facility;
using System.Collections.Generic;

namespace HotelManager.Person
{
    public class Personel : Person, IComunicate
    {
        public ICollection<Languages> CollOfLanguages { get; set; }

        private const string PhraseToTranslate = "How are you today?";

        public Facility.Facility WorkPlace { get; set; }

        public decimal Salary { get; set; }

        protected const Languages BaseLanguage = Languages.EN;

        public Personel(uint id, string name, decimal salary) : base(id, name, salary)
        {
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
                    result = result.Substring(result.IndexOf(">") + 1, result.IndexOf("</span") - result.IndexOf(">") - 1);
                }
                catch (WebException we)
                {
                    throw new PersonException("No connection to brain!", we);
                }
            }
            return result;
        }

        public string Speak(Languages langCode)
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine(Welcome(langCode));
            text.AppendLine(SayIt(langCode, PhraseToTranslate));
            text.AppendLine(GoodBye(langCode));
            return text.ToString();
        }

        public ICollection<Languages> IsAbleToSpeakIn()
        {
            return this.CollOfLanguages;
        }
        
        public string CanSpeak()
        {
            StringBuilder infoLang = new StringBuilder();
            infoLang.Append("Press :");
            foreach (var lang in CollOfLanguages)
            {
                infoLang.AppendFormat(" {0} for {1} ", (int)lang, lang);
            }
            return infoLang.ToString();
        }
    }
}