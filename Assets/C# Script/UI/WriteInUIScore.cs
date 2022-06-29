using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WriteInUIScore : MonoBehaviour
{

    public void WriteInUI(Scores storage)
    {
        int i = 0;
        float score;
        string name;
        Transform fatherObject = this.GetComponent<Transform>();
        foreach (Transform child in fatherObject)
        {
            if (storage.ScoreList.Count > i)
            {
                score = storage.ScoreList[i].Score;
                name = storage.ScoreList[i].Name;
                child.GetComponent<Text>().text = name + " : " + score;
            }
            i++;
        }
    }
}
