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
            Data.trueFalseQuestionsList.Add(new Tuple<string, bool>("HTTPS staat voor HyperText Transfer Protocol Secure", true));
            Data.abcdQuestionsList.Add(new ABCDModel("Wat is privacy?", "B", "Een spel", "Een afweerrecht", "Een hoax","Een ideologie"));
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
