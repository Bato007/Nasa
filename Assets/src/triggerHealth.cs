using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerHealth : MonoBehaviour
{
    public GameObject option;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (option)
            option.SetActive(true);

        // Va para el Controll Room
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Make something
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (option)
            option.SetActive(false);
    }

}
