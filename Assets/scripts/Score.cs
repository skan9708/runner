using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public int totalScore=0;

	public void AddScore(int score)
    {
        totalScore += score;
	    gameObject.GetComponent<Text>().text = totalScore.ToString();
	}

}
