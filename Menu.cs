using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject mainMenuButtons;
    public GameObject LevelselectPanel;
    public GameObject controls;
    public GameObject OptionsMenu;
    public GameObject AcivementPanel;

    public Text coinScore;
    public static int coinMax;
    public Text berryScore;
    public static int berryMax;
    public Text rubyScore;
    public static int rubyMax;

    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Play();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnApplicationQuit();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            Options();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Back();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            one();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            two();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            three();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            four();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene("Tutorial Level");
            print("Tutorial Level");
        }

        coinScore.text = coinMax.ToString();
        berryScore.text = berryMax.ToString();
        rubyScore.text = rubyMax.ToString();
    }

    public string nextLevelName;
    public void Play()
    {
        mainMenuButtons.SetActive(false);
        LevelselectPanel.SetActive(true);
    }
    public void Back()
    {
        mainMenuButtons.SetActive(true);
        LevelselectPanel.SetActive(false);
        controls.SetActive(false);
        OptionsMenu.SetActive(false);
        AcivementPanel.SetActive(false);
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
        print("Quit");
    }
    public void Controls()
    {
        mainMenuButtons.SetActive(false);
        LevelselectPanel.SetActive(false);
        OptionsMenu.SetActive(false);
        AcivementPanel.SetActive(false);
        controls.SetActive(true);
    }
    public void Options()
    {
        mainMenuButtons.SetActive(false);
        LevelselectPanel.SetActive(false);
        controls.SetActive(false);
        AcivementPanel.SetActive(false);
        OptionsMenu.SetActive(true);
    }
    public void Acivements()
    {
        mainMenuButtons.SetActive(false);
        LevelselectPanel.SetActive(false);
        controls.SetActive(false);
        OptionsMenu.SetActive(false);
        AcivementPanel.SetActive(true);
    }

    // Level Selector
        public void T ()
            {
                SceneManager.LoadScene("Tutorial Level");
                print("Tutorial Level");
            }
        public void one ()
            {
                SceneManager.LoadScene("Level1");
                print("Level1");
            }
        public void two()
            {
                SceneManager.LoadScene("Level2");
                print("Level2");
            }
        public void three()
            {
                SceneManager.LoadScene("Level3");
                print("Level3");
            }
        public void four()
            {
                SceneManager.LoadScene("Level4");
                print("Level4");
            }
}
