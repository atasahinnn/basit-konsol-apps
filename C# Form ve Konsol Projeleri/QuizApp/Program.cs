using System;

namespace QuizKonsolApplikasyon
{
    class Program
    {

        class Question
        {
            public Question(string text, string[] choices, string answer)
            {
                this.Text = text;
                this.Choices = choices;
                this.Answer = answer;
            }

            public string Text { get; set; }

            public string[] Choices { get; set; }

            public string Answer { get; set; }

            public bool checkAnswer(string answer)
            {
                return this.Answer.ToLower() == answer.ToLower();
            }
        }

        class Quiz
        {
            public Quiz(Question[] questions)
            {
                this.Questions = questions;
                this.QuestionIndex = 0;
                this.Score = 0;
            }    
            
            private Question[] Questions { get; set; }

            private int QuestionIndex { get; set; }

            private int Score { get; set; }

            public Question GetQuestion()
            {
                return this.Questions[this.QuestionIndex];
            }

            public void DisplayQuestion()
            {
                var question = this.GetQuestion();
                this.DisplayProgress();
                Console.WriteLine($"Soru {this.QuestionIndex+1}: {question.Text}");

                  foreach (var c in question.Choices)
                  {
                      Console.WriteLine($"-{c}");
                  }

                Console.Write("Cevabınız:");
                var cevap = Console.ReadLine();

                this.Guess(cevap); // KONTROL METODUNA GÖNDERME --
            }

            public void Guess(string answer)
            {
                var question = this.GetQuestion();
                if (question.checkAnswer(answer))
                {
                    this.Score += 25;
                }
                
                this.QuestionIndex++;

                if (this.Questions.Length == this.QuestionIndex) // SORU INDEX SAYISINI KONTROL EDİYORUZ.
                {
                    this.DisplayScore();
                }


                else
                {
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                    this.DisplayQuestion();
                }
               
            }

            private void DisplayScore()
            {
                Console.WriteLine($"Skorunuz: { this.Score}");
            }

            private void DisplayProgress()
            {
                int totalQuestion = this.Questions.Length;
                int questionNumber = this.QuestionIndex + 1;

                if (totalQuestion >= questionNumber)
                {
                    Console.WriteLine($"Question {questionNumber} of {totalQuestion}");
                }
            }


        }

        static void Main(string[] args)
        {
            var q1 = new Question("En İyi Programlama Dili Hangisidir?", new string[] { "C++", "Python", "C#", "Java" }, "C#");
            var q2 = new Question("En Çok Kazandıran Progralama Dili Hangisidir?", new string[] { "Python", "C++", "C#", "Java" }, "C#");
            var q3 = new Question("En Güncel Progralama Dili Hangisidir?", new string[] { "C++", "C#", "Python", "Java" }, "C#");
            var q4 = new Question("Türkiye'nin Başkenti Neresidir?", new string[] { "İzmir", "İstanbul", "Ankara", "Bursa" }, "Ankara");

            var questions = new Question[] { q1, q2, q3, q4 };
            var quiz = new Quiz(questions);
            quiz.DisplayQuestion();

        }
    }
}
