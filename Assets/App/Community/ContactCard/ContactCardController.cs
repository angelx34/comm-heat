using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ContactCardController : MonoBehaviour
{
    public TextMeshProUGUI nameTextRef;
    public TextMeshProUGUI milesTextRef;
    public TextMeshProUGUI tempTextRef;
    public GameObject favoriteIconRef;
    public Image TempHouseIconRef;
    public Sprite redHouse;
    public Sprite yellowHouse;
    public Sprite greenHouse;
    
    private Color favoriteColor = new Color(138, 135, 135, 255);
    private Color notFavoriteColor = new Color(200, 40, 40, 100);
    // Start is called before the first frame update

    public void setName(string newName)
    {
        nameTextRef.SetText(newName);
    }
    
    public void setdistance(double newDistance)
    {
        milesTextRef.SetText(newDistance.ToString() + " miles away");
    }
    
    public void setTemp(int newTemp)
    {
        tempTextRef.SetText(newTemp.ToString());
        if (newTemp >= 90)
        {
            TempHouseIconRef.sprite = redHouse;
        } else if (newTemp >= 80)
        {
            TempHouseIconRef.sprite = yellowHouse;
        }
        else
        {
            TempHouseIconRef.sprite = greenHouse;
        }
    }

    public void setFavorite(bool value)
    {
        if (value)
        {
            favoriteIconRef.GetComponent<Image>().color = Color.gray;
        }
        else
        {
            favoriteIconRef.GetComponent<Image>().color = Color.white;
        }
    }
}
