using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using wpf_hw_Quiz.Model;

namespace wpf_hw_Quiz.ViewModel
{
    public class QuizViewModel : INotifyPropertyChanged
    {
        public Quiz CurrentQuiz { get; set; }
        public Answer CurrentAnswer { get; set; }

        private Question _currentQuestion;
        public Question CurrentQuestion
        {
            get { return _currentQuestion; }
            set
            {
                _currentQuestion = value;
                OnPropertyChanged("CurrentQuestion");
            }
        }
        private int _countCurrent;
        public int CountCurrent
        {
            get { return _countCurrent; }
            set
            {
                _countCurrent = value;
                OnPropertyChanged("CountCurrent");
            }
        }
        private int _countCorrect;
        public int CountCorrect
        {
            get { return _countCorrect; }
            set
            {
                _countCorrect = value;
                OnPropertyChanged("CountCorrect");
            }
        }

        public ICommand SelectedAnswer { get; set; }
        public ICommand NextQuestion { get; set; }

        public QuizViewModel()
        {
            CurrentQuiz = Quiz.LoadQuiz("questions.txt");
            CurrentQuestion = CurrentQuiz.Questions[0];
            CountCurrent = 1;
            CountCorrect = 0;

            SelectedAnswer = new DelegateCommand(SelectedAnswerHandler);
            NextQuestion = new DelegateCommand(NextQuestionHandler);
        }
        public void SelectedAnswerHandler(Object obj)
        {
            if (obj is Answer)
            {
                CurrentAnswer = obj as Answer;

                foreach (Answer answer in CurrentQuestion.Answers)
                {
                    answer.SetColor(false);
                }

                CurrentAnswer.SetColor(true);

                Question temp = CurrentQuestion;
                CurrentQuestion = null;
                CurrentQuestion = temp;
            }
        }
        public void NextQuestionHandler(Object obj)
        {
            if (CurrentAnswer.IsCorrect)
                CountCorrect++;

            if (CountCurrent >= 5)
            {
                MessageBox.Show($"Your result is: {CountCorrect}", "Congrats!", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if (CurrentAnswer == null)
            {
                MessageBox.Show("CurrentAnswer == null", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }           

            CountCurrent++;
            CurrentQuestion = CurrentQuiz.Questions[CountCurrent - 1];

            CurrentAnswer = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}