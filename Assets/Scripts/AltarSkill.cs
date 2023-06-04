using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarSkill : MonoBehaviour
{
    int cont_skill;
    bool newSkillCounter;
    void Start()
    {
        cont_skill = 1;
    }

    void Update()
    {
        if (Input.GetKey("f") && newSkillCounter && (cont_skill == 1))
        {
            //player dead
            //carga de nuevo sprite
            print("Nueva habilidad obtenida EMBESTIDA");
            cont_skill = 0;
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collisioner)
    {
        if ((collisioner.transform.tag == "Player") && (cont_skill == 1))
        {
            print("aprender nueva habilidad?");
            newSkillCounter = true;
        }
        else
        {
            newSkillCounter = false;
        }
    }
}