using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacheCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private long tagSize = 0;
        private long setIndexSize = 0;
        private long offsetSize = 0;

        //event handler for all size calculators
        private void comboBox_associativity_TextChanged(object sender, EventArgs e)
        {
            calcCache();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updateAddrOutputs();
        }

        public void calcCache()
        {
            try
            {
                long setDivisor = long.Parse(textBox_setAssociativity.Text);

                long memoryCapacity = 0;
                string memString = textBox_memoryCapacity.Text;
                if (memString.EndsWith("K") || memString.EndsWith("k"))
                    memoryCapacity = long.Parse(memString.Substring(0, memString.Length - 1)) * 1024;
                else if (memString.EndsWith("M") || memString.EndsWith("m"))
                    memoryCapacity = long.Parse(memString.Substring(0, memString.Length - 1)) * 1024 * 1024;
                else memoryCapacity = long.Parse(memString);


                long numBlocks = 0;
                if (textBox_numBlocks.Text.Length > 0)
                    numBlocks = long.Parse(textBox_numBlocks.Text);
                long blockSize = 0;
                if (textBox_blockSize.Text.Length > 0)
                    blockSize = long.Parse(textBox_blockSize.Text);
                long cacheSize = 0;
                if (textBox_cacheSize.Text.Length > 0)
                    cacheSize = long.Parse(textBox_cacheSize.Text);

                if (textBox_numBlocks.Text == "")
                    numBlocks = cacheSize / blockSize;
                if (textBox_blockSize.Text == "")
                    blockSize = cacheSize / numBlocks;
                if (textBox_cacheSize.Text == "")
                    cacheSize = blockSize * numBlocks;
                if ((textBox_numBlocks.Text == "" && textBox_blockSize.Text == "") ||
                    (textBox_numBlocks.Text == "" && textBox_cacheSize.Text == "") ||
                    (textBox_blockSize.Text == "" && textBox_cacheSize
                        .Text == ""))
                    return;

                textBox_resultNumBlocks.Text = numBlocks.ToString();
                textBox_resultBlockSize.Text = blockSize.ToString();
                textBox_resultCacheCapacity.Text = cacheSize.ToString();


                offsetSize = (int) Math.Round(Math.Log(blockSize, 2));
                setIndexSize = 0;
                if (setDivisor > 0)
                    setIndexSize = (int) Math.Round(Math.Log(numBlocks / setDivisor, 2));
                tagSize = ((int) Math.Round(Math.Log(memoryCapacity, 2))) - setIndexSize - offsetSize;

                textBox_tagSize.Text = tagSize.ToString();
                textBox_lineSize.Text = setIndexSize.ToString();
                textBox_offsetSize.Text = offsetSize.ToString();
            }
            catch
            {
                textBox_tagSize.Text = "";
                textBox_lineSize.Text = "";
                textBox_offsetSize.Text = "";
            }

            updateAddrOutputs();
        }

        public void updateAddrOutputs()
        {
            try
            {
                int address = int.Parse(textBox_addressToCalc.Text, System.Globalization.NumberStyles.HexNumber);

                int tagMask = 0;
                int setIndexMask = 0;
                int offsetMask = 0;
                for (int i = 0; i < tagSize; i++)
                {
                    tagMask <<= 1;
                    tagMask += 1;
                }

                for (int i = 0; i < setIndexSize; i++)
                {
                    tagMask <<= 1;
                    setIndexMask <<= 1;
                    setIndexMask += 1;
                }

                for (int i = 0; i < offsetSize; i++)
                {
                    tagMask <<= 1;
                    setIndexMask <<= 1;
                    offsetMask <<= 1;
                    offsetMask += 1;
                }

                int tag = address & tagMask;
                int index = address & setIndexMask;
                int offset = address & offsetMask;

                textBox_addrTag.Text = tagSize > 0 ? (tag >> (int) (setIndexSize + offsetSize)).ToString("X") : "";
                textBox_addrLine.Text = setIndexSize > 0 ? (index >> (int) offsetSize).ToString("X") : "";
                textBox_addrOffset.Text = offsetSize > 0 ? offset.ToString("X") : "";
            }
            catch
            {
            }
        }

        public static string ToHex(int value)
        {
            return $"0x{value:X}";
        }

        private void textBox_eet_clockMhz_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double missTime = int.Parse(textBox_eet_initialBurstTime.Text);

                int singleTransferTime = int.Parse(textBox_eet_subsequentBurstTime.Text);

                //this is about how much memory we can transfer at once. for example: we have a 32 bit bus and need to fill 32 BYTES. so that would be 8 transfers.
                int amountOfTransfersPerMiss =
                    int.Parse(textBox_eet_refillLine.Text) / (int.Parse(textBox_eet_busWidth.Text) / 8);

                missTime += singleTransferTime * amountOfTransfersPerMiss;


                int hitTime = int.Parse(textBox_eet_inCacheInstructionExecutionTime.Text);
                double hitRatio = double.Parse(textBox_eet_hitRatioPercentage.Text);
                double eetInClockCycles = hitTime * hitRatio + missTime * (1 - hitRatio);

                double eetInNanoseconds =
                    ((1 / (int.Parse(textBox_eet_clockMhz.Text) * Math.Pow(10, 6))) * Math.Pow(10, 9)) *
                    eetInClockCycles;

                textBox_eet_resultCycles.Text = eetInClockCycles.ToString();
                textBox_eet_resultNanoseconds.Text = eetInNanoseconds.ToString() + "ns";
            }
            catch
            {
                textBox_eet_resultCycles.Text = "";
                textBox_eet_resultNanoseconds.Text = "";
            }
        }

        private void textBox_eeteasy_hitratio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double hitratio = double.Parse(textBox_eeteasy_hitratio.Text);
                int hitTime = int.Parse(textBox_eeteasy_hittime.Text);
                int missTime = int.Parse(textBox_eeteasy_misstime.Text);
                double clockfreq = (1 / (int.Parse(textBox_eeteasy_clockfreq.Text) * Math.Pow(10, 6))) *
                                   Math.Pow(10, 9);
                double eetClockCycles = (hitratio * hitTime) + ((1 - hitratio) * missTime);
                textBox_eeteasy_resultClockCycles.Text = eetClockCycles.ToString();
                textBox_eeteasy_resultNanoseconds.Text = (eetClockCycles * clockfreq).ToString() + "ns";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                textBox_eeteasy_resultClockCycles.Text = "";
                textBox_eeteasy_resultNanoseconds.Text = "";
            }
        }

        private void button_calcCache_Click(object sender, EventArgs e)
        {
            calcCache();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox_sizeInBytes_TextChanged(object sender, EventArgs e)
        {
            if (!textBox_sizeInBytes.Focused)
                return;
            try
            {
                ulong byteSize = 0;
                string byteString = textBox_sizeInBytes.Text;
                if (byteString.EndsWith("K") || byteString.EndsWith("k"))
                    byteSize = ulong.Parse(byteString.Substring(0, byteString.Length - 1)) * 1024;
                else if (byteString.EndsWith("M") || byteString.EndsWith("m"))
                    byteSize = ulong.Parse(byteString.Substring(0, byteString.Length - 1)) * 1024 * 1024;
                else byteSize = ulong.Parse(byteString);
                textBox_sizeInBits.Text = ((ulong) Math.Round(Math.Log(byteSize, 2))).ToString();
            }
            catch
            {
            }
        }

        private void textBox_sizeInBits_TextChanged(object sender, EventArgs e)
        {
            if (!textBox_sizeInBits.Focused)
                return;
            try
            {
                ulong sizeInBytes = (ulong) Math.Pow(2, ulong.Parse(textBox_sizeInBits.Text));
                if (sizeInBytes % 1048576 == 0)
                {
                    sizeInBytes /= 1048576;
                    textBox_sizeInBytes.Text = sizeInBytes + "M";
                }
                else if (sizeInBytes % 1024 == 0)
                {
                    sizeInBytes /= 1024;
                    textBox_sizeInBytes.Text = sizeInBytes + "K";
                }
                else
                {
                    textBox_sizeInBytes.Text = sizeInBytes.ToString();
                }
            }
            catch
            {
            }
        }
    }
}