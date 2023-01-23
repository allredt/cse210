using System;

class ScriptureMemorizer
{
    private Scripture scripture;
    private List<string> scriptureTextList;

    public ScriptureMemorizer(Scripture _scripture)
    {
        scripture = _scripture;
        scriptureTextList = new List<string>();
        convertTextToList();
    }

    private void convertTextToList()
    {
        scriptureTextList = scripture.toString().Split(" ").ToList();
    }

    public void removeWordsFromText()
    {
        int numWordsToRemove = 3;
        int wordsRemoved = 0;
        int Count = 0;

        do 
        {
            int rndIndex = new Random().Next(0, scriptureTextList.Count());

            Count +=1;
            if (scriptureTextList[rndIndex].Contains('_') == false)
            {
                scriptureTextList[rndIndex] = new string('_', scriptureTextList[rndIndex].Length);
                wordsRemoved++;
            }

        }while(wordsRemoved != numWordsToRemove);
    }

    public string toString()
    {
        return string.Join(' ', scriptureTextList);
    }

    public bool hasWordsLeft()
    {
        bool retvalue = false;

        foreach(string word in scriptureTextList)
        {
            if(word.Contains('_') == false)
            {
                retvalue = true;
                break;
            }
        }
        return retvalue;
    }
}