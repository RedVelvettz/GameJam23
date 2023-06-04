using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarSkillBlue : MonoBehaviour
{
    int cont_skillr, cont_skillb, cont_skilly;
    bool newSkillCounter;
    public GameObject barra;
    //public CorruptedEnergyBar corruptedEnergyBar;
    void Start()
    {
        cont_skillr = 1;
        //corruptedEnergyBar = GetComponent<CorruptedEnergyBar>();
    }

    void Update()
    {
        if (Input.GetKey("f") && newSkillCounter && (cont_skillr == 1))
        {
            //player dead
            //carga de nuevo sprite
            print("Nueva habilidad obtenida EMBESTIDA");
            cont_skillr = 0;
            gameObject.SetActive(false);
            barra.GetComponent<CorruptedEnergyBar>().actualLife = 70;
            //corruptedEnergyBar.actualLife = 40;


        }
    }

    private void OnTriggerEnter2D(Collider2D collisioner)
    {
        if ((collisioner.transform.tag == "Player") && (cont_skillr == 1))
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
