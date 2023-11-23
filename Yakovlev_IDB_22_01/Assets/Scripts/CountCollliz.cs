using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountCollliz : MonoBehaviour
{
    static int counter=0;
    public Text rere;
       void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public
    void coutnUp()
    {
        counter++;
        rere.text =(counter).ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Fear"))
            coutnUp();
    }
}
