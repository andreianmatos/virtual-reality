using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class Menu : MonoBehaviour
{

    public bool trigger = false;
    public static bool isMenu = false;

    public GameObject thisMenuUI;

 

    public bool getTrigger()
    {
        return trigger;
    }
    public void setTrigger(bool t)
    {
        trigger = t;
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        //if(trigger)
        {
            if (Menu.isMenu)
            {
                Menu.isMenu = true;
                Resume();
            }
            else
            {
                Menu.isMenu = false;
                OpenMenu();
            }
        }
    }


    void Resume()
    {
        thisMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isMenu = false;
    }

    void OpenMenu()
    {
        thisMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isMenu = true;
    }

}
