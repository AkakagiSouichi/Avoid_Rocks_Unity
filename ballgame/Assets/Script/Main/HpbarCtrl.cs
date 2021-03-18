using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HpbarCtrl : MonoBehaviour {

    Slider _slider;
    void Start()
    {
     
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    void Update()
    {
        int HPcount = PlayerHP.getHpcount();
        _slider.value = HPcount;
    }
}
