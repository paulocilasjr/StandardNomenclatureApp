using System;
using System.Linq;
using System.Collections.Generic;
using AminoAcidToCodon;

namespace MissenseVariantInfoSeparation
{
    public class GetMissenseInfos
    {
        public char variantReference {get; set;}
        public char variantMutant {get; set;}
        public int codon {get; set;}
        
        public GetMissenseInfos (string missenseVariant)
        {
            this.variantReference = char.ToUpper(missenseVariant[0]);
            this.variantMutant = char.ToUpper(missenseVariant[missenseVariant.Length-1]);
            this.codon  = Int32.Parse(missenseVariant.Substring(1, (missenseVariant.Length-2)));
        }

         public static List<string> GetCodonsCompared (List<GetMissenseInfos> missenseVariantsObject) 
         {
             List<string> cNomenclature = new List<string>();
             foreach (GetMissenseInfos missenseVariantObject in missenseVariantsObject)
             {
                string[] variantReferenceCodons = CodonMap.CodonSequence(missenseVariantObject.variantReference);
                string[] variantMutantCodons = CodonMap.CodonSequence(missenseVariantObject.variantMutant);
                foreach (string mutantCodon in variantMutantCodons)
                {
                    foreach (string referenceCodon in variantReferenceCodons)
                    {
                        int numberOfDifference = 0;
                        string possibleNomenclature = "";
                        int codonPosition;
                        for (int index = 0; index < 3; index++)
                        {
                            if (mutantCodon[index]!=referenceCodon[index])
                            {
                                numberOfDifference ++;
                                codonPosition = (missenseVariantObject.codon * 3) - (-1*(index-2)); 
                                possibleNomenclature = $"c.{codonPosition}{referenceCodon[index]}>{mutantCodon[index]}";
                            }
                        }
                        if (numberOfDifference == 1)
                        {
                            cNomenclature.Add(possibleNomenclature);
                        }

                    }   
                }
             }
             return cNomenclature;
         }
    }
    
}