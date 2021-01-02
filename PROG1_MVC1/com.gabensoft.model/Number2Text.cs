using System;
using System.Collections.Generic;
using System.Text;

namespace PROG1_MVC1.com.gabensoft.model
{
    class Number2Text
    {
        public string num2text(int num)
        {
            string ans = null;
            char[] nums = num.ToString().ToCharArray();
            if(nums.Length == 1)
            {
                ans = units(int.Parse(nums[0].ToString()));
                if (ans == null)
                {
                    ans = specificCases(int.Parse(nums[0].ToString()));
                }
            }
            else if(nums.Length == 2)
            {
                ans = decimals(int.Parse(nums[0].ToString()));
                if (ans == null)
                {
                    var translatedNum = nums[0].ToString() + nums[1].ToString();
                    ans = specificCases(int.Parse(translatedNum));
                }
                else if (ans.Equals("veinti"))
                {
                    if (nums[1] == '0')
                    {
                        var translatedNum = nums[0].ToString() + nums[1].ToString();
                        ans = specificCases(int.Parse(translatedNum));
                    }
                    else
                    {
                        ans += units(int.Parse(nums[1].ToString()));
                    }
                }
                else
                {
                    ans += " y " + units(int.Parse(nums[1].ToString()));
                }
            }
            else if(nums.Length == 3)
            {
                ans = cents(int.Parse(nums[0].ToString()));
                if(ans.Equals("cien"))
                {
                    if(nums[1] != '0' && nums[2] != '0')
                    {
                        ans += "to ";
                        string mydecimals = null;
                        string myunits = null;
                        mydecimals = decimals(int.Parse(nums[1].ToString()));
                        if(mydecimals == null)
                        {
                            var translatedNum = nums[1].ToString() + nums[2].ToString();
                            mydecimals += specificCases(int.Parse(translatedNum));
                            ans += mydecimals;
                        }
                        else if(mydecimals.Equals("veinti"))
                        {
                            if (nums[2] == '0')
                            {
                                var translatedNum = nums[1].ToString() + nums[2].ToString();
                                mydecimals = specificCases(int.Parse(translatedNum));
                                ans += mydecimals;
                            }
                            else
                            {
                                ans += mydecimals + units(int.Parse(nums[2].ToString()));
                            }
                        }
                        else
                        {
                            myunits = units(int.Parse(nums[2].ToString()));
                            ans += mydecimals + "y" + myunits;
                        }
                    }
                    else if(nums[1] == '0' && nums[2] != '0')
                    {
                        ans += "to ";
                        string myunits = units(int.Parse(nums[2].ToString()));
                        ans += myunits;
                    }
                    else if(nums[1] == '0' && nums[2] == '0')
                    {
                        ans = "cien";
                    }
                    else
                    {
                        ans = "ciento diez";
                    }
                }
                else if (ans.Equals("quinientos "))
                {
                    if (nums[1] != '0' && nums[2] != '0')
                    {
                        string mydecimals = null;
                        string myunits = null;
                        mydecimals = decimals(int.Parse(nums[1].ToString()));
                        if (mydecimals == null)
                        {
                            var translatedNum = nums[1].ToString() + nums[2].ToString();
                            mydecimals += specificCases(int.Parse(translatedNum));
                            ans += mydecimals;
                        }
                        else if (mydecimals.Equals("veinti"))
                        {
                            if (nums[2] == '0')
                            {
                                var translatedNum = nums[1].ToString() + nums[2].ToString();
                                mydecimals = specificCases(int.Parse(translatedNum));
                                ans += mydecimals;
                            }
                            else
                            {
                                ans += mydecimals + units(int.Parse(nums[2].ToString()));
                            }
                        }
                        else
                        {
                            myunits = units(int.Parse(nums[2].ToString()));
                            ans += mydecimals + " y " + myunits;
                        }
                    }
                    else if (nums[1] == '0' && nums[2] != '0')
                    {
                        string myunits = units(int.Parse(nums[2].ToString()));
                        ans += myunits;
                    }
                    else if (nums[1] == '0' && nums[2] == '0')
                    {
                        ans = "quinientos";
                    }
                    else
                    {
                        ans = "quinientos" + decimals(int.Parse(nums[1].ToString())) + " y " + units(int.Parse(nums[2].ToString()));
                    }
                }
                else if (nums[1] == '0' && nums[2] != '0')
                {
                    ans += "cientos "+units(int.Parse(nums[2].ToString()));
                }
                else if (nums[1] == '0' && nums[2] == '0')
                {
                    ans += "cientos";
                }
                else
                {
                    ans += "cientos ";
                    string mydecimals = decimals(int.Parse(nums[1].ToString()));
                    string myunits = units(int.Parse(nums[2].ToString()));
                    if (mydecimals == null)
                    {
                        var translatedNum = nums[1].ToString() + nums[2].ToString();
                        mydecimals += specificCases(int.Parse(translatedNum));
                        ans += mydecimals;
                    }
                    else if (mydecimals.Equals("veinti"))
                    {
                        if (nums[2] == '0')
                        {
                            var translatedNum = nums[1].ToString() + nums[2].ToString();
                            mydecimals = specificCases(int.Parse(translatedNum));
                            ans += mydecimals;
                        }
                        else
                        {
                            ans += mydecimals + units(int.Parse(nums[2].ToString()));
                        }
                    }
                    else
                    {
                        ans += mydecimals + " y " + myunits;
                    }

                } 
            }
            return ans;

        }

