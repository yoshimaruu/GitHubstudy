using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    int maxHp = 5;
    int currentHp;

    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 5;

        currentHp = maxHp;
        Debug.Log("Start currentHp : " + currentHp);
    }

    private void OnTriggerEnter(Collider collider)
    {
        
        if (collider.gameObject.tag == "Enemy")
        {
           
            int damage = 1;
            Debug.Log("damage : " + damage);

            
            currentHp = currentHp - damage;
            Debug.Log("After currentHp : " + currentHp);

            
            slider.value = (float)currentHp / (float)maxHp; ;
            Debug.Log("slider.value : " + slider.value);
        }
    }
    
    void Update()
    {
        
    }
}
