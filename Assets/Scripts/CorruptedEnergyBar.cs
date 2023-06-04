using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorruptedEnergyBar : MonoBehaviour
{
    public Image corruptedBarImage;
    public Image energyBar;
    public float actualLife;
    float maxLife;
    void Start()
    {
        maxLife = 100;
        actualLife = 12;
    }
    void Update()
    {
        corruptedBarImage.fillAmount = actualLife / maxLife;
        energyBar.fillAmount = actualLife / maxLife;
        if (corruptedBarImage.fillAmount > 0.95 && energyBar.fillAmount > 0.95)
        {
            corruptedBarImage.color = new Color(1, 0.92f, 0.016f, 1);
            energyBar.color = new Color(1, 0.92f, 0.016f, 1);
        }
        else
        {
            if ((corruptedBarImage.fillAmount > 0.69 && energyBar.fillAmount > 0.69))
            {
                corruptedBarImage.color = new Color(0, 0, 1, 1);
                energyBar.color = new Color(0, 0, 1, 1);
            }
            else
            {
                if ((corruptedBarImage.fillAmount > 0.39 && energyBar.fillAmount > 0.39))
                {
                    corruptedBarImage.color = new Color(1, 0, 1, 1);
                    energyBar.color = new Color(1, 0, 1, 1);
                }
                else
                {
                    corruptedBarImage.color = new Color(0.5f, 0.5f, 0.5f, 1);
                    energyBar.color = new Color(0.5f, 0.5f, 0.5f, 1);
                }
            }
        }
        print(corruptedBarImage.fillAmount);
    }
}