using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAEnemy : MonoBehaviour
{
    float changer;
    private void Start()
    {
        changer = 1f;
    }
    private void Update()
    {
        gameObject.transform.Translate(changer * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D collisioner)
    {
        if (collisioner.gameObject.tag == "startlimit")
        {
            changer = 1f;
        }
        if (collisioner.gameObject.tag == "finallimit")
        {
            changer = -1f;
        }
        if (collisioner.gameObject.tag == "specialskillthree")
        {
            print("Detectado habilidad 3");
            float posX, posY, posZ;
            posX = gameObject.transform.position.x;
            posY = gameObject.transform.position.y;
            posZ = gameObject.transform.position.z;
            gameObject.transform.position = new Vector3(posX, posY, posZ);
            changer = 0;
            Rigidbody2D rigidBody;
            rigidBody = GetComponent<Rigidbody2D>();
            rigidBody.constraints = RigidbodyConstraints2D.None;
            //gameObject.GetComponent<Rigidbody2D>().constraints.None;
            print(RigidbodyConstraints2D.FreezePositionY);
        }
    }

}