using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideUI : MonoBehaviour
{
    public GameObject UIcomponent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            UIcomponent.SetActive(false);
        }
    }
}
