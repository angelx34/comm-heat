using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace App.Shared.BottomNavigationBar
{
    public class BottomNavBarController : MonoBehaviour
    {
    
        public Button homePageIconButton;
        public Button communityPageIconButton;
        public Button mapPageIconButton;
        public Button myProfileIconButton;
    
        // Start is called before the first frame update
        void Start()
        {
            homePageIconButton.onClick.AddListener(_onHomePageClick);
            communityPageIconButton.onClick.AddListener(_onCommunityPageClick);
            mapPageIconButton.onClick.AddListener(_onMapPageClick);
            myProfileIconButton.onClick.AddListener(_onMyProfileClick);
        }
    
        void _onHomePageClick()
        {
            SceneManager.LoadScene("HomePage");
        }
    
        void _onCommunityPageClick()
        {
            SceneManager.LoadScene("CommunityPage");
        }
    
        void _onMapPageClick()
        {
            SceneManager.LoadScene("MapPage");
        }
    
        void _onMyProfileClick()
        {
            SceneManager.LoadScene("ProfilePage");
        }
    }
}
