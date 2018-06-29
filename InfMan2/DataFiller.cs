using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfMan2
{
    class DataFiller
    {
        public static void fillQuestions()
        {
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool, string>("Privacy is een afweerrecht dat de persoonlijke levenssfeer beschermt", true, "https://nl.wikipedia.org/wiki/Privacy"));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool, string>("Privacy is alleen de verantwoordelijkheid van de gebruiker, niet van de ontwikkelaar", false, "https://ictrecht.nl/2013/06/03/wie-is-er-verantwoordelijk-voor-bescherming-van-persoonsgegevens/"));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool, string>("Een veilige webomgeving herken je aan het hangslotje en aan de adresregel dat begint met https.", true, "https://www.webvalue.nl/blog/wat-is-https"));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool, string>("Privacy kan je onder andere beschermen door de voorwaarden van een" + System.Environment.NewLine + " applicatie te lezen die je gaat gebruiken", true, "https://decorrespondent.nl/1290/als-u-niet-akkoord-gaat-met-deze-onleesbare-privacyvoorwaarden-klik-toch-maar-op-ok/126038318670-261dbb73"));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool, string>("Mogen organisaties altijd mijn persoonsgegevens verwerken volgens" + System.Environment.NewLine + " de Wet bescherming persoonsgegevens (Wbp)?", false, "https://autoriteitpersoonsgegevens.nl/nl/onderwerpen/beveiliging/beveiliging-van-persoonsgegevens"));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool, string>("Organisaties moeten voldoen aan een aantal eisen van de Wet bescherming persoonsgegevens"+ System.Environment.NewLine + " (Wbp) bij het verwekend van persoonsgegevens",true, "https://autoriteitpersoonsgegevens.nl/nl/onderwerpen/beveiliging/beveiliging-van-persoonsgegevens"));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool, string>("Als een organisatie zich voldoet aan de eisen van de Wet " + System.Environment.NewLine + "bescherming persoonsgegevens (Wbp), betekent dit dat mijn informatie veilig is?", false, "https://eenvandaag.avrotros.nl/item/zijn-mijn-gegevens-veilig-met-de-avg-privacywet/"));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool, string>("Persoonsgegevens zijn geven direct of indirect informatie over een persoon", true, "https://mens-en-samenleving.infonu.nl/diversen/78075-wat-zijn-persoonsgegevens-en-hoe-worden-deze-beschermd.html"));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool, string>("Bedrijven kunnen geen boete krijgen bij het overtreden van privacy wetten", false, "https://www.vandiepen.com/2015/10/wijziging-wet-bescherming-persoonsgegevens-vanaf-2016-meldplicht-datalekken-en-groter-boeterisico-bij-schending-privacyregels/"));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool, string>("Werkgevers mogen medische gegevens opslaan in een personeelsdossier", false, "https://www.hr-kiosk.nl/hoofdstuk/personeelsdossier"));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool, string>("Mag een werkgever een internet search doen naar werknemers of sollicitanten?", false, "https://www.xperthractueel.nl/recruitment/mag-je-een-sollicitant-googlen/"));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool, string>("Mag een werkgever met als reden ‘’Privé internetten is verboden’’, bijhouden wat zijn werknemers doen op hun PC of via de bedrijfs internetverbinding", false, "https://ictrecht.nl/2011/09/29/monitoren-van-werknemers-hoe-ver-mag-je-gaan/"));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool, string>("Is het plaatsen van een GPS, C-track of Blackbox-systeem in wagens van chauffeurs ivm de planning toegestaan ? ", true, "https://www.fnv.nl/themas/or-en-pvt/privacy-op-je-werk/volgsystemen/"));

            Data.abcdQuestionsList.Add(new ABCDModel("Wat is privacy?", "B", "Een spel", "Een afweerrecht", "Een hoax","Een ideologie", "https://nl.wikipedia.org/wiki/Privacy"));
            Data.abcdQuestionsList.Add(new ABCDModel("Waarvoor is privacy bedoelt?", "A", "Persoonlijke gegevens beschermen", "Toegang geven tot je gegevens", "Delen van informatie", "Afschermen van anderen", "https://nl.wikipedia.org/wiki/Privacy"));
            Data.abcdQuestionsList.Add(new ABCDModel("Waar staat AVG voor ?", "A", "Algemene Verordering Gegevensbescherming", "Algemene Gegevens Verdediging", "Algemene Verdediging Gezondheid", "Algemene Voordering Gemeenschap", "https://autoriteitpersoonsgegevens.nl/nl/onderwerpen/avg-europese-privacywetgeving/algemene-informatie-avg"));
            Data.abcdQuestionsList.Add(new ABCDModel("Naar welke informatie mag een werkgever NIET informeren in geval van een ziektemelding", "B", "Of de ziekte verband houdt met een arbeidsongeval", "De aard en oorzaak van de ziekte", "De vermoedelijke duur van het verzuim", "Hoe het gaat", "https://autoriteitpersoonsgegevens.nl/nl/onderwerpen/werk-en-uitkering/zieke-werknemers"));
            Data.abcdQuestionsList.Add(new ABCDModel("Hoelang mogen camerabeelden door de werkgever worden bewaard?", "C", "Max 1 week", "Max 2 week", "Max 4 week", "Max 8 week", "https://autoriteitpersoonsgegevens.nl/nl/onderwerpen/cameratoezicht/cameratoezicht-op-de-werkplek"));
            Data.abcdQuestionsList.Add(new ABCDModel("Wat bedraagt de maximale boete voor het overtreden van de Wet bescherming persoonsgegevens ? ", "C", "Ruim 500.000 euro", "Ruim 600.000 euro", "Ruim 800.000 euro", "Ruim 1.000.000 euro", "https://autoriteitpersoonsgegevens.nl/nl/over-de-autoriteit-persoonsgegevens/taken-en-bevoegdheden/onderzoek-en-handhaving"));
            Data.abcdQuestionsList.Add(new ABCDModel("Waar staat GDPR voor?", "C", "Genootschap voor PR functionarissen", "Internationale privacy wetgevig", "General Data Protection Regulation: nieuwe Europese richtlijnen voor privacy wetgeving", "General Data Project Rules: regels voor opslag van data bij projecten", "https://www.atvalley.nl/wat-is-de-gdpr/"));
            Data.abcdQuestionsList.Add(new ABCDModel("Per wanneer is de nieuwe privacy regelgeving in werking", "C", "1 mei 2016", "25 mei 2018", "In werking getreden in mei 2016; vanaf 25 mei 2018 van toepassing", "September 2001", "https://autoriteitpersoonsgegevens.nl/nl/onderwerpen/avg-europese-privacywetgeving"));
            Data.abcdQuestionsList.Add(new ABCDModel("Wat zijn bijzondere persoonsgegevens", "B", " Persoonsgegevens die op een bijzondere manier zijn verkregen, bv door data mining of machine learning", "Minder voor de hand liggende gegevens die kunnen leiden tot de unieke identificatie van een persoon; bv ras", "Gegevens over bijzondere personen bv BN-ers, die extra informatie geven over een individu", "Gegevens die in combinatie met andere persoonsgegevens, al dan niet automatisch verwerkt,  kunnen leiden tot identificatie van een persoon", "https://www.smithanddoe.com/blog-wat-zijn-bijzondere-persoonsgegevens-avg"));
            Data.abcdQuestionsList.Add(new ABCDModel("Tot welke leeftijd is toestemming van ouders nodig bij het verwerken van gegevens van kinderen", "D", "Tot 12 jaar", "Tot 21 jaar", "Tot 18 jaar", "Tot 16 jaar", "https://autoriteitpersoonsgegevens.nl/nl/nieuws/mag-ik-onder-de-avg-gegevens-van-kinderen-verwerken"));
            Data.abcdQuestionsList.Add(new ABCDModel("Welk % van de grote organisaties in Nederland is al helemaal klaar voor de invoering GDPR", "D", "10%", "125%", "50%", "60%", "https://www.consultancy.nl/nieuws/16929/organisaties-krijgen-megaklus-aan-gdpr-avg-verzoeken-van-burgers"));
            Data.abcdQuestionsList.Add(new ABCDModel("Wat is pseudonimisering", "C", "Het zodanig bewerken van gegevens dat deze niet meer naar een persoon te herleiden zijn", "Het anoniem maken van persoonsgegevens", "Het verwerken van persoonsgegevens op zodanige wijze dat deze niet meer aan een specifieke betrokkene kunnen worden gekoppeld zonder aanvullende gegevens", "Het verwijderen van NAW-gegevens", "https://nl.wikipedia.org/wiki/Pseudonimiseren"));
        }

        public static void fillHighscore()
        {
            Data.list.Sort((x, y) => y.Item2.CompareTo(x.Item2));
            Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
            lastOpenedForm.Controls["label5"].Text = (Data.list != null && Data.list.Count >= 1) ? Data.list[0].Item1 : "-";
            lastOpenedForm.Controls["label6"].Text = (Data.list != null && Data.list.Count >= 1) ? Data.list[0].Item2 + "" : "-";

            lastOpenedForm.Controls["label8"].Text = (Data.list != null && Data.list.Count >= 2) ? Data.list[1].Item1 : "-";
            lastOpenedForm.Controls["label9"].Text = (Data.list != null && Data.list.Count >= 2) ? Data.list[1].Item2 + "" : "-";

            lastOpenedForm.Controls["label11"].Text = (Data.list != null && Data.list.Count >= 3) ? Data.list[2].Item1 : "-";
            lastOpenedForm.Controls["label12"].Text = (Data.list != null && Data.list.Count >= 3) ? Data.list[2].Item2 + "" : "-";
        }

        public static void storeScore(String username, int score)
        {
            Data.list.Add(new Tuple<string, int>(username, score));
        }
    }
}
