using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALTP
{
    public partial class PlayForm : Form
    {

        private List<QuestionData> _questions = new List<QuestionData>();

        private int index_question = 0;
        public PlayForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckAnswer(4);

        }

        private void PlayForm_Load(object sender, EventArgs e)
        {

            // Calculate the center position of the screen
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;

            int left = (screenWidth - formWidth) / 2;
            int top = (screenHeight - formHeight) / 2;

            // Set the form's location to center screen
            this.Location = new Point(left, top);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            LoadQuestion();
            LoadQuestionData(index_question);
        }

        private void LoadQuestion()
        {

           QuestionData questionData1 = new QuestionData();

            questionData1.Question = "Ai là người đầu tiên đặt chân lên mặt trăng?";
            questionData1.Answer1 = "Neil Armstrong";
            questionData1.Answer2 = "Buzz Aldrin";
            questionData1.Answer3 = "Yuri Gagarin";
            questionData1.Answer4 = "John Glenn";
            questionData1.CorrectAnswer = "Neil Armstrong";

            QuestionData questionData2 = new QuestionData();

            questionData2.Question = "Quốc gia nào được biết đến với biệt danh \"Đất nước của những nụ cười\"?";
            questionData2.Answer1 = "Nhật Bản";
            questionData2.Answer2 = "Brazil";
            questionData2.Answer3 = "Thái Lan";
            questionData2.Answer4 = "Hàn Quốc";
            questionData2.CorrectAnswer = "Hàn Quốc";

            _questions.Add(questionData1);
            _questions.Add(questionData2);




            //Buzz Aldrin,Yuri Gagarin,John Glenn,Answer 1
            //Nhật Bản,Brazil,Thái Lan,Hàn Quốc,Answer 4

        }

        private void LoadQuestionData(int _index)
        {


            button1.Text = _questions[_index].Answer1;
            button2.Text = _questions[_index].Answer2;
            button3.Text = _questions[_index].Answer3;
            button4.Text = _questions[_index].Answer4;
            lb_question.Text = _questions[_index].Question;
        }


        private void CheckAnswer(int answerNumber)
        {

            // answer 1 => A
            // answer 2 => B
            // answer 3 => C
            // answer 4 => D
            string answerString = "";
            switch (answerNumber)
            {
                case 1:
                    answerString = _questions[index_question].Answer1;

                    break;

                case 2:
                    answerString = _questions[index_question].Answer2;

                    break;

                case 3:
                    answerString = _questions[index_question].Answer3;

                    break;

                case 4:
                    answerString = _questions[index_question].Answer4;

                    break;

                default:
                    answerString = _questions[index_question].Answer1;

                    break;

            }

            if (answerString.Equals(_questions[index_question].CorrectAnswer))
            {

                switch (answerNumber)
                {
                    case 1:

                        button1.BackColor = Color.Green;
                       


                        break;

                    case 2:
                        button2.BackColor = Color.Green;
                       
                        break;

                    case 3:

                      
                        button3.BackColor = Color.Green;

                        break;

                    case 4:
                       
                        button4.BackColor = Color.Green;
                        break;

                    default:
                        break;

                }


            }else
            {
                switch (answerNumber)
                {
                    case 1:

                        button1.BackColor = Color.Red;



                        break;

                    case 2:
                        button2.BackColor = Color.Red;

                        break;

                    case 3:


                        button3.BackColor = Color.Red;

                        break;

                    case 4:

                        button4.BackColor = Color.Red;
                        break;

                    default:
                        break;

                }

            }


            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckAnswer(2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckAnswer(3);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            index_question++;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            button1.BackColor = Color.Orange;
            button2.BackColor = Color.Orange;
            button3.BackColor = Color.Orange;
            button4.BackColor = Color.Orange;
            LoadQuestionData(index_question);

        }
    }
}
