using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalConverter
{
    static class HexadecimalConvert
    {

        public static long ConvertHexToDecimal(string hexValue)
        {
            var valArray = hexValue.ToCharArray();
            var workingList = new List<long>();

            foreach(char c in valArray)
            {
                if((int)c >= 48 && (int)c <= 57)
                {
                    //its a number
                    workingList.Add(int.Parse(c.ToString()));
                }
                else
                {
                    //its a letter A through F
                    switch (c)
                    {
                        case 'A':
                            {
                                workingList.Add(10);
                                break;
                            }
                        case 'B':
                            {
                                workingList.Add(11);
                                break;
                            }
                        case 'C':
                            {
                                workingList.Add(12);
                                break;
                            }
                        case 'D':
                            {
                                workingList.Add(13);
                                break;
                            }
                        case 'E':
                            {
                                workingList.Add(14);
                                break;
                            }
                        case 'F':
                            {
                                workingList.Add(15);
                                break;
                            }                

                    }                                            
                }
            }

            var decimalVal = workingList[0];     
                for(int i = 1; i < workingList.Count; i++)
                {
                    decimalVal = (decimalVal * 16) + workingList[i];
                }
      
            return decimalVal;
        }


        //this is broken. Does not work in all cases
        public static string ConvertDecimalToHex(long number)
        {           
            double intermediate = number;
            var workingList = new List<string>();

            if(number == 0)
            {
                return "0";
            }

            while (true)
            {
                intermediate = intermediate / 16; 
                var tempSplit = intermediate.ToString().Split('.');

                if (tempSplit.Length > 1 && int.Parse(tempSplit[0]) < 16)
                {       
                    var fractionValue = double.Parse("." + tempSplit[1]) * 16;
                    workingList.Add(GetHexLetter(fractionValue));
                    workingList.Add(GetHexLetter(int.Parse(tempSplit[0])));
                    workingList.Reverse();
                    break; //exit loop
                }
                else if (tempSplit.Length > 1 && int.Parse(tempSplit[0]) > 16)
                {
                    intermediate = int.Parse(tempSplit[0]);
                    var fractionValue = double.Parse("." + tempSplit[1]) * 16;
                    workingList.Add(GetHexLetter(fractionValue));
                    
                }
            }

            string hexString = "";

            foreach(string item in workingList)
            {
                hexString = hexString + item;
            }

            return hexString;
        }


        private static string GetHexLetter(double number)
        {
            if (number == 15)
            {
                return ("F");
            }
            else if (number == 14)
            {
                return ("E");
            }
            else if (number == 13)
            {
                return ("D");
            }
            else if (number == 12)
            {
                return ("C");
            }
            else if (number == 11)
            {
                return ("B");
            }
            else if (number == 10)
            {
                return ("A");
            }
            else if (number == 0)
            {
                return ("");
            }
            else
            {
                return number.ToString();
            }
        }

    }
}
