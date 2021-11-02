using System;
using System.Linq;
using System.Collections.Generic;


namespace AminoAcidToCodon
{
    public static class CodonMap
    {
        public static string[] CodonSequence (char aminoAcid)
        {
            string[] G = {"GGT","GGC","GGA","GGG"};
            string[] E = {"GAG", "GAA"};
            string[] D = {"GAC", "GAT"};
            string[] A = {"GCG", "GCA", "GCC", "GCT"};
            string[] V = {"GTG", "GTA", "GTC", "GTT"};
            string[] R = {"AGG", "AGA", "CGG", "CGA", "CGC", "CGT"};
            string[] S = {"AGC", "AGT", "TCG", "TCA", "TCC", "TCT"};
            string[] K = {"AGG", "AAA"};
            string[] N = {"AAC", "AAT"};
            string[] T = {"ACG", "ACA", "ACC", "ACT"};
            string[] M = {"ATG"};
            string[] I = {"ATA", "ATC", "ATT"};
            string[] Q = {"CAG", "CAA"};
            string[] H = {"CAC", "CAT"};
            string[] P = {"CCG", "CCA", "CCC", "CCT"};
            string[] L = {"CTG", "CTA", "CTC", "CTT", "TTG", "TTA"};
            string[] W = {"TGG"};
            string[] C = {"TGC", "TGT"};
            string[] Y = {"TAC", "TAT"};
            string[] F = {"TTC", "TTT"};
            string[] STOP = {"TGA", "TAG", "TAA"};

            Dictionary<string, string[]>codonMap = new Dictionary<string, string[]>()
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
                {"STOP", STOP}
            };
            return codonMap[Char.ToString(aminoAcid)];
        }
    }   
}