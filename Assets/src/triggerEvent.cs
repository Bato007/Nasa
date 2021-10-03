using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerEvent : MonoBehaviour
{
    public GameObject option;
    public bool allowed = false;
    public int[] index;
    public int function;
   
    private void OnTriggerStay2D(Collider2D collision)
    {
        option.SetActive(true);

        // Va para el Controll Room
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (function == 0)
            {
                SceneManager.LoadScene(index[0]);
            } else
            {
                
            }
        }
        // Va para hacer ejercicio
        else if (Input.GetKeyDown(KeyCode.F) && allowed)
        {
            SceneManager.LoadScene(index[1]);
        }
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        option.SetActive(false);
    }

}
