using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public static bool trigger = false;
    public static bool isMenu = false;

    public GameObject thisMenuUI;


    // Update is called once per frame
    void Update()
    {
        if (trigger)
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
