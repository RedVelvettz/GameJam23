using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondEnemy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Invi")
        {
            Debug.Log("Rompete");
            Destroy(gameObject);
        }
    }
}
