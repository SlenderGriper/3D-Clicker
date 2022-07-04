using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;


public class Score : MonoBehaviour
{
    private Scores _storage=new Scores();
    string path;


    private void Start()
    {
        path = Application.persistentDataPath + "/Score.xml";
        ReadXML();
    }
    private void WriteXML()
    {
        XmlSerializer xml = new XmlSerializer(typeof(Scores));
        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
        {
           xml.Serialize(fs,_storage);
        }
    }
    private void ReadXML()
    {
        XmlSerializer xml = new XmlSerializer(typeof(Scores));
        
        Debug.Log(path);
        if(!File.Exists(path))
        {
            _storage.ScoreList.Add(new ScoreStorage(2500, "Hacker"));
            _storage.ScoreList.Add(new ScoreStorage(500, "Pro"));
            _storage.ScoreList.Add(new ScoreStorage(100, "Noob"));
        }
        else using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
        {
                _storage =(Scores)xml.Deserialize(fs);
        }
        
    }
    public Scores CatchList => _storage;
    public void AddList()
    {
        float score= GetComponent<TextChanger>().GetScore;
        string name="Player";
        _storage.ScoreList.Add(new ScoreStorage(score, name));
        FilteringList();
        WriteXML();
    }
    private void FilteringList()
    {
        //bubble sort
        ScoreStorage tml;
        for (int i = _storage.ScoreList.Count - 1; i > 0; i--)
        {
            if (_storage.ScoreList[i - 1].Score < _storage.ScoreList[i].Score)
            {
                tml = _storage.ScoreList[i - 1];
                _storage.ScoreList[i - 1] = _storage.ScoreList[i];
                _storage.ScoreList[i] = tml;
            }
        }

        if (_storage.ScoreList.Count > 6) _storage.ScoreList.RemoveAt(6);
    }
}


