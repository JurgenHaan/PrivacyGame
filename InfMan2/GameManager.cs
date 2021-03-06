﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace InfMan2
{
    class GameManager
    {
        private static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private static bool answer = false;
        private static string abcdAnswer = null;
        public static void startGamemode1()
        {
            DataFiller.fillQuestions();
            startTimer();
            showQuestion();
        }

        public static void startGamemode2()
        {
            DataFiller.fillQuestions();
            startTimer();
            showABCDQuestion();
        }

        public static void startTimer()
        {
            Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
            lastOpenedForm.Controls["label13"].Text = "30";
            timer = new System.Windows.Forms.Timer();
            timer.Tick += TimerEventProcessor;
            timer.Interval = 1000;
            timer.Start();
        }

        public static void showQuestion()
        {
            Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
            Random random = new Random();
            int index = random.Next(0,Data.trueFalseQuestionsList.Count);
            lastOpenedForm.Controls["label15"].Text = Data.trueFalseQuestionsList[index].Item1;
            answer = Data.trueFalseQuestionsList[index].Item2;
        }

        public static void clickedAnswerTrueFalse(bool clickedValue)
        {
            if (answer == clickedValue)
            {
                Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
                lastOpenedForm.Controls["label14"].Text = Int32.Parse(lastOpenedForm.Controls["label14"].Text) + Int32.Parse(lastOpenedForm.Controls["label13"].Text) + "";
                showQuestion();
            } else
            {
                timer.Stop();
                stopGame();
            }
        }

        private static void TimerEventProcessor(object myObject, EventArgs myEventArgs)
        {
            timer.Stop();
            Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();

            int time = Int32.Parse(lastOpenedForm.Controls["label13"].Text);


            lastOpenedForm.Controls["label13"].Text = time - 1 + "";
            if (time - 1 != 0)
            {
                timer.Start();
            } else
            {
                timer.Stop();
                stopGame();
            }
        }
        public static void stopGame()
        {
            Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
            lastOpenedForm.Controls["label18"].Text = lastOpenedForm.Controls["label14"].Text;
            lastOpenedForm.Controls["label14"].Text = "0";
            lastOpenedForm.Controls["label13"].Text = "30";
            ViewController.showScore();
        }
        public static void resetGame()
        {
            timer.Stop();
            timer = new System.Windows.Forms.Timer();
            Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
            lastOpenedForm.Controls["label14"].Text = "0";
            lastOpenedForm.Controls["label13"].Text = "30";
        }

        public static void clickedABCD(String value)
        {
            switch (value)
            {
                case "A":
                    if (abcdAnswer != null && abcdAnswer == "A") handleABCD(true);
                    else handleABCD(false);
                    break;
                case "B":
                    if (abcdAnswer != null && abcdAnswer == "B") handleABCD(true);
                    else handleABCD(false);
                    break;
                case "C":
                    if (abcdAnswer != null && abcdAnswer == "C") handleABCD(true);
                    else handleABCD(false);
                    break;
                case "D":
                    if (abcdAnswer != null && abcdAnswer == "D") handleABCD(true);
                    else handleABCD(false);
                    break;
                default:
                    break;
            }
        }

        public static void handleABCD(bool success)
        {
            if (success)
            {
                Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
                lastOpenedForm.Controls["label14"].Text = Int32.Parse(lastOpenedForm.Controls["label14"].Text) + Int32.Parse(lastOpenedForm.Controls["label13"].Text) + "";
                showABCDQuestion();
            }
            else
            {
                timer.Stop();
                stopGame();
            }
        }

        public static void showABCDQuestion()
        {
            Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
            Random random = new Random();
            int index = random.Next(0, Data.abcdQuestionsList.Count);
            lastOpenedForm.Controls["label15"].Text = Data.abcdQuestionsList[index].getQuestion();
            lastOpenedForm.Controls["button9"].Text = Data.abcdQuestionsList[index].getAnswerA();
            lastOpenedForm.Controls["button10"].Text = Data.abcdQuestionsList[index].getAnswerB();
            lastOpenedForm.Controls["button11"].Text = Data.abcdQuestionsList[index].getAnswerC();
            lastOpenedForm.Controls["button12"].Text = Data.abcdQuestionsList[index].getAnswerD();
            abcdAnswer = Data.abcdQuestionsList[index].getAnswer();
        }

    }
}
