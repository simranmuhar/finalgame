using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public GameObject Scorebox;
    int score = 0;
    
    public void addscore(int sc)
    {
        score = score + sc;
        Scorebox.GetComponent<Text>().text = "Score" + score;
    }
}
