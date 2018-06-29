using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfMan2
{
    class Data
    {
        public static List<Tuple<String, int>> list = new List<Tuple<string, int>>();
        public static List<Tuple<String, bool, String>> trueFalseQuestionsList = new List<Tuple<string, bool, String>>();
        public static List<ABCDModel> abcdQuestionsList = new List<ABCDModel>();
        public static int TotalScore = 0;
        public static int TotalSkips = 0;
        public static int TotalTimeStops = 0;
        public static int TotalExtenders = 0;

    }
}
