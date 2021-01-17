using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject hp_gauge;
    void Start()
    {
        this.hp_gauge = GameObject.Find("hp_gauge");
    }

    // Update is called once per frame
     public void DecreaseHp()
    {
        this.hp_gauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
