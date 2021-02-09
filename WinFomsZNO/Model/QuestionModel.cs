using System;
using System.Collections.Generic;
using System.Text;

namespace WinFomsZNO.Model
{
    /// <summary>
    /// Питання
    /// </summary>
    public class QuestionModels
    {
        public string Text { get; set; }
        public List<QuestionAnswerModel> Answers { get; set; }
    }
    /// <summary>
    /// Варіанти відповідей 
    /// </summary>
    public class QuestionAnswerModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsTrue { get; set; }
    }
}
