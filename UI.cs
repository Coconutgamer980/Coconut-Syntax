using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public static int CoinsScore;
    public Text CoinsScoreText;
    public static int berryScore;
    public Text berryScoreText;
    public static int RubyScore;
    public Text RubyScoreText;

    void Update()
    {
        CoinsScoreText.text = CoinsScore.ToString();
        berryScoreText.text = berryScore.ToString();
        RubyScoreText.text = RubyScore.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Coin")
        {
            CoinsScore = CoinsScore + 1;
        }
        if (collision.collider.tag == "GreenBerry")
        {
            berryScore = berryScore + 1;
        }
        if (collision.collider.tag == "Ruby")
        {
            RubyScore = RubyScore + 1;
        }
    }
}
