using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Score
{
    public string name;
    public string score;

    public Score(string name, string score)
    {
        this.name = name;
        this.score = score;
    }
}
