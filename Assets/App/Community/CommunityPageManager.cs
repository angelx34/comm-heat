using System.Collections;
using System.Collections.Generic;
using App.Community.ContactCard;
using UnityEngine;
using UnityEngine.UI;
using static App.Community.ContactCard.ContactCardModel;

public class CommunityPageManager : MonoBehaviour
{

    public VerticalLayoutGroup contactsColumn;
    public GameObject contactCardPrefab;
    private List<ContactCardModel> contactCards;

    public Button AllFilterButton;
    public Button FavoriteFilterButton;
    
    // Start is called before the first frame update
    void Start()
    {
        
        AllFilterButton.onClick.AddListener(showAllCards);
        FavoriteFilterButton.onClick.AddListener(showFavoriteCards);
        
        contactCards = new List<ContactCardModel>
        {
            new ContactCardModel(true, "Jane Doe", 0.4, 87),
            new ContactCardModel(false, "John Smith", 0.6, 77),
            new ContactCardModel(false, "Mark Krasinski", 1.2, 79),
            new ContactCardModel(true, "Mary Jane", 3.6, 72),
            new ContactCardModel(true, "Linda Johnson", 6.5, 73),
            new ContactCardModel(true, "Xavi Hernandez", 8.9, 98),
            new ContactCardModel(true, "Hellen Kirby", 9.0, 74),
            new ContactCardModel(false, "Maci Golden", 9.6, 78)
        };
       showAllCards();
    }

    private void showAllCards()
    {
        clearCards();
        for (int i = 0; i < contactCards.Count; i++)
        {
            GameObject contactCard = Instantiate(contactCardPrefab, contactsColumn.transform);
            contactCard.GetComponent<ContactCardController>().setFavorite(contactCards[i].favorite);
            contactCard.GetComponent<ContactCardController>().setName(contactCards[i].name);
            contactCard.GetComponent<ContactCardController>().setdistance(contactCards[i].distance);
            contactCard.GetComponent<ContactCardController>().setTemp(contactCards[i].temp);
        }
    }
    
    private void showFavoriteCards()
    {
        clearCards();
        for (int i = 0; i < contactCards.Count; i++)
        {
            if (contactCards[i].favorite == true)
            {
                GameObject contactCard = Instantiate(contactCardPrefab, contactsColumn.transform);
                contactCard.GetComponent<ContactCardController>().setFavorite(contactCards[i].favorite);
                contactCard.GetComponent<ContactCardController>().setName(contactCards[i].name);
                contactCard.GetComponent<ContactCardController>().setdistance(contactCards[i].distance);
                contactCard.GetComponent<ContactCardController>().setTemp(contactCards[i].temp);
            }
        }
    }

    private void clearCards()
    {
        while (contactsColumn.transform.childCount > 0) {
            DestroyImmediate(contactsColumn.transform.GetChild(0).gameObject);
        }
    }
}
