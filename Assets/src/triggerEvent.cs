using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerEvent : MonoBehaviour
{
    public GameObject option;
    public bool allowed = false;
    public int[] index;
   
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (option && collision.tag != "Arrow")
            option.SetActive(true);

        // Va para el Controll Room
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(index[0]);
        }
        // Va para hacer ejercicio
        else if (Input.GetKeyDown(KeyCode.F) && allowed)
        {
            SceneManager.LoadScene(index[1]);
        }
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (option && collision.tag != "Arrow")
            option.SetActive(false);
    }

}
