using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OyxgenTimer : MonoBehaviour
{
    public AudioSource OxygenRunningSfx;
    public float Timer = 60f;
    public Text TimerText;
    public Player playerScript;
    public GameObject oxygenTextHolder;
    public Level_Mover levelMoverScript;


    // Start is called before the first frame update
    void Start()
    {
        playerScript.isDead = false;
        oxygenTextHolder.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
            Timer = Timer - 1 * Time.deltaTime;
            TimerText.text = Timer.ToString("0");

            if (Timer <= 0 && levelMoverScript.won == false)
            {
                Timer = Timer * 0;
                playerScript.isDead = true;
            }
            if (Timer <= 11.5 && Timer >= 10.5 || Timer <= 9.5 && Timer >= 8.5 || Timer <= 7.5 && Timer >= 6.5 || Timer <= 5.5 && Timer >= 4.5 || Timer <= 3.5 && Timer >= 2.5 || Timer <= 1.5 && Timer >= 0.5)
            {
                OxygenRunningSfx.Play();
                oxygenTextHolder.SetActive(true);
            }
            else
            {
                oxygenTextHolder.SetActive(false);
            }
            if(levelMoverScript.won == true)
            {
                Timer = 60;
            }
    }
}
