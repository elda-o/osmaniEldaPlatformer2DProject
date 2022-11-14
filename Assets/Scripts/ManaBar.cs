using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    public Slider Mana;

    // Start is called before the first frame update
    void Start()
    {
        Mana.value++;

        if(Mana.value > 20)
        {
            Mana.value = 20;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
