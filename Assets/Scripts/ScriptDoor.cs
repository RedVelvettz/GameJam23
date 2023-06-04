using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDoor : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bull")
        {
            Debug.Log("Rompete");
            Destroy(gameObject);
        }
    }
}
