using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }


        int arrayIndex = 0;
        string[] arrayID = new string[1000];
        string[] arrayName = new string[1000];
        int[] arrayScore = new int[1000];
        string IDstd ;
        string nameStd ;
        int scoreStd;
        int[] countGrade = new int[8];


       

        public void Save_button_Click(object sender, EventArgs e)
        {

            IDstd = text_IDstd.Text;
            nameStd = text_Name.Text;
            scoreStd = int.Parse(text_Score.Text);
            arrayID[arrayIndex] = IDstd;
            arrayName[arrayIndex] = nameStd;
            arrayScore[arrayIndex] = scoreStd;
            arrayIndex++;
            text_Name.Text = string.Empty;
            text_IDstd.Text = string.Empty;
            text_Score.Text = string.Empty;

            int max_score = 0;
            for (int i = 0; i < arrayIndex; i++)
            {
                if (arrayScore[i] > max_score)
                {
                    max_score = arrayScore[i];
                    IDstd_max.Text = arrayID[i].ToString();
                    nameStd_max.Text = arrayName[i].ToString();
                    scoreStd_max.Text = arrayScore[i].ToString();
                }
            }

            int min_score = max_score;
            for (int i = 0; i < arrayIndex; i++)
            {
                if (arrayScore[i] < min_score)
                {
                    min_score = arrayScore[i];
                    IDstd_min.Text = arrayID[i].ToString();
                    nameStd_min.Text = arrayName[i].ToString();
                    scoreStd_min.Text = arrayScore[i].ToString();
                }
            }

            double Sum_score = 0;
            for (int i = 0; i < arrayIndex; i++)
            {
                Sum_score += arrayScore[i];
            }
            AVG_score.Text = (Sum_score / arrayIndex).ToString("0.00");

            if (arrayScore[arrayIndex - 1] >= 80 && arrayScore[arrayIndex - 1] <= 100)
            {
                countGrade[0]++;
                A_box.Text = countGrade[0].ToString();
            }
            else if (arrayScore[arrayIndex - 1] >= 75 && arrayScore[arrayIndex - 1] <= 79)
            {
                countGrade[1]++;
                BB_box.Text = countGrade[1].ToString();
            }
            else if (arrayScore[arrayIndex - 1] >= 70 && arrayScore[arrayIndex - 1] <= 74)
            {
                countGrade[2]++;
                B_box.Text = countGrade[2].ToString();
            }
            else if (arrayScore[arrayIndex - 1]  >= 65 && arrayScore[arrayIndex - 1] <= 69)
            {
                countGrade[3]++;
                CC_box.Text = countGrade[3].ToString();
            }
            else if (arrayScore[arrayIndex - 1] >= 60 && arrayScore[arrayIndex - 1] <= 64)
            {
                countGrade[4] += 1;
                C_box.Text = countGrade[4].ToString();
            }
            else if (arrayScore[arrayIndex - 1] >= 55 && arrayScore[arrayIndex - 1] <= 59)
            {
                countGrade[5] += 1;
                DD_box.Text = countGrade[5].ToString();
            }
            else if (arrayScore[arrayIndex - 1] >= 50 && arrayScore[arrayIndex - 1] <= 54)
            {
                countGrade[6] += 1;
                D_box.Text = countGrade[6].ToString();
            }
            else
            {
                countGrade[7] += 1;
                F_box.Text = countGrade[7].ToString();
            }

            double[] weight_grade = { 4.0, 3.5, 3.0 , 2.5 , 2.0 , 1.5 , 1.0 };
            double sum_weight = 0;
            for (int i = 0; i < weight_grade.Length; i++)
            {
                sum_weight += weight_grade[i] * countGrade[i];
            }

            GPA_box.Text = (sum_weight / arrayIndex).ToString("0.00");
        }

    }
}
