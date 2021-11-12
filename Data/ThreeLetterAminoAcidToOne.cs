using System;
using System.Linq;
using System.Collections.Generic;


namespace ThreeLetterAminoAcidToOne
{
    public static class AminoAcidAbbreviationMap
    {
        public static string ThreeLetterAbbreviationToOne (string aminoAcidThreeLetterAbrreviation)
        {
            string ALA = "A"; 
            string ARG = "R";
            string ASN = "N";
            string ASP = "D";
            string CYS = "C"; 
            string GLN = "Q"; 
            string GLU = "E"; 
            string GLY = "G"; 
            string HIS = "H";
            string ILE = "I"; 
            string LEU = "L"; 
            string LYS = "K"; 
            string MET = "M"; 
            string PHE = "F";
            string PRO = "P"; 
            string SER = "S"; 
            string THR = "T";
            string TRP = "W";
            string TYR = "Y";
            string VAL = "V"; 

            Dictionary<string, string> aminoAcidLetterMap = new Dictionary<string, string>()
            {
                {"GLY", GLY},
                {"ALA", ALA},
                {"GLU", GLU},
                {"ASP", ASP},
                {"VAL", VAL},
                {"ARG", ARG},
                {"SER", SER},
                {"LYS", LYS},
                {"ASN", ASN},
                {"THR", THR},
                {"MET", MET},
                {"ILE", ILE},
                {"GLN", GLN},
                {"HIS", HIS},
                {"PRO", PRO},
                {"LEU", LEU},
                {"TRP", TRP},
                {"CYS", CYS},
                {"TYR", TYR},
                {"PHE", PHE},
            };
            
            return aminoAcidLetterMap[aminoAcidThreeLetterAbrreviation.ToUpper()];
        }
    }   
}