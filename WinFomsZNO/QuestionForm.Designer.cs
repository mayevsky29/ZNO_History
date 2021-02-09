
namespace WinFomsZNO
{
    partial class QuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumbAnswer = new System.Windows.Forms.Label();
            this.gbAnswers = new System.Windows.Forms.FlowLayoutPanel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.gbQuestionOptions = new System.Windows.Forms.GroupBox();
            this.gbAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumbAnswer
            // 
            this.lblNumbAnswer.AutoSize = true;
            this.lblNumbAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumbAnswer.ForeColor = System.Drawing.Color.Red;
            this.lblNumbAnswer.Location = new System.Drawing.Point(481, 22);
            this.lblNumbAnswer.Name = "lblNumbAnswer";
            this.lblNumbAnswer.Size = new System.Drawing.Size(104, 28);
            this.lblNumbAnswer.TabIndex = 8;
            this.lblNumbAnswer.Text = "Питання: ";
            // 
            // gbAnswers
            // 
            this.gbAnswers.Controls.Add(this.lblQuestion);
            this.gbAnswers.Location = new System.Drawing.Point(1, 54);
            this.gbAnswers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAnswers.Name = "gbAnswers";
            this.gbAnswers.Size = new System.Drawing.Size(637, 117);
            this.gbAnswers.TabIndex = 9;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestion.Location = new System.Drawing.Point(3, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(83, 20);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Запитання";
            // 
            // gbQuestionOptions
            // 
            this.gbQuestionOptions.Location = new System.Drawing.Point(4, 179);
            this.gbQuestionOptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbQuestionOptions.Name = "gbQuestionOptions";
            this.gbQuestionOptions.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbQuestionOptions.Size = new System.Drawing.Size(637, 241);
            this.gbQuestionOptions.TabIndex = 10;
            this.gbQuestionOptions.TabStop = false;
            this.gbQuestionOptions.Text = "Відповіді";
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 528);
            this.Controls.Add(this.gbAnswers);
            this.Controls.Add(this.gbQuestionOptions);
            this.Controls.Add(this.lblNumbAnswer);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.gbAnswers.ResumeLayout(false);
            this.gbAnswers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumbAnswer;
        private System.Windows.Forms.FlowLayoutPanel gbAnswers;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox gbQuestionOptions;
    }
}