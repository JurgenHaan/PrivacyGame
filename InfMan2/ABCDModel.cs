﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfMan2
{
    class ABCDModel
    {
        private string question;
        private string answerA;
        private string answerB;
        private string answerC;
        private string answerD;
        private string correctAnswer;
        private string URL;

        public ABCDModel(string question, string answer, string A, string B, string C, string D, string URL)
        {
            this.question = question;
            this.answerA = A;
            this.answerB = B;
            this.answerC = C;
            this.answerD = D;
            this.correctAnswer = answer;
            this.URL = URL;
        }

        public string getQuestion()
        {
            return question;
        }

        public string getAnswer()
        {
            return correctAnswer;
        }

        public string getAnswerA()
        {
            return answerA;
        }
        public string getAnswerB()
        {
            return answerB;
        }
        public string getAnswerC()
        {
            return answerC;
        }
        public string getAnswerD()
        {
            return answerD;
        }

        public string getURL()
        {
            return URL;
        }
    }
}
