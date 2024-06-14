using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ScoreData
{
    public List<Score> scores;
    public List<Score> scores2;
    public List<Score> scores3;

    public int NumberScene;

    public ScoreData()
    {
        scores = new List<Score>();
        scores2 = new List<Score>();
        scores3 = new List<Score>(); 
        
    }
}
