using System;
using System.Collections.Generic;

[Serializable]
public class Scores 
{
    public Scores() { }
    public List<ScoreStorage> ScoreList { get; set; } = new List<ScoreStorage>();
}
[Serializable]
public class ScoreStorage 
{
    public float Score;
    public string Name;
    public ScoreStorage() { }
    public ScoreStorage(float score, string name)
    {
        this.Score = score;
        this.Name = name;
    }
}
