using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private ScoreData sd;
    public int Number;
    

    private void Awake()
    {
        //PlayerPrefs.DeleteAll();
        switch (Number)
        {
            case 1:
                var json = PlayerPrefs.GetString("scores", "{}");
                sd = JsonUtility.FromJson<ScoreData>(json);
                break;
            case 2:
                var json2 = PlayerPrefs.GetString("scores2", "{}");
                sd = JsonUtility.FromJson<ScoreData>(json2);
                break;
            case 3:
                var json3 = PlayerPrefs.GetString("scores3", "{}");
                sd = JsonUtility.FromJson<ScoreData>(json3);
                break;
        }
    }

    public IEnumerable<Score> GetHighScorses()
    {
        switch(Number)
        {
            case 1:
                return sd.scores.OrderBy(x => x.score);
            case 2:
                return sd.scores2.OrderBy(x => x.score);
            case 3:
                return sd.scores3.OrderBy(x => x.score);
            default:
                return sd.scores.OrderBy(x => x.score);
        }
    }

    public void AddScore(Score score)
    {
        switch (Number)
        {
            case 1:
                sd.scores.Add(score); break;
            case 2:
                sd.scores2.Add(score); break;
            case 3:
                sd.scores3.Add(score); break;
        }
    }

    private void OnDestroy()
    {
        SaveScore();
    }
    public void SaveScore()
    {
        switch (Number)
        {
            case 1:
                var json = JsonUtility.ToJson(sd);
                PlayerPrefs.SetString("scores", json);
                break;
            case 2:
                var json2 = JsonUtility.ToJson(sd);
                PlayerPrefs.SetString("scores2", json2);
                break;
            case 3:
                var json3 = JsonUtility.ToJson(sd);
                PlayerPrefs.SetString("scores3", json3);

                break;
        }
    }

}