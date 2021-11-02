namespace QueryTreatment
{
    public class MissenseVariant
    {
        public static string[] MissenseVariantToList (string userQuery)
        {
            string[] missenseVariantList = userQuery.Split(";");
            return missenseVariantList;
        }

        public static bool MisseseValidation (string[] missenseVariantList)
        {
            bool isValid = true;
            foreach(string missenseVariant in missenseVariantList)
            {
                int iteration = 0;
                foreach (char atTheMoment in missenseVariant)
                {
                    if(iteration == 0)
                    {
                        if (char.IsDigit(missenseVariant[0]))
                        {
                            isValid = false;
                        }    
                        iteration ++;
                    }
                
                    else if (iteration == missenseVariant.Length-1)
                    {
                        if(char.IsDigit(missenseVariant[missenseVariant.Length-1]))
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
            }
            return isValid;
        }
    }
}