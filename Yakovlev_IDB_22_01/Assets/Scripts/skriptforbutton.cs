using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skriptforbutton : MonoBehaviour
{
    public bool isActive=true;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(isActive);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Activatorka()
    {
        if (isActive) {
            isActive = false;
            gameObject.SetActive(isActive);
        }
        else
        {
            isActive = true;
            gameObject.SetActive(isActive);
        }
        
    }
}
