using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZNO_History
{
    public class DbSeeder
    {
        public static void SeedAll(MyContext context)
        {
            SeedQuestion(context);
            SeedUser(context);
            SeedSession(context);
            SeedResult(context);
        }

        private static void SeedQuestion(MyContext context)
        {
            if(context.Questions.Count() == 0)
            {
                var question = new Question
                {
                    Text = "Якого року відбулося хрещення на Русі?",
                };

                context.Questions.Add(question);
                context.SaveChanges();

                var answers = new List<Answer>
                {
                    new Answer {Text="912", IsTrue = false, QuestionId = question.Id},
                    new Answer {Text="957", IsTrue = false, QuestionId = question.Id},
                    new Answer {Text="988", IsTrue = true, QuestionId = question.Id},
                    new Answer {Text="1037", IsTrue = false, QuestionId = question.Id},
                };

                context.Answers.AddRange(answers);
                context.SaveChanges();

                question = new Question
                {
                    Text = "Хто спалив Коростень?",
                };

                context.Questions.Add(question);
                context.SaveChanges();

                answers = new List<Answer>
                {
                    new Answer {Text="Князь Олег", IsTrue = false, QuestionId = question.Id},
                    new Answer {Text="Князь Ігор", IsTrue = false, QuestionId = question.Id},
                    new Answer {Text="Князь Володимир", IsTrue = false, QuestionId = question.Id},
                    new Answer {Text="Княгиня Ольга", IsTrue = true, QuestionId = question.Id},
                };

                context.Answers.AddRange(answers);
                context.SaveChanges();
            }
        }

        private static void SeedUser(MyContext context)
        {
            if (context.Users.Count() == 0)
            {
                context.Users
                    .Add(
                    new User
                    {
                        FirstName = "Василь",
                        LastName = "Петрук",
                        Login = "vasia",
                        Password = "123"

                    });
                context.SaveChanges();
            }
        }

        private static void SeedSession(MyContext context)
        {
            if (context.Sessions.Count() == 0)
            {
                context.Sessions
                    .Add(
                    new Session
                    {
                        Begin = DateTime.Now,
                        End = DateTime.Now.AddMinutes(10),
                        Marks = 70.1M,
                        UserId = 1
                    });
                  context.SaveChanges();
            }
        }

        private static void SeedResult(MyContext context)
        {
            if (context.Results.Count() == 0)
            {
                context.Results
                    .Add(
                    new Result
                    {
                        SessionId = 1,
                        AnswerId = 3
                    });
                context.Results
                    .Add(
                    new Result
                    {
                        SessionId = 1,
                        AnswerId = 8
                    });
                context.SaveChanges();
            }
        }
    }
}
