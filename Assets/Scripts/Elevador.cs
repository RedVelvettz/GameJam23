using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevador : MonoBehaviour
{
    float changer;
    private void Start()
    {
        changer = 1f;
    }
    private void Update()
    {
        gameObject.transform.Translate(0, changer * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D collisioner)
    {
        if (collisioner.gameObject.tag == "starteleve")
        {
            changer = 10f;
        }
        if (collisioner.gameObject.tag == "finaleleve") 
        {
            changer = -10f;
        }

    }

}
