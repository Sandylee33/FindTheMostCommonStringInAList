using System.Collections;
using System.Collections.Generic;
using System;

public class FindMostCommon{

 
    Dictionary<string, int> FindCommon(List<string> stringList)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();
        for (int i = 0; i< stringList.Count; i++)
        {
            if (!result.ContainsKey(stringList[i]))
            {
                int counter = 1;
                result.Add(stringList[i], counter);
                for (int j = i+1; j < stringList.Count; j++)
                {
                    if (stringList[j] == stringList[i])
                    {
                        counter++;
                        result[stringList[i]] = counter;
                    }
                    
                }
            }

        }
        return result;
    }


 
    string[] FindMax(Dictionary<string,int> dic, int listLength)
    {
        List<string> result = new List<string>();
       

        while (listLength != 0 && result.Count == 0)
        {
            foreach (KeyValuePair<string, int> pair in dic)
            {
                if (pair.Value == listLength)
                {
                    result.Add(pair.Key);
                }
            }
            listLength--;
        }
        return result.ToArray();
    }


}
