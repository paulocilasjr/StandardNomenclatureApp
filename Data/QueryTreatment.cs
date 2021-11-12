using System;
using System.Text.RegularExpressions;
using TypeOfAminoAcidInput;
using ThreeLetterAminoAcidToOne;

namespace QueryTreatment
{
    public class MissenseVariant
    {
        public static string[] MissenseVariantToList (string userQuery)
        {
            string[] missenseVariantList = userQuery.Split(new char [] { ',', ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
            for(int index = 0; index < missenseVariantList.Length; index++)
            {
                missenseVariantList[index] = missenseVariantList[index].Trim( new char[] {'p', '.', '(', ')'});
                if(TypesOfAminoAcidInput.isThreeLetterAminoAcid(missenseVariantList[index]))
                {
                    int lengthOfMissense = missenseVariantList[index].Length;
                    int lastThreeCharacterIndex = missenseVariantList[index].Length - 3;
                    string startThreeLetterAminoAcid = missenseVariantList[index].Substring(0, 3);
                    string endThreeLetterAminoAcid = missenseVariantList[index].Substring(lastThreeCharacterIndex);
                    missenseVariantList[index] = missenseVariantList[index].Remove(lastThreeCharacterIndex);
                    missenseVariantList[index] = missenseVariantList[index].Remove(0,3);
                    string firstLetter = AminoAcidAbbreviationMap.ThreeLetterAbbreviationToOne(startThreeLetterAminoAcid);
                    string lastLetter = AminoAcidAbbreviationMap.ThreeLetterAbbreviationToOne(endThreeLetterAminoAcid);
                    missenseVariantList[index] = firstLetter+missenseVariantList[index]+lastLetter;
                }
            }
            return missenseVariantList;
        }

        public static bool MissenseValidation (string[] missenseVariantList)
        {
            bool isValid = true;
            foreach (string missense in missenseVariantList)
            {
                if(!TypesOfAminoAcidInput.isOneLetterAminoAcid(missense))
                {
                    isValid = false;
                }

            }
            return isValid;
        }
    }
}