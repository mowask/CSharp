using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace wpf_hw_Quiz.Model
{
    public class Answer
    {
        public int Index { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public SolidColorBrush Color { get; set; }
        public Answer(int index, string text, bool isCorrect)
        {
            Index = index;
            Text = text;
            IsCorrect = isCorrect;
            Color = new SolidColorBrush(Colors.Gray);
        }
        public void SetColor(bool isSelected)
        {
            if (isSelected)
                Color = new SolidColorBrush(Colors.PeachPuff);
            else
                Color = new SolidColorBrush(Colors.Gray);
        }
    }
}