using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public RowUI rowUI;
    public ScoreManager scoreManager;
    //public Text name;
    public Text score;
    public static string name3;
    public int Number;

    void Update()
    {

    }
    void Start()
    {

        var namePlayer = Login.name2;

        switch (Number)
        {
            case 1:
                scoreManager.AddScore(new Score(namePlayer, score.text));
                var scores = scoreManager.GetHighScorses().ToArray();
                for (int i = 0; i < scores.Length; i++)
                {
                    var row = Instantiate(rowUI, transform).GetComponent<RowUI>();
                    row.rank.text = (i + 1).ToString();
                    row.name.text = scores[i].name;
                    row.score.text = scores[i].score.ToString();
                }
                break;
            case 2:
                scoreManager.AddScore(new Score(namePlayer, score.text));
                var scores2 = scoreManager.GetHighScorses().ToArray();
                for (int i = 0; i < scores2.Length; i++)
                {
                    var row2 = Instantiate(rowUI, transform).GetComponent<RowUI>();
                    row2.rank.text = (i + 1).ToString();
                    row2.name.text = scores2[i].name;
                    row2.score.text = scores2[i].score.ToString();
                }
                break;
        }
    }
}
