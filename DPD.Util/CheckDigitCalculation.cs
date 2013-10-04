using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPD.Util
{
    public class CheckDigitCalculation
    {

        /// <summary>
        /// Document ISO/IEC 7064:2003 
        /// Algorithm: hybrid system recursive 
        /// as described in chapter 10.1.1 
        /// Naming of variables and algorithm is related to the document for easier 
        /// understanding 
        /// ISO/IEC 7064, MOD 37,36 
        /// param s String to generate check character for 
        /// return check character 
        /// or -1 if character exceeds ascii2isoval table 
        /// Author: Marc Sierszen, Peter Liebel   DELICom DPD GmbH 
        /// </summary>
        /// <param name="s">The tracking number.</param>
        /// <returns></returns>
        public char Get_Iso7064_Mod37_36(char[] s)
        {
            int i;
            int P = 0;
            int M, M1; /* Modulus */

            /* table convert ASCII character to ISO/IEC 7064 values */
            byte[] ascii2isoval = {   
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,   
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,   
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,   
                0, 1, 2 ,3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 0, 0,   
                0,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,   
                25,26,27,28,29,30,31,32,33,34,35,0, 0, 0, 0, 0,   
                0,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,  /*  handle  lower  characters like upper characters */ 
                25,26,27,28,29,30,31,32,33,34,35
            };
            /* table convert ISO/IEC 7064 values to ASCII character */
            char[] isoval2ascii = {   
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',   
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',   
                'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',   
                'U', 'V', 'W', 'X', 'Y', 'Z', '*'
            };

            /* check if alphabetic character is within limits */
            for (i = 0; i < s.Length; i++)
                if ((s[i] < 0))
                    return char.MinValue; //0
            M = 36;

            M1 = M + 1;
            P = M;
            for (i = 0; i < s.Length; i++)
            {
                P += ascii2isoval[s[i]];
                if (P > M) P -= M;
                P *= 2;
                if (P >= M1) P -= M1;
            }
            P = M1 - P;
            return (P == M) ? isoval2ascii[0] : isoval2ascii[P];
        }
    }
}
