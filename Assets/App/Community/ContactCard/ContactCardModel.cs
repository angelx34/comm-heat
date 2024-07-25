using UnityEngine;

namespace App.Community.ContactCard
{
    public class ContactCardModel : MonoBehaviour
    {

        public bool favorite;

        public string name;

        public double distance;

        public int temp;

        public ContactCardModel(bool favorite, string name, double distance, int temp)
        {
            this.favorite = favorite;
            this.name = name;
            this.distance = distance;
            this.temp = temp;
        }
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
