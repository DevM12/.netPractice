using System;

namespace QuizAppTest
{
	internal class Quiz
	{
		private Question[] questions;
		private int score;

		public Quiz(Question[] questions)
		{
			this.questions = questions;
			this.score = 0;

		}
		public void StartQuiz()
		{
			Console.WriteLine("Welcome to the Quiz!");
			foreach (var question in questions)
			{
				DisplayQuestion(question);

				int userChoice=GetUserChoice(question.Answers.Length);

				if (question.IsCorrectAnswer(userChoice ))
				{
					Console.WriteLine("Correct!");
					score++;
				}
				else
				{
					Console.WriteLine($"Incorrect! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
				}
				Console.WriteLine("\n");
			}
			DisplayResults();
			
        }
		public void DisplayQuestion(Question question)
		{
            Console.WriteLine(question.QuestionText);
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {question.Answers[i]}");
            }
        }
		public void DisplayResults()
		{
            Console.WriteLine($"\n\nQuiz completed! Your score is: {score}/{questions.Length}");
			if (score == questions.Length)
			{
				Console.WriteLine("Congratulations! You scored a perfect score.");
            }
			else if(score >= questions.Length / 2)
			{
                Console.WriteLine("Congratulations! You passed the quiz");
            }
			else
			{
                Console.WriteLine("Bund mara!!!!!!!");
            }
        }
		public int GetUserChoice(int len)
		{
            while (true)
            {
                Console.Write("Please enter your answer (1-4): ");
                if (int.TryParse(Console.ReadLine(), out int userChoice) && userChoice >= 1 && userChoice <= len)
                {
                    return userChoice;
                }
                Console.WriteLine("Invalid choice. Please try again.");
            }		
        }
	}
}