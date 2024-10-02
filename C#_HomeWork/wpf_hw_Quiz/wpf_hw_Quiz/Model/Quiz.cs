using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using wpf_hw_Quiz.Model;


namespace wpf_hw_Quiz.Model
{
    public class Quiz
    {
        public List<Question> Questions { get; set; }
        public string Name { get; set; }
        public Quiz(List<Question> questions, string name)
        {
            Questions = questions;
            Name = name;
        }
        public static Quiz LoadQuiz(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Quiz file not found.", filePath);
            }

            var quizFile = File.ReadAllLines(filePath);
            var quizName = quizFile[0];
            List<Question> questions =new List<Question>();
            

            for (int i = 1; i < quizFile.Length; i++)
            {
                var parts = quizFile[i].Split('|');
                if (parts.Length < 4) continue; 

                int id = int.Parse(parts[0]);
                string questionText = parts[1];
                string[] answerText = parts[2].Split(',');
                string[] correctAnswers = parts[3].Split(',');

                var answers = new List<Answer>();
                for (int j = 0; j < answerText.Length; j++)
                {
                    answers.Add(new Answer(j + 1, answerText[j], correctAnswers[j] == "1"));
                }

                questions.Add(new Question(id, questionText, answers));
            }

            return new Quiz(questions, quizName);
        }
    }
}