using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCard : MonoBehaviour
{

    public TextMeshProUGUI textmesh;
    public static ScoreCard scoreManager;
    public int score = 0;
    // Start is called before the first frame update
    private void Awake(){
        scoreManager = this;
    }
    void Start()
    {
        textmesh.text = score.ToString();
    }

    // Update is called once per frame
    public void AddScore(int points){
        score += points;
        textmesh.text = score.ToString();
    }
}
