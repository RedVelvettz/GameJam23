using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpPersonaje : MonoBehaviour
{
    private GameObject currentTeleport;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            if(currentTeleport !=null)
            {
                transform.position = currentTeleport.GetComponent<Telep>().GetDestination().position;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Teleporter"))
        {
            Debug.Log("tpcolision");
            currentTeleport = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            if(collision.gameObject == currentTeleport)
            {
                currentTeleport = null;
            }
           
        }
    }
}
