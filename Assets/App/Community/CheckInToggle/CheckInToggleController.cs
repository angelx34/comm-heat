using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CheckInToggleController : MonoBehaviour
{
    public Button allOptionButton;

    public Button checkInOptionButton;

    private Color selectedColor = new Color(0, 176, 0, 255);
    private Color unselectedColor = new Color(12, 94, 7, 0);

    //private Color selectedColor = Color.green;
    //private Color unselectedColor = Color.green;
    
    // Start is called before the first frame update
    void Start()
    {
        allOptionButton.onClick.AddListener(_onAllOptionClicked);
        checkInOptionButton.onClick.AddListener(_onCheckInOptionClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void _onAllOptionClicked()
    {
        allOptionButton.image.color = selectedColor;
        checkInOptionButton.image.color = unselectedColor;
    }
    void _onCheckInOptionClicked()
    {
        allOptionButton.image.color = unselectedColor;
        checkInOptionButton.image.color = selectedColor;
    }
}
