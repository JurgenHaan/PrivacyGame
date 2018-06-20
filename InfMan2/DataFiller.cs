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
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool>("Privacy is een afweerrecht dat de persoonlijke levenssfeer beschermt", true));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool>("Privacy is alleen de verantwoordelijkheid van de gebruiker, niet van de ontwikkelaar", false));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool>("Een veilige webomgeving herken je aan het hangslotje en aan de adresregel dat begint met https.", true));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool>("Privacy kan je onder andere beschermen door de voorwaarden van een" + System.Environment.NewLine + " applicatie te lezen die je gaat gebruiken", true));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool>("Mogen organisaties altijd mijn persoonsgegevens verwerken volgens" + System.Environment.NewLine + " de Wet bescherming persoonsgegevens (Wbp)?", false));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool>("Organisaties moeten voldoen aan een aantal eisen van de Wet bescherming persoonsgegevens"+ System.Environment.NewLine + " (Wbp) bij het verwekend van persoonsgegevens",true));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool>("Als een organisatie zich voldoet aan de eisen van de Wet " + System.Environment.NewLine + "bescherming persoonsgegevens (Wbp), betekent dit dat mijn informatie veilig is?", false));
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool>("Persoonsgegevens zijn geven direct of indirect informatie over een persoon", true));

            Data.abcdQuestionsList.Add(new ABCDModel("Wat is privacy?", "B", "Een spel", "Een afweerrecht", "Een hoax","Een ideologie"));
            Data.abcdQuestionsList.Add(new ABCDModel("Waarvoor is privacy bedoelt?", "A", "Persoonlijke gegevens beschermen", "Toegang geven tot je gegevens", "Delen van informatie", ""));
            Data.abcdQuestionsList.Add(new ABCDModel("Waar staat AVG voor ?", "B", "Algemene Verordering Gegevensbescherming", "Algemene Gegevens Verdediging", "Algemene Verdediging Gezondheid", "Algemene Voordering Gemeenschap"));

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
