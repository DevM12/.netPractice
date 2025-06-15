using System;

namespace QuizAppTest
{
   internal class Question
    {
        public string QuestionText { get;  }
        public string[] Answers { get; }
        public int CorrectAnswerIndex { get; }

        public Question(string questionText, string[] answers, int correctAnswerIdx)
        {
            this.QuestionText = questionText;
            this.Answers = answers;
            this.CorrectAnswerIndex = correctAnswerIdx;
        }

        public bool IsCorrectAnswer(int choice)
        {
            return choice == CorrectAnswerIndex;
        }
    }
}