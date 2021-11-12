namespace TypeOfAminoAcidInput
{
    static class TypesOfAminoAcidInput
    {
        static public bool isOneLetterAminoAcid (string eachUserInput) 
        {
            bool isValid = true;
            int iteration = 0;
            foreach (char atTheMoment in eachUserInput)
            {
                if(iteration == 0)
                {
                    if (char.IsDigit(eachUserInput[0]))
                    {
                        isValid = false;
                    }    
                    iteration ++;
                }
            
                else if (iteration == eachUserInput.Length-1)
                {
                    if(char.IsDigit(eachUserInput[eachUserInput.Length-1]))
                    {
                        isValid = false;
                    }
                }
                else
                {
                    if(!char.IsDigit(atTheMoment))
                    {
                        isValid = false;
                    }
                    iteration ++;
                }
            }
            return isValid;
        }
        static public bool isThreeLetterAminoAcid (string eachUserInput)
        {
            bool isValid = true;
            int iteration = 0;
            foreach (char atTheMoment in eachUserInput)
            {
                if(iteration == 0 || iteration == 1 || iteration == 2)
                {
                    if (char.IsDigit(eachUserInput[iteration]))
                    {
                        isValid = false;
                    }    
                    iteration ++;
                }
            
                else if (iteration == eachUserInput.Length-1 || iteration == eachUserInput.Length-2 || iteration == eachUserInput.Length-3)
                {
                    if(char.IsDigit(eachUserInput[iteration]))
                    {
                        isValid = false;
                    }
                    iteration ++;
                }
                else
                {
                    if(!char.IsDigit(atTheMoment))
                    {
                        isValid = false;
                    }
                    iteration ++;
                }               
            }
            return isValid;
        }
    }
}