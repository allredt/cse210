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

        do 
        {
            int rndIndex = new Random().Next(0, scriptureTextList.Count());

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

    public int hasWordsLeft()
    {
        int count = 0;

        foreach(string word in scriptureTextList)
        {
            if(count < 9)
            {
                count += 1;
                break;
            }
            // else if(word.Contains('_') == false)
            // {
            //     scriptureTextList
            // }

        }
        return count;
    }
}