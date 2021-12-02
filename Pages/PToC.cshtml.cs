using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.RegularExpressions;

namespace StandarNomenclature.Pages
{
    public class PToCModel : PageModel
    {
        public string Message { get; set; }
        public string[] listOfmissenseVariants { get; set; }
        public List<string> nomenclature { get; set; }
        
        public void OnGet()
        {
            Message = "Insert the HGVG or BIC missense list here";
        }

        public void OnPost(string missenseQuery)
        {
            listOfmissenseVariants = missenseQuery.Split(new char[] { ',', ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> resultsToReturn = new List<string>();
            
            for (int index = 0; index < listOfmissenseVariants.Length; index++)
            {
                listOfmissenseVariants[index] = listOfmissenseVariants[index].Trim(new char[] { 'p', '.', '(', ')' });
                List<List<string>> nomenclatureResults = new List<List<string>>();
                string fullNomenclatureResult = $"{listOfmissenseVariants[index]} = ";

                //Get aminoacid number position
                var position = listOfmissenseVariants[index].Where(c => Char.IsDigit(c)).ToArray();
                int aminoacidPostion = Int32.Parse(string.Join(",", position));
                
            //Prepare all possible inputs to work with (1 letter abbreviation or 3 letter abbreviation)
                List<string> listOfPossibleAbbreviationsStart = new List<string>();
                listOfPossibleAbbreviationsStart.Add(listOfmissenseVariants[index].Substring(0, 3));
                listOfPossibleAbbreviationsStart.Add(listOfmissenseVariants[index].Substring(0, 1));
                List<string> listOfPossibleAbbreviationsEnd = new List<string>();
                listOfPossibleAbbreviationsEnd.Add(listOfmissenseVariants[index].Substring(listOfmissenseVariants[index].Length-3));
                listOfPossibleAbbreviationsEnd.Add(listOfmissenseVariants[index].Substring(listOfmissenseVariants[index].Length-1));

                List<string> codonReference = new List<string> (GetCodonReference(listOfPossibleAbbreviationsStart));
                List<string> codonMutant = new List<string> (GetCodonReference(listOfPossibleAbbreviationsEnd));

                nomenclatureResults.Add(GetCodonsCompared(codonReference, codonMutant, aminoacidPostion));
                foreach(List<string>items in nomenclatureResults)
                {
                    foreach(string item in items)
                    {
                        fullNomenclatureResult += item + ", ";
                    }
                }
                resultsToReturn.Add(fullNomenclatureResult.Remove(fullNomenclatureResult.Length -2));
            }
            nomenclature = resultsToReturn;
            Message = "Insert the HGVG or BIC missense list here";
        }

        public List<string> GetCodonReference(List<string> abbreviationLetters)
        {
            List<string> codonsToReturn = new List<string>();
            foreach (string abbreviation in abbreviationLetters)
            {
                if (!abbreviation.Any(char.IsDigit))
                {
                    codonsToReturn = CodonSequence(abbreviation);
                    break;
                }
                else codonsToReturn.Add("Not Valid Entry");
            }
            return codonsToReturn;
        }
        public static List<string> CodonSequence(string aminoAcid)
        {
            string[] G = { "GGT", "GGC", "GGA", "GGG" };
            string[] E = { "GAG", "GAA" };
            string[] D = { "GAC", "GAT" };
            string[] A = { "GCG", "GCA", "GCC", "GCT" };
            string[] V = { "GTG", "GTA", "GTC", "GTT" };
            string[] R = { "AGG", "AGA", "CGG", "CGA", "CGC", "CGT" };
            string[] S = { "AGC", "AGT", "TCG", "TCA", "TCC", "TCT" };
            string[] K = { "AGG", "AAA" };
            string[] N = { "AAC", "AAT" };
            string[] T = { "ACG", "ACA", "ACC", "ACT" };
            string[] M = { "ATG" };
            string[] I = { "ATA", "ATC", "ATT" };
            string[] Q = { "CAG", "CAA" };
            string[] H = { "CAC", "CAT" };
            string[] P = { "CCG", "CCA", "CCC", "CCT" };
            string[] L = { "CTG", "CTA", "CTC", "CTT", "TTG", "TTA" };
            string[] W = { "TGG" };
            string[] C = { "TGC", "TGT" };
            string[] Y = { "TAC", "TAT" };
            string[] F = { "TTC", "TTT" };

            string[] GLY = { "GGT", "GGC", "GGA", "GGG" };
            string[] GLU = { "GAG", "GAA" };
            string[] ASP = { "GAC", "GAT" };
            string[] ALA = { "GCG", "GCA", "GCC", "GCT" };
            string[] VAL = { "GTG", "GTA", "GTC", "GTT" };
            string[] ARG = { "AGG", "AGA", "CGG", "CGA", "CGC", "CGT" };
            string[] SER = { "AGC", "AGT", "TCG", "TCA", "TCC", "TCT" };
            string[] LYS = { "AGG", "AAA" };
            string[] ASN = { "AAC", "AAT" };
            string[] THR = { "ACG", "ACA", "ACC", "ACT" };
            string[] MET = { "ATG" };
            string[] ILE = { "ATA", "ATC", "ATT" };
            string[] GLN = { "CAG", "CAA" };
            string[] HIS = { "CAC", "CAT" };
            string[] PRO = { "CCG", "CCA", "CCC", "CCT" };
            string[] LEU = { "CTG", "CTA", "CTC", "CTT", "TTG", "TTA" };
            string[] TRP = { "TGG" };
            string[] CYS = { "TGC", "TGT" };
            string[] TYR = { "TAC", "TAT" };
            string[] PHE = { "TTC", "TTT" };
            
            string[] STOP = { "TGA", "TAG", "TAA" };

            Dictionary<string, string[]> codonMap = new Dictionary<string, string[]>()
            {
                {"G", G},
                {"A", A},
                {"E", E},
                {"D", D},
                {"V", V},
                {"R", R},
                {"S", S},
                {"K", K},
                {"N", N},
                {"T", T},
                {"M", M},
                {"I", I},
                {"Q", Q},
                {"H", H},
                {"P", P},
                {"L", L},
                {"W", W},
                {"C", C},
                {"Y", Y},
                {"F", F},

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

                {"STOP", STOP}
            };
            string[] value = {};
            if (codonMap.TryGetValue(aminoAcid.ToUpper(), out value))
            {
                List<string> list = new List<string>(codonMap[aminoAcid.ToUpper()]);
                return list;
            }
            else
            {
                List<string> list = new List<string>();
                list.Add($"This entry is not a valid aminoacid: {aminoAcid}");
                return list;
            }
        }
        public static List<string> GetCodonsCompared(List<string> codonsReference, List<string> codonsMutant, int aminoacidPostion)

        {
            List<string> cNomenclature = new List<string>();
            foreach (string mutantCodon in codonsMutant)
            {
                foreach (string referenceCodon in codonsReference)
                {
                    int numberOfDifference = 0;
                    string possibleNomenclature = "";
                    int codonPosition;
                    for (int index = 0; index < 3; index++)
                    {
                        if (mutantCodon[index] != referenceCodon[index])
                        {
                            numberOfDifference++;
                            codonPosition = (aminoacidPostion * 3) - (-1 * (index - 2));
                            possibleNomenclature = $"c.{codonPosition}{referenceCodon[index]}>{mutantCodon[index]}";
                        }
                    }
                    if (numberOfDifference == 1)
                    {
                        if (!cNomenclature.Contains(possibleNomenclature))
                        {
                            cNomenclature.Add(possibleNomenclature);
                        }
                    }
                }
            }
            if (!cNomenclature.Any())
            {
                cNomenclature.Add("No matching result for this entry");
            }
            return cNomenclature;
        }
    }
}