        public string specificCases(int num)
        {
            string ans = null;
            if (num == 0) {
                ans = "cero";
            }
            if (num == 10)
            {
                ans = "diez";
            }
            if (num == 11)
            {
                ans = "once";
            }
            if (num == 12)
            {
                ans = "doce";
            }
            if (num == 13)
            {
                ans = "trece";
            }
            if (num == 14)
            {
                ans = "catorce";
            }
            if (num == 15)
            {
                ans = "quince";
            }
            if (num == 16)
            { 
                ans = "dieciseis";
            }
            if (num == 17)
            {
                ans = "diecisiete";
            }
            if (num == 18)
            {
                ans = "dieciocho";
            }
            if (num == 19)
            {
                ans = "diecinueve";
            }
            if (num == 20)
            {
                ans = "veinte";
            }
            return ans;
        }

        public string units(int num)
        {
            string ans = null;
            switch(num)
            {
                case 1:
                    ans = "uno";
                    break;
                case 2:
                    ans = "dos";
                    break;
                case 3:
                    ans = "tres";
                    break;
                case 4:
                    ans = "cuatro";
                    break;
                case 5:
                    ans = "cinco";
                    break;
                case 6:
                    ans = "seis";
                    break;
                case 7:
                    ans = "siete";
                    break;
                case 8:
                    ans = "ocho";
                    break;
                case 9:
                    ans = "nueve";
                    break;
            }
            return ans;
        }

        public string unitsWmill(int num)
        {
            string ans = null;
            switch (num)
            {
                case 1:
                    ans = "un";
                    break;
                case 2:
                    ans = "dos";
                    break;
                case 3:
                    ans = "tres";
                    break;
                case 4:
                    ans = "cuatro";
                    break;
                case 5:
                    ans = "cinco";
                    break;
                case 6:
                    ans = "seis";
                    break;
                case 7:
                    ans = "siete";
                    break;
                case 8:
                    ans = "ocho";
                    break;
                case 9:
                    ans = "nueve";
                    break;
            }
            return ans;
        }

        public string decimals(int num)
        {
            string ans = null;
            switch (num)
            {
                case 2:
                    ans = "veinti";
                    break;
                case 3:
                    ans = "treinta";
                    break;
                case 4:
                    ans = "cuarenta";
                    break;
                case 5:
                    ans = "cincuenta";
                    break;
                case 6:
                    ans = "sesenta";
                    break;
                case 7:
                    ans = "setenta";
                    break;
                case 8:
                    ans = "ochenta";
                    break;
                case 9:
                    ans = "noventa";
                    break;
            }
            return ans;
        }

        public string cents(int num)
        {
            string ans = null;
            switch (num)
            {
                case 1:
                    ans = "cien";
                    break;
                case 2:
                    ans = "dos";
                    break;
                case 3:
                    ans = "tres";
                    break;
                case 4:
                    ans = "cuatro";
                    break;
                case 5:
                    ans = "quinientos ";
                    break;
                case 6:
                    ans = "seis";
                    break;
                case 7:
                    ans = "sete";
                    break;
                case 8:
                    ans = "ocho";
                    break;
                case 9:
                    ans = "nove";
                    break;
            }
            return ans;
        }

        public string thousand(int num)
        {
            string ans = null;
            switch (num)
            {
                case 2:
                    ans = "dos";
                    break;
                case 3:
                    ans = "tres";
                    break;
                case 4:
                    ans = "cuatro";
                    break;
                case 5:
                    ans = "cinco";
                    break;
                case 6:
                    ans = "seis";
                    break;
                case 7:
                    ans = "siete";
                    break;
                case 8:
                    ans = "ocho";
                    break;
                case 9:
                    ans = "nove";
                    break;
            }
            return ans + "mil";
        }

        public string million(int num)
        {
            string ans = null;
            if(num == 1)
            {
                ans = "millon";
            } else if (num > 1)
            {
                ans = "millones";
            }

            return ans;
        }
    }
}
