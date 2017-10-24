using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR3L
{
    public partial class Form1 : Form
    {
        public double[,] massMain = new double[3, 3] {
            {1, 3, 0.25 },
            {0.5, 1, 0.2 },
            {4, 0.55, 1 },
        };

        
        public double[,] massNormMain = new double[3, 3] {
            {0, 0, 0 },
            {0, 0, 0 },
            {0, 0, 0 },
        };

        public double [] massRowSum = new double[3] { 0, 0, 0 };
        public double [] massMidNormal = new double[3] { 0, 0, 0 };
        public double [] massMumnoz = new double[3] {0, 0, 0 };
        public double input = 0;
/* ************************************************************************** */
        public double[,] massP2Main = new double[3, 3] {
            {1, 0.33, 2 },
            {3, 1, 0.5 },
            {0.5, 2, 1 },
        };

        public double[,] massP2NormMain = new double[3, 3] {
            {0, 0, 0 },
            {0, 0, 0 },
            {0, 0, 0 },
        };

        public double[] massP2RowSum = new double[3] { 0, 0, 0 };
        public double[] massP2MidNormal = new double[3] { 0, 0, 0 };
        public double[] massP2Mumnoz = new double[3] { 0, 0, 0 };
        public double inputP2 = 0;
/* ************************************************************************** */
        public double[,] massP3Main = new double[3, 3] {
            {1, 5, 4 },
            {0.26, 3, 0.2 },
            {0.2, 5, 1 },
        };

        public double[,] massP3NormMain = new double[3, 3] {
            {0, 0, 0 },
            {0, 0, 0 },
            {0, 0, 0 },
        };

        public double[] massP3RowSum = new double[3] { 0, 0, 0 };
        public double[] massP3MidNormal = new double[3] { 0, 0, 0 };
        public double[] massP3Mumnoz = new double[3] { 0, 0, 0 };
        public double inputP3 = 0;
 /* ************************************************************************** */
        public double[,] massP4Main = new double[3, 3] {
            {0.5, 2, 1 },
            {2, 1, 1 },
            {1, 1, 0.5 },
        };

        public double[,] massP4NormMain = new double[3, 3] {
            {0, 0, 0 },
            {0, 0, 0 },
            {0, 0, 0 },
        };

        public double[] massP4RowSum = new double[3] { 0, 0, 0 };
        public double[] massP4MidNormal = new double[3] { 0, 0, 0 };
        public double[] massP4Mumnoz = new double[3] { 0, 0, 0 };
        public double inputP4 = 0;
/* ************************************************************************** */
        public Form1()
        {
            InitializeComponent();
            showIt();
            showP2It();
            showP3It();
            showP4It();
            showNumber();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void showNumber()
        {
            IRtextBox.AppendText("0.58");
            IRP2textBox.AppendText("0.58");
            IRP3textBox.AppendText("0.58");
            IRP4textBox.AppendText("0.58");
        }

        private double sumRow()
        {
            double output = 0;
            Control[] el;
            double summ = 0;
            for (int j = 1; j <= 3; j++)
            {
                //получаем ссылку на текст бокс, в который запишем следующий результат цикла - их всего 5
                el = this.Controls.Find("sumBox" + j.ToString(), true);
                for (int i = 1; i <= 3; i++)
                    summ += massMain[i - 1, j - 1];

                el[0].Text = summ.ToString("0.00");
                output += summ;

                massRowSum[j - 1] = summ;
                summ = 0;
            }
            return output;
        }

        private double sumP2Row() /*Page2*/
        {
            double output = 0;
            Control[] el;
            double summ = 0;
            for (int j = 1; j <= 3; j++)
            {
                //получаем ссылку на текст бокс, в который запишем следующий результат цикла - их всего 5
                el = this.Controls.Find("sumP2Box" + j.ToString(), true);
                for (int i = 1; i <= 3; i++)
                    summ += massP2Main[i - 1, j - 1];

                el[0].Text = summ.ToString("0.00");
                output += summ;

                massP2RowSum[j - 1] = summ;
                summ = 0;
            }
            return output;
        }

        private double sumP3Row() /*Page3*/
        {
            double output = 0;
            Control[] el;
            double summ = 0;
            for (int j = 1; j <= 3; j++)
            {
                //получаем ссылку на текст бокс, в который запишем следующий результат цикла - их всего 5
                el = this.Controls.Find("sumP3Box" + j.ToString(), true);
                for (int i = 1; i <= 3; i++)
                    summ += massP3Main[i - 1, j - 1];

                el[0].Text = summ.ToString("0.00");
                output += summ;

                massP3RowSum[j - 1] = summ;
                summ = 0;
            }
            return output;
        }

        private double sumP4Row() /*Page4*/
        {
            double output = 0;
            Control[] el;
            double summ = 0;
            for (int j = 1; j <= 3; j++)
            {
                //получаем ссылку на текст бокс, в который запишем следующий результат цикла - их всего 5
                el = this.Controls.Find("sumP4Box" + j.ToString(), true);
                for (int i = 1; i <= 3; i++)
                    summ += massP4Main[i - 1, j - 1];

                el[0].Text = summ.ToString("0.00");
                output += summ;

                massP4RowSum[j - 1] = summ;
                summ = 0;
            }
            return output;
        }

        private void showIt()
        {
            Control[] el;
            double buf;
            string tboxName = "";
            for (int i = 1; i < 4; i++)
                for (int j = 1; j < 4; j++)
                {
                    tboxName = "mainTextBox" + i.ToString() + j.ToString();
                    el = this.Controls.Find(tboxName, true);
                    if (el != null)
                    {
                        buf = massMain[i - 1, j - 1];
                        el[0].Text = buf.ToString();
                    }
                }
        }

        private void showP2It() /*Page2*/
        {
            Control[] el;
            double buf;
            string tboxName = "";
            for (int i = 1; i < 4; i++)
                for (int j = 1; j < 4; j++)
                {
                    tboxName = "mainP2TextBox" + i.ToString() + j.ToString();
                    el = this.Controls.Find(tboxName, true);
                    if (el != null)
                    {
                        buf = massP2Main[i - 1, j - 1];
                        el[0].Text = buf.ToString();
                    }
                }
        }

        private void showP3It() /*Page3*/
        {
            Control[] el;
            double buf;
            string tboxName = "";
            for (int i = 1; i < 4; i++)
                for (int j = 1; j < 4; j++)
                {
                    tboxName = "mainP3TextBox" + i.ToString() + j.ToString();
                    el = this.Controls.Find(tboxName, true);
                    if (el != null)
                    {
                        buf = massP3Main[i - 1, j - 1];
                        el[0].Text = buf.ToString();
                    }
                }
        }

        private void showP4It() /*Page4*/
        {
            Control[] el;
            double buf;
            string tboxName = "";
            for (int i = 1; i < 4; i++)
                for (int j = 1; j < 4; j++)
                {
                    tboxName = "mainP4TextBox" + i.ToString() + j.ToString();
                    el = this.Controls.Find(tboxName, true);
                    if (el != null)
                    {
                        buf = massP4Main[i - 1, j - 1];
                        el[0].Text = buf.ToString();
                    }
                }
        }

        private void normalize()
        {
            Control[] el;
            Control[] sum;
            string tboxName = "";
            double rez = 0;
            for(int i = 1; i <= 3; i++)
            {
                for(int j = 1; j <= 3; j++)
                {
                    tboxName = "normTextBox" + i.ToString() + j.ToString();
                    el = this.Controls.Find(tboxName, true);
                   /* sumAr = "massRowSum" + i.ToString();
                    sum = this.Controls.Find(sumAr, true);*/

                        rez = massMain[i-1, j-1]/massRowSum[j-1];
                        massNormMain[i-1, j-1] = rez;
                   /* textArea.AppendText("massMain[" + (i - 1).ToString() + (j - 1).ToString()
                        + "] / massRowSum[" + (j - 1).ToString() + "] = " +
                        massMain[i - 1, j - 1] + " / " + massRowSum[j - 1] + " = "
                        + rez.ToString() + "\n"
                        );*/
                        el[0].Text = massNormMain[i - 1, j - 1].ToString("0.00");  
                }
            }
        }

        private void normalizeP2()/*Page2*/
        {
            Control[] el;
            string tboxName = "";
            double rez = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    tboxName = "normP2TextBox" + i.ToString() + j.ToString();
                    el = this.Controls.Find(tboxName, true);

                    rez = massP2Main[i - 1, j - 1] / massP2RowSum[j - 1];
                    massP2NormMain[i - 1, j - 1] = rez;
                    el[0].Text = massP2NormMain[i - 1, j - 1].ToString("0.00");
                }
            }
        }

        private void normalizeP3()/*Page3*/
        {
            Control[] el;
            string tboxName = "";
            double rez = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    tboxName = "normP3TextBox" + i.ToString() + j.ToString();
                    el = this.Controls.Find(tboxName, true);

                    rez = massP3Main[i - 1, j - 1] / massP3RowSum[j - 1];
                    massP3NormMain[i - 1, j - 1] = rez;
                    el[0].Text = massP3NormMain[i - 1, j - 1].ToString("0.00");
                }
            }
        }

        private void normalizeP4()/*Page4*/
        {
            Control[] el;
            string tboxName = "";
            double rez = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    tboxName = "normP4TextBox" + i.ToString() + j.ToString();
                    el = this.Controls.Find(tboxName, true);

                    rez = massP4Main[i - 1, j - 1] / massP4RowSum[j - 1];
                    massP4NormMain[i - 1, j - 1] = rez;
                    el[0].Text = massP4NormMain[i - 1, j - 1].ToString("0.00");
                }
            }
        }

        private double indxConsistency()
        {
            Control[] el;
            string tboxName = "IStextBox";
            double buf = 0;
            //double rez = 0;
            el = this.Controls.Find(tboxName, true);
            for (int i = 1; i <= 3; i++)
            {
                buf = (massMumnoz[i - 1] - 3) / 2;
              //  textArea.AppendText(massMumnoz[i - 1].ToString() + "\n");
            }
            input = buf;
            el[0].Text = input.ToString("0.0000");
            return input;
        }

        private double indxConsistencyP2()
        {
            Control[] el;
            string tboxName = "ISP2textBox";
            double buf = 0;
            el = this.Controls.Find(tboxName, true);
            for (int i = 1; i <= 3; i++)
            {
                buf = (massP2Mumnoz[i - 1] - 3) / 2;
            }
            inputP2 = buf;
            el[0].Text = inputP2.ToString("0.0000");
            return inputP2;
        }/*Page2*/

        private double indxConsistencyP3()
        {
            Control[] el;
            string tboxName = "ISP3textBox";
            double buf = 0;
            el = this.Controls.Find(tboxName, true);
            for (int i = 1; i <= 3; i++)
            {
                buf = (massP3Mumnoz[i - 1] - 3) / 2;
            }
            inputP3 = buf;
            el[0].Text = inputP3.ToString("0.0000");
            return inputP3;
        }/*Page3*/

        private double indxConsistencyP4()
        {
            Control[] el;
            string tboxName = "ISP4textBox";
            double buf = 0;
            el = this.Controls.Find(tboxName, true);
            for (int i = 1; i <= 3; i++)
            {
                buf = (massP4Mumnoz[i - 1] - 3) / 2;
            }
            inputP4 = buf;
            el[0].Text = inputP4.ToString("0.0000");
            return inputP4;
        }/*Page4*/

        private void doIt()
        {
            Control[] el;
            double buf = 0;
            string tboxName = "koefTextBox";
            el = this.Controls.Find(tboxName, true);
            buf = input / 0.58;
            el[0].Text = buf.ToString("0.0000");
        }

        private void doItP2() /*Page2*/
        {
            Control[] el;
            double buf = 0;
            string tboxName = "koefP2TextBox";
            el = this.Controls.Find(tboxName, true);
            buf = inputP2 / 0.58;
            el[0].Text = buf.ToString("0.0000");
        }

        private void doItP3() /*Page3*/
        {
            Control[] el;
            double buf = 0;
            string tboxName = "koefP3TextBox";
            el = this.Controls.Find(tboxName, true);
            buf = inputP3 / 0.58;
            el[0].Text = buf.ToString("0.0000");
        }

        private void doItP4() /*Page4*/
        {
            Control[] el;
            double buf = 0;
            string tboxName = "koefP4TextBox";
            el = this.Controls.Find(tboxName, true);
            buf = inputP4 / 0.58;
            el[0].Text = buf.ToString("0.0000");
        }

        private void countMedium()
        {
            Control[] el = null;
            double sum = 0, buf = 0;
            string tboxName = "";
            
            for(int i = 1; i <= 3; i++)
            {
                tboxName = "midTextBox" + i.ToString();
                el = this.Controls.Find(tboxName, true);
                buf = 0;
                sum = 0;
                for (int j = 1; j <= 3; j++)
                {
                    sum += massNormMain[i - 1, j - 1];
                }
                buf = sum / 3;
                massMidNormal[i - 1] = buf;
               // textArea.AppendText("Среднее: " + buf);
                el[0].Text = massMidNormal[i - 1].ToString("0.00");
            }
        }

        private void countP2Medium() /*Page2*/
        {
            Control[] el = null;
            double sum = 0, buf = 0;
            string tboxName = "";

            for (int i = 1; i <= 3; i++)
            {
                tboxName = "midP2TextBox" + i.ToString();
                el = this.Controls.Find(tboxName, true);
                buf = 0;
                sum = 0;
                for (int j = 1; j <= 3; j++)
                {
                    sum += massP2NormMain[i - 1, j - 1];
                }
                buf = sum / 3;
                massP2MidNormal[i - 1] = buf;
                // textArea.AppendText("Среднее: " + buf);
                el[0].Text = massP2MidNormal[i - 1].ToString("0.00");
            }
        }

        private void countP3Medium() /*Page3*/
        {
            Control[] el = null;
            double sum = 0, buf = 0;
            string tboxName = "";

            for (int i = 1; i <= 3; i++)
            {
                tboxName = "midP3TextBox" + i.ToString();
                el = this.Controls.Find(tboxName, true);
                buf = 0;
                sum = 0;
                for (int j = 1; j <= 3; j++)
                {
                    sum += massP3NormMain[i - 1, j - 1];
                }
                buf = sum / 3;
                massP3MidNormal[i - 1] = buf;
                el[0].Text = massP3MidNormal[i - 1].ToString("0.00");
            }
        }

        private void countP4Medium() /*Page4*/
        {
            Control[] el = null;
            double sum = 0, buf = 0;
            string tboxName = "";

            for (int i = 1; i <= 3; i++)
            {
                tboxName = "midP4TextBox" + i.ToString();
                el = this.Controls.Find(tboxName, true);
                buf = 0;
                sum = 0;
                for (int j = 1; j <= 3; j++)
                {
                    sum += massP4NormMain[i - 1, j - 1];
                }
                buf = sum / 3;
                massP4MidNormal[i - 1] = buf;
                el[0].Text = massP4MidNormal[i - 1].ToString("0.00");
            }
        }

        private void mumnoz()
        {
            Control [] el;
            double buf = 0, sum = 0, tranzit = 0; ;

            string tboxName = "";

            for (int i = 1; i <= 3; i++)
            {
                tboxName = "soglTextBox" + i.ToString();
                el = this.Controls.Find(tboxName, true);
                buf = 0; sum = 0;

                for(int j = 1; j <= 3; j++)
                {
                    buf = massMain[i - 1, j - 1] * massMidNormal[j - 1];
                    sum += buf;
                }

                tranzit = sum / massMidNormal[i - 1];
                massMumnoz[i - 1] = tranzit;
                el[0].Text = massMumnoz[i - 1].ToString("0.00");
            }

        }
        private void mumnozP2()/*Page2*/
        {
            Control[] el;
            double buf = 0, sum = 0, tranzit = 0; ;

            string tboxName = "";

            for (int i = 1; i <= 3; i++)
            {
                tboxName = "soglP2TextBox" + i.ToString();
                el = this.Controls.Find(tboxName, true);
                buf = 0; sum = 0;

                for (int j = 1; j <= 3; j++)
                {
                    buf = massP2Main[i - 1, j - 1] * massP2MidNormal[j - 1];
                    sum += buf;
                }

                tranzit = sum / massP2MidNormal[i - 1];
                massP2Mumnoz[i - 1] = tranzit;
                el[0].Text = massP2Mumnoz[i - 1].ToString("0.00");
            }
        }

        private void mumnozP3()/*Page3*/
        {
            Control[] el;
            double buf = 0, sum = 0, tranzit = 0; ;

            string tboxName = "";

            for (int i = 1; i <= 3; i++)
            {
                tboxName = "soglP3TextBox" + i.ToString();
                el = this.Controls.Find(tboxName, true);
                buf = 0; sum = 0;

                for (int j = 1; j <= 3; j++)
                {
                    buf = massP3Main[i - 1, j - 1] * massP3MidNormal[j - 1];
                    sum += buf;
                }

                tranzit = sum / massP3MidNormal[i - 1];
                massP3Mumnoz[i - 1] = tranzit;
                el[0].Text = massP3Mumnoz[i - 1].ToString("0.00");
            }

        }

        private void mumnozP4()/*Page4*/
        {
            Control[] el;
            double buf = 0, sum = 0, tranzit = 0; ;

            string tboxName = "";

            for (int i = 1; i <= 3; i++)
            {
                tboxName = "soglP4TextBox" + i.ToString();
                el = this.Controls.Find(tboxName, true);
                buf = 0; sum = 0;

                for (int j = 1; j <= 3; j++)
                {
                    buf = massP4Main[i - 1, j - 1] * massP4MidNormal[j - 1];
                    sum += buf;
                }

                tranzit = sum / massP4MidNormal[i - 1];
                massP4Mumnoz[i - 1] = tranzit;
                el[0].Text = massP4Mumnoz[i - 1].ToString("0.00");
            }

        }

        private void outputRez()
        {
            Control[] el;
            double buf = 0, sum = 0;   
            string tboxName = "";
            for(int i = 1; i <= 3; i++)
            {
                    tboxName = "rezTextBox1" + i.ToString();
                    el = this.Controls.Find(tboxName, true);
                    el[0].Text = massP2MidNormal[i - 1].ToString("0.00");
            }
            for (int i = 1; i <= 3; i++)
            {
                tboxName = "rezTextBox2" + i.ToString();
                el = this.Controls.Find(tboxName, true);
                el[0].Text = massP3MidNormal[i - 1].ToString("0.00");
            }
            for (int i = 1; i <= 3; i++)
            {
                tboxName = "rezTextBox3" + i.ToString();
                el = this.Controls.Find(tboxName, true);
                el[0].Text = massP4MidNormal[i - 1].ToString("0.00");
            }
            for (int i = 1; i <= 3; i++)
            {
                tboxName = "rezTextBox4" + i.ToString();
                el = this.Controls.Find(tboxName, true);
                el[0].Text = massMidNormal[i - 1].ToString("0.00");
            }

        }

        protected void allText()
        {
            Control[] el;
            double buf = 0, sum = 0;
            string tboxName = "";
            for (int i = 1; i <= 3; i++)
            {
                tboxName = "allTextBox" + i.ToString();
                el = this.Controls.Find(tboxName, true);
                buf = massMidNormal[i - 1] * massP2MidNormal[i - 1];
                sum += buf;
                el[0].Text = sum.ToString("0.00");
            }
            for (int i = 1; i <= 3; i++)
            {
                tboxName = "allTextBox" + i.ToString();
                el = this.Controls.Find(tboxName, true);
                buf = massMidNormal[i - 1] * massP3MidNormal[i - 1];
                sum += buf;
                el[0].Text = sum.ToString("0.00");
            }
            for (int i = 1; i <= 3; i++)
            {
                tboxName = "allTextBox" + i.ToString();
                el = this.Controls.Find(tboxName, true);
                buf = massMidNormal[i - 1] * massP4MidNormal[i - 1];
                sum += buf;
                el[0].Text = sum.ToString("0.00");
            }
        }

        private void SHOW_Click(object sender, EventArgs e)
        {
            showIt();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sumButton_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void normButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void medButton_Click(object sender, EventArgs e)
        {
            
        }

        private void mumnozButton_Click(object sender, EventArgs e)
        {
            
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            sumRow();
            normalize();
            countMedium();
            mumnoz();
            indxConsistency();
            doIt();
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void medP2Button_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void calcP2Button_Click(object sender, EventArgs e)
        {
            sumP2Row();
            normalizeP2();
            countP2Medium();
            mumnozP2();
            indxConsistencyP2();
            doItP2();
        }

        private void sumP3Button_Click(object sender, EventArgs e)
        {
            
        }

        private void normP3Button_Click(object sender, EventArgs e)
        {
            
        }

        private void medP3Button_Click(object sender, EventArgs e)
        {
            
        }

        private void mumnozP3Button_Click(object sender, EventArgs e)
        {
            
        }

        private void calcP3Button_Click(object sender, EventArgs e)
        {
            sumP3Row();
            normalizeP3();
            countP3Medium();
            mumnozP3();
            indxConsistencyP3();
            doItP3();
        }

        private void sumP4Button_Click(object sender, EventArgs e)
        {
            
        }

        private void normP4Button_Click(object sender, EventArgs e)
        {
            
        }

        private void medP4Buttom_Click(object sender, EventArgs e)
        {
            
        }

        private void mumnozP4Button_Click(object sender, EventArgs e)
        {
           
        }

        private void calcP4Button_Click(object sender, EventArgs e)
        {
            sumP4Row();
            normalizeP4();
            countP4Medium();
            mumnozP4();
            indxConsistencyP4();
            doItP4();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rezButton_Click(object sender, EventArgs e)
        {
            outputRez();
            allText();
        }
    }
}
