using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Playerhealth : MonoBehaviour
{
    private int playerMAXHP = 10;
    private int playerHP;
    //public Slider HPSlider;
    // public Text HPLabel;

    // Start is called before the first frame update
    void Start()
    {
        playerHP = playerMAXHP;
        //HPSlider.maxValue = playerMAXHP;
        // HPSlider.value = playerHP;
        // HPLabel.text = "" + playerHP;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            playerHP -= 2;
            // HPSlider.value = playerHP;
            // HPLabel.text = "" + playerHP;
        }
        if (playerHP == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
