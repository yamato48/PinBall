using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    private GameObject scoreText;

    private int score = 0;

    // Use this for initialization
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.GetComponent<Text>().text = "Score:" + score;
    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 10;
        }
        if (other.gameObject.tag == "LargeStarTag")
        {
            score += 30;
        }
        if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 50;
        }
        if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 100;
        }

    }

}