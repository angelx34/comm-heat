using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContactCardController : MonoBehaviour
{
    public TextMeshProUGUI nameTextRef;
    public TextMeshProUGUI milesTextRef;
    public TextMeshProUGUI tempTextRef;

    public String nameValue;
    public int milesValue;
    public int tempValue;
    // Start is called before the first frame update
    void Start()
    {
        nameTextRef.SetText(nameValue);
        milesTextRef.SetText(milesValue.ToString());
        tempTextRef.SetText(tempValue.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
