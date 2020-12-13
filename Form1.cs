using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neurotypology
{
    public partial class Form1 : Form
    {
        String[] firstColumnArray = new string[60];
        String[] secondColumnArray = new string[60];

        public void reset()
        {
            // Вектор восприятия    -------------------------------------
            // Первый стоблец
            comboBoxVector11.Text = "0";
            comboBoxVector12.Text = "0";
            comboBoxVector13.Text = "0";
            comboBoxVector14.Text = "0";
            comboBoxVector15.Text = "0";
            comboBoxVector16.Text = "0";
            comboBoxVector17.Text = "0";
            comboBoxVector18.Text = "0";
            comboBoxVector19.Text = "0";
            comboBoxVector110.Text = "0";
            comboBoxVector111.Text = "0";
            comboBoxVector112.Text = "0";
            // Второй столбец
            comboBoxVector21.Text = "0";
            comboBoxVector22.Text = "0";
            comboBoxVector23.Text = "0";
            comboBoxVector24.Text = "0";
            comboBoxVector25.Text = "0";
            comboBoxVector26.Text = "0";
            comboBoxVector27.Text = "0";
            comboBoxVector28.Text = "0";
            comboBoxVector29.Text = "0";
            comboBoxVector210.Text = "0";
            comboBoxVector211.Text = "0";
            comboBoxVector212.Text = "0";

            // Объём воприятия      -------------------------------------
            // Первый стоблец
            comboBoxVolume11.Text = "0";
            comboBoxVolume12.Text = "0";
            comboBoxVolume13.Text = "0";
            comboBoxVolume14.Text = "0";
            comboBoxVolume15.Text = "0";
            comboBoxVolume16.Text = "0";
            comboBoxVolume17.Text = "0";
            comboBoxVolume18.Text = "0";
            comboBoxVolume19.Text = "0";
            comboBoxVolume110.Text = "0";
            comboBoxVolume111.Text = "0";
            comboBoxVolume112.Text = "0";
            comboBoxVolume113.Text = "0";
            comboBoxVolume114.Text = "0";
            comboBoxVolume115.Text = "0";
            // Второй столбец
            comboBoxVolume21.Text = "0";
            comboBoxVolume22.Text = "0";
            comboBoxVolume23.Text = "0";
            comboBoxVolume24.Text = "0";
            comboBoxVolume25.Text = "0";
            comboBoxVolume26.Text = "0";
            comboBoxVolume27.Text = "0";
            comboBoxVolume28.Text = "0";
            comboBoxVolume29.Text = "0";
            comboBoxVolume210.Text = "0";
            comboBoxVolume211.Text = "0";
            comboBoxVolume212.Text = "0";
            comboBoxVolume213.Text = "0";
            comboBoxVolume214.Text = "0";
            comboBoxVolume215.Text = "0";

            // Степень фиксации     -------------------------------------       
            // Первый стоблец
            comboBoxDegree11.Text = "0";
            comboBoxDegree12.Text = "0";
            comboBoxDegree13.Text = "0";
            comboBoxDegree14.Text = "0";
            comboBoxDegree15.Text = "0";
            comboBoxDegree16.Text = "0";
            comboBoxDegree17.Text = "0";
            comboBoxDegree18.Text = "0";
            comboBoxDegree19.Text = "0";
            comboBoxDegree110.Text = "0";
            comboBoxDegree111.Text = "0";
            comboBoxDegree112.Text = "0";
            comboBoxDegree113.Text = "0";
            comboBoxDegree114.Text = "0";
            comboBoxDegree115.Text = "0";
            comboBoxDegree116.Text = "0";
            comboBoxDegree117.Text = "0";
            comboBoxDegree118.Text = "0";
            comboBoxDegree119.Text = "0";
            // Второй столбец
            comboBoxDegree21.Text = "0";
            comboBoxDegree22.Text = "0";
            comboBoxDegree23.Text = "0";
            comboBoxDegree24.Text = "0";
            comboBoxDegree25.Text = "0";
            comboBoxDegree26.Text = "0";
            comboBoxDegree27.Text = "0";
            comboBoxDegree28.Text = "0";
            comboBoxDegree29.Text = "0";
            comboBoxDegree210.Text = "0";
            comboBoxDegree211.Text = "0";
            comboBoxDegree212.Text = "0";
            comboBoxDegree213.Text = "0";
            comboBoxDegree214.Text = "0";
            comboBoxDegree215.Text = "0";
            comboBoxDegree216.Text = "0";
            comboBoxDegree217.Text = "0";
            comboBoxDegree218.Text = "0";
            comboBoxDegree219.Text = "0";

            // Качество обработки   -------------------------------------
            // Первый стоблец
            comboBoxQuality11.Text = "0";
            comboBoxQuality12.Text = "0";
            comboBoxQuality13.Text = "0";
            comboBoxQuality14.Text = "0";
            comboBoxQuality15.Text = "0";
            comboBoxQuality16.Text = "0";
            comboBoxQuality17.Text = "0";
            comboBoxQuality18.Text = "0";
            comboBoxQuality19.Text = "0";
            comboBoxQuality110.Text = "0";
            comboBoxQuality111.Text = "0";
            comboBoxQuality112.Text = "0";
            comboBoxQuality113.Text = "0";
            comboBoxQuality114.Text = "0";
            // Второй столбец
            comboBoxQuality21.Text = "0";
            comboBoxQuality22.Text = "0";
            comboBoxQuality23.Text = "0";
            comboBoxQuality24.Text = "0";
            comboBoxQuality25.Text = "0";
            comboBoxQuality26.Text = "0";
            comboBoxQuality27.Text = "0";
            comboBoxQuality28.Text = "0";
            comboBoxQuality29.Text = "0";
            comboBoxQuality210.Text = "0";
            comboBoxQuality211.Text = "0";
            comboBoxQuality212.Text = "0";
            comboBoxQuality213.Text = "0";
            comboBoxQuality214.Text = "0";
        }

        public void updateArrays()
        {
            // Первый стоблец
            firstColumnArray[0] = comboBoxVector11.Text;
            firstColumnArray[1] = comboBoxVector12.Text;
            firstColumnArray[2] = comboBoxVector13.Text;
            firstColumnArray[3] = comboBoxVector14.Text;
            firstColumnArray[4] = comboBoxVector15.Text;
            firstColumnArray[5] = comboBoxVector16.Text;
            firstColumnArray[6] = comboBoxVector17.Text;
            firstColumnArray[7] = comboBoxVector18.Text;
            firstColumnArray[8] = comboBoxVector19.Text;
            firstColumnArray[9] = comboBoxVector110.Text;
            firstColumnArray[10] = comboBoxVector111.Text;
            firstColumnArray[11] = comboBoxVector112.Text;

            firstColumnArray[12] = comboBoxVolume11.Text;
            firstColumnArray[13] = comboBoxVolume12.Text;
            firstColumnArray[14] = comboBoxVolume13.Text;
            firstColumnArray[15] = comboBoxVolume14.Text;
            firstColumnArray[16] = comboBoxVolume15.Text;
            firstColumnArray[17] = comboBoxVolume16.Text;
            firstColumnArray[18] = comboBoxVolume17.Text;
            firstColumnArray[19] = comboBoxVolume18.Text;
            firstColumnArray[20] = comboBoxVolume19.Text;
            firstColumnArray[21] = comboBoxVolume110.Text;
            firstColumnArray[22] = comboBoxVolume111.Text;
            firstColumnArray[23] = comboBoxVolume112.Text;
            firstColumnArray[24] = comboBoxVolume113.Text;
            firstColumnArray[25] = comboBoxVolume114.Text;
            firstColumnArray[26] = comboBoxVolume115.Text;

            firstColumnArray[27] = comboBoxDegree11.Text;
            firstColumnArray[28] = comboBoxDegree12.Text;
            firstColumnArray[29] = comboBoxDegree13.Text;
            firstColumnArray[30] = comboBoxDegree14.Text;
            firstColumnArray[31] = comboBoxDegree15.Text;
            firstColumnArray[32] = comboBoxDegree16.Text;
            firstColumnArray[33] = comboBoxDegree17.Text;
            firstColumnArray[34] = comboBoxDegree18.Text;
            firstColumnArray[35] = comboBoxDegree19.Text;
            firstColumnArray[36] = comboBoxDegree110.Text;
            firstColumnArray[37] = comboBoxDegree111.Text;
            firstColumnArray[38] = comboBoxDegree112.Text;
            firstColumnArray[39] = comboBoxDegree113.Text;
            firstColumnArray[40] = comboBoxDegree114.Text;
            firstColumnArray[41] = comboBoxDegree115.Text;
            firstColumnArray[42] = comboBoxDegree116.Text;
            firstColumnArray[43] = comboBoxDegree117.Text;
            firstColumnArray[44] = comboBoxDegree118.Text;
            firstColumnArray[45] = comboBoxDegree119.Text;

            firstColumnArray[46] = comboBoxQuality11.Text;
            firstColumnArray[47] = comboBoxQuality12.Text;
            firstColumnArray[48] = comboBoxQuality13.Text;
            firstColumnArray[49] = comboBoxQuality14.Text;
            firstColumnArray[50] = comboBoxQuality15.Text;
            firstColumnArray[51] = comboBoxQuality16.Text;
            firstColumnArray[52] = comboBoxQuality17.Text;
            firstColumnArray[53] = comboBoxQuality18.Text;
            firstColumnArray[54] = comboBoxQuality19.Text;
            firstColumnArray[55] = comboBoxQuality110.Text;
            firstColumnArray[56] = comboBoxQuality111.Text;
            firstColumnArray[57] = comboBoxQuality112.Text;
            firstColumnArray[58] = comboBoxQuality113.Text;
            firstColumnArray[59] = comboBoxQuality114.Text;


            // Второй столбец
            secondColumnArray[0] = comboBoxVector21.Text;
            secondColumnArray[1] = comboBoxVector22.Text;
            secondColumnArray[2] = comboBoxVector23.Text;
            secondColumnArray[3] = comboBoxVector24.Text;
            secondColumnArray[4] = comboBoxVector25.Text;
            secondColumnArray[5] = comboBoxVector26.Text;
            secondColumnArray[6] = comboBoxVector27.Text;
            secondColumnArray[7] = comboBoxVector28.Text;
            secondColumnArray[8] = comboBoxVector29.Text;
            secondColumnArray[9] = comboBoxVector210.Text;
            secondColumnArray[10] = comboBoxVector211.Text;
            secondColumnArray[11] = comboBoxVector212.Text;

            secondColumnArray[12] = comboBoxVolume21.Text;
            secondColumnArray[13] = comboBoxVolume22.Text;
            secondColumnArray[14] = comboBoxVolume23.Text;
            secondColumnArray[15] = comboBoxVolume24.Text;
            secondColumnArray[16] = comboBoxVolume25.Text;
            secondColumnArray[17] = comboBoxVolume26.Text;
            secondColumnArray[18] = comboBoxVolume27.Text;
            secondColumnArray[19] = comboBoxVolume28.Text;
            secondColumnArray[20] = comboBoxVolume29.Text;
            secondColumnArray[21] = comboBoxVolume210.Text;
            secondColumnArray[22] = comboBoxVolume211.Text;
            secondColumnArray[23] = comboBoxVolume212.Text;
            secondColumnArray[24] = comboBoxVolume213.Text;
            secondColumnArray[25] = comboBoxVolume214.Text;
            secondColumnArray[26] = comboBoxVolume215.Text;

            secondColumnArray[27] = comboBoxDegree21.Text;
            secondColumnArray[28] = comboBoxDegree22.Text;
            secondColumnArray[29] = comboBoxDegree23.Text;
            secondColumnArray[30] = comboBoxDegree24.Text;
            secondColumnArray[31] = comboBoxDegree25.Text;
            secondColumnArray[32] = comboBoxDegree26.Text;
            secondColumnArray[33] = comboBoxDegree27.Text;
            secondColumnArray[34] = comboBoxDegree28.Text;
            secondColumnArray[35] = comboBoxDegree29.Text;
            secondColumnArray[36] = comboBoxDegree210.Text;
            secondColumnArray[37] = comboBoxDegree211.Text;
            secondColumnArray[38] = comboBoxDegree212.Text;
            secondColumnArray[39] = comboBoxDegree213.Text;
            secondColumnArray[40] = comboBoxDegree214.Text;
            secondColumnArray[41] = comboBoxDegree215.Text;
            secondColumnArray[42] = comboBoxDegree216.Text;
            secondColumnArray[43] = comboBoxDegree217.Text;
            secondColumnArray[44] = comboBoxDegree218.Text;
            secondColumnArray[45] = comboBoxDegree219.Text;

            secondColumnArray[46] = comboBoxQuality21.Text;
            secondColumnArray[47] = comboBoxQuality22.Text;
            secondColumnArray[48] = comboBoxQuality23.Text;
            secondColumnArray[49] = comboBoxQuality24.Text;
            secondColumnArray[50] = comboBoxQuality25.Text;
            secondColumnArray[51] = comboBoxQuality26.Text;
            secondColumnArray[52] = comboBoxQuality27.Text;
            secondColumnArray[53] = comboBoxQuality28.Text;
            secondColumnArray[54] = comboBoxQuality29.Text;
            secondColumnArray[55] = comboBoxQuality210.Text;
            secondColumnArray[56] = comboBoxQuality211.Text;
            secondColumnArray[57] = comboBoxQuality212.Text;
            secondColumnArray[58] = comboBoxQuality213.Text;
            secondColumnArray[59] = comboBoxQuality214.Text;
        }

        public Boolean compareComboBoxValues(String text1, String text2)
        {
            if((text1 == text2) || ((text1 != "0") && (text2 != "0")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Form1()
        {
            InitializeComponent();
            reset();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            updateArrays();

            for(int i = 0; i < 60; i += 1)
            {
                if(compareComboBoxValues(firstColumnArray[i], secondColumnArray[i]))
                {
                    MessageBox.Show(
                    "В одной строке не может быть два значения больше нуля и два нуля.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

                    break;
                }
            }

            int sumFirstColumnVector =
                3 * (Int32.Parse(firstColumnArray[0]) + Int32.Parse(firstColumnArray[1])) +
                2 * (Int32.Parse(firstColumnArray[2]) + Int32.Parse(firstColumnArray[3]) + Int32.Parse(firstColumnArray[4]) + Int32.Parse(firstColumnArray[5]) + Int32.Parse(firstColumnArray[6])) +
                1 * (Int32.Parse(firstColumnArray[7]) + Int32.Parse(firstColumnArray[8]) + Int32.Parse(firstColumnArray[9]) + Int32.Parse(firstColumnArray[10]) + Int32.Parse(firstColumnArray[11]));
            int sumSecondColumnVector =
                3 * (Int32.Parse(secondColumnArray[0]) + Int32.Parse(secondColumnArray[1])) +
                2 * (Int32.Parse(secondColumnArray[2]) + Int32.Parse(secondColumnArray[3]) + Int32.Parse(secondColumnArray[4]) + Int32.Parse(secondColumnArray[5]) + Int32.Parse(secondColumnArray[6])) +
                1 * (Int32.Parse(secondColumnArray[7]) + Int32.Parse(secondColumnArray[8]) + Int32.Parse(secondColumnArray[9]) + Int32.Parse(secondColumnArray[10]) + Int32.Parse(secondColumnArray[11]));

            int sumFirstColumnVolume =
                4 * (Int32.Parse(firstColumnArray[12]) + Int32.Parse(firstColumnArray[13])) +
                3 * (Int32.Parse(firstColumnArray[14]) + Int32.Parse(firstColumnArray[15]) + Int32.Parse(firstColumnArray[16])) +
                2 * (Int32.Parse(firstColumnArray[17]) + Int32.Parse(firstColumnArray[18]) + Int32.Parse(firstColumnArray[19]) +
                Int32.Parse(firstColumnArray[20]) + Int32.Parse(firstColumnArray[21]) + Int32.Parse(firstColumnArray[22]) + Int32.Parse(firstColumnArray[23])) +
                1 * (Int32.Parse(firstColumnArray[24]) + Int32.Parse(firstColumnArray[25]) + Int32.Parse(firstColumnArray[26]));               
            int sumSecondColumnVolume =
                4 * (Int32.Parse(secondColumnArray[12]) + Int32.Parse(secondColumnArray[13])) +
                3 * (Int32.Parse(secondColumnArray[14]) + Int32.Parse(secondColumnArray[15]) + Int32.Parse(secondColumnArray[16])) +
                2 * (Int32.Parse(secondColumnArray[17]) + Int32.Parse(secondColumnArray[18]) + Int32.Parse(secondColumnArray[19]) +
                Int32.Parse(secondColumnArray[20]) + Int32.Parse(secondColumnArray[21]) + Int32.Parse(secondColumnArray[22]) + Int32.Parse(secondColumnArray[23])) +
                1 * (Int32.Parse(secondColumnArray[24]) + Int32.Parse(secondColumnArray[25]) + Int32.Parse(secondColumnArray[26]));
                       
            int sumFirstColumnDegree =
                4 * (Int32.Parse(firstColumnArray[27])) +
                3 * (Int32.Parse(firstColumnArray[28]) + Int32.Parse(firstColumnArray[29])) +
                2 * (Int32.Parse(firstColumnArray[30]) + Int32.Parse(firstColumnArray[31]) + Int32.Parse(firstColumnArray[32]) +
                Int32.Parse(firstColumnArray[33]) + Int32.Parse(firstColumnArray[34])) +
                1 * (Int32.Parse(firstColumnArray[35]) + Int32.Parse(firstColumnArray[36]) + Int32.Parse(firstColumnArray[37]) +
                Int32.Parse(firstColumnArray[38]) + Int32.Parse(firstColumnArray[39]) +
                Int32.Parse(firstColumnArray[40]) + Int32.Parse(firstColumnArray[41]) + Int32.Parse(firstColumnArray[42]) +
                Int32.Parse(firstColumnArray[43]) + Int32.Parse(firstColumnArray[44]) + Int32.Parse(firstColumnArray[45]));
            int sumSecondColumnDegree =
                4 * (Int32.Parse(secondColumnArray[27])) +
                3 * (Int32.Parse(secondColumnArray[28]) + Int32.Parse(secondColumnArray[29])) +
                2 * (Int32.Parse(secondColumnArray[30]) + Int32.Parse(secondColumnArray[31]) + Int32.Parse(secondColumnArray[32]) +
                Int32.Parse(secondColumnArray[33]) + Int32.Parse(secondColumnArray[34])) +
                1 * (Int32.Parse(secondColumnArray[35]) + Int32.Parse(secondColumnArray[36]) + Int32.Parse(secondColumnArray[37]) +
                Int32.Parse(secondColumnArray[38]) + Int32.Parse(secondColumnArray[39]) +
                Int32.Parse(secondColumnArray[40]) + Int32.Parse(secondColumnArray[41]) + Int32.Parse(secondColumnArray[42]) +
                Int32.Parse(secondColumnArray[43]) + Int32.Parse(secondColumnArray[44]) + Int32.Parse(secondColumnArray[45]));

            int sumFirstColumnQuality =
                4 * (Int32.Parse(firstColumnArray[46])) +
                3 * (Int32.Parse(firstColumnArray[47]) + Int32.Parse(firstColumnArray[48]) 
                + Int32.Parse(firstColumnArray[49]) + Int32.Parse(firstColumnArray[50])) +
                2 * (Int32.Parse(firstColumnArray[51]) + Int32.Parse(firstColumnArray[52])) +
                1 * (Int32.Parse(firstColumnArray[53]) + Int32.Parse(firstColumnArray[54]) + Int32.Parse(firstColumnArray[55]) +
                Int32.Parse(firstColumnArray[56]) + Int32.Parse(firstColumnArray[57]) +
                Int32.Parse(firstColumnArray[58]) + Int32.Parse(firstColumnArray[59]));
            int sumSecondColumnQuality =
                4 * (Int32.Parse(secondColumnArray[46])) +
                3 * (Int32.Parse(secondColumnArray[47]) + Int32.Parse(secondColumnArray[48])
                + Int32.Parse(secondColumnArray[49]) + Int32.Parse(secondColumnArray[50])) +
                2 * (Int32.Parse(secondColumnArray[51]) + Int32.Parse(secondColumnArray[52])) +
                1 * (Int32.Parse(secondColumnArray[53]) + Int32.Parse(secondColumnArray[54]) + Int32.Parse(secondColumnArray[55]) +
                Int32.Parse(secondColumnArray[56]) + Int32.Parse(secondColumnArray[57]) +
                Int32.Parse(secondColumnArray[58]) + Int32.Parse(secondColumnArray[59]));

            //labelResultValue.Text = sumFirstColumnVector.ToString();

            int markFirstColumnVector = sumFirstColumnVector / (sumFirstColumnVector + sumSecondColumnVector) * 100;
            int markSecondColumnVector = sumSecondColumnVector / (sumFirstColumnVector + sumSecondColumnVector) * 100;

            int markFirstColumnVolume = sumFirstColumnVolume / (sumFirstColumnVolume + sumSecondColumnVolume) * 100;
            int markSecondColumnVolume = sumSecondColumnVolume / (sumFirstColumnVolume + sumSecondColumnVolume) * 100;

            int markFirstColumnDegree = sumFirstColumnDegree / (sumFirstColumnDegree + sumSecondColumnDegree) * 100;
            int markSecondColumnDegree = sumSecondColumnDegree / (sumFirstColumnDegree + sumSecondColumnDegree) * 100;

            int markFirstColumnQuality = sumFirstColumnQuality / (sumFirstColumnQuality + sumSecondColumnQuality) * 100;
            int markSecondColumnQuality = sumSecondColumnQuality / (sumFirstColumnQuality + sumSecondColumnQuality) * 100;
        }
    }
}
