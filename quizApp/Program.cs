namespace QuizAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question("What is th capital of France?", new string[] {"Berlin","Madrid","Paris","Rome" },2),
                new Question("What is th capital of France?", new string[] {"Berlin","Madrid","Paris","Rome" },2),
                new Question("What is th capital of France?", new string[] {"Berlin","Madrid","Paris","Rome" },2)
            };

            Quiz quiz = new Quiz(questions);
            quiz.StartQuiz();
            Console.ReadKey();
        }
    }
}