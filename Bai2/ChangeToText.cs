using System;

namespace Bai2
{

    internal class ChangeToText
    {
        public string Change(double num)
        {
            string[] unitNum = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín", "mười" };
            string[] placeValue = new string[] { "", "nghìn", "triệu", "tỷ" };
            bool isNegative = false;

            string sNum = num.ToString("#");
            double number = Convert.ToDouble(sNum);
            if (number < 0)
            {
                number = -number;
                sNum = number.ToString();
                isNegative = true;
            }

            int ones, tens, hundreds;
            int positionDigit = sNum.Length;
            string result = " ";

            if (positionDigit == 0)
            {
                result = unitNum[0] + result;
            }
            else
            {
                int placeValues = 0;
                while (positionDigit > 0)
                {
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNum.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNum.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(sNum.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }
                    if (ones > 0 || tens > 0 || hundreds > 0 || placeValues == 3)
                    {
                        result = placeValue[placeValues] + result;

                    }
                    placeValues++;
                    if (placeValues > 3)
                        placeValues = 1;
                    if (ones == 1 & tens > 1)
                    {
                        result = "một" + result;
                    }
                    else
                    {
                        if (ones == 5 && tens > 0)
                            result = "lăm" + result;
                        else if (ones > 0)
                            result = unitNum[ones] + " " + result;
                    }
                    if (tens < 0)
                        break;
                    else
                    {
                        if (tens == 0 && ones > 0)
                            result = "lẻ" + result;
                        if (tens == 1)
                            result = "mười" + result;
                        if (tens > 1)
                            result = unitNum[tens] + "mươi" + result;
                    }
                    if (hundreds < 0) break;
                    else
                    {
                        if (hundreds > 0 || tens > 0 || ones > 0)
                            result = unitNum[hundreds] + "trăm" + result;
                    }
                    result = " " + result;
                }

            }
            result = result.Trim();
            if (isNegative)
                result = "Âm" + result;
            return result;
        }
    }
}
