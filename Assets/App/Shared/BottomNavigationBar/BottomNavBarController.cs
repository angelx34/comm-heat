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

        private int _currentPageIndex;
        
        void Start()
        {
            homePageIconButton.onClick.AddListener(_onHomePageClick);
            communityPageIconButton.onClick.AddListener(_onCommunityPageClick);
            mapPageIconButton.onClick.AddListener(_onMapPageClick);
            myProfileIconButton.onClick.AddListener(_onMyProfileClick);
            
            // get the current scene name
            var currentSceneName = SceneManager.GetActiveScene().name;
            switch (currentSceneName)
            {
                case "HomePage":
                    _currentPageIndex = 0;
                    break;
                case "CommunityPage":
                    _currentPageIndex = 1;
                    break;
                case "MapPage":
                    _currentPageIndex = 2;
                    break;
                case "ProfilePage":
                    _currentPageIndex = 3;
                    break;
            }
        }
    
        void _onHomePageClick()
        {
            if (_currentPageIndex == 0) return;
            SceneManager.LoadScene("HomePage");
            _currentPageIndex = 0;
        }
    
        void _onCommunityPageClick()
        {
            if (_currentPageIndex == 1) return;
            SceneManager.LoadScene("CommunityPage");
            _currentPageIndex = 1;
        }
    
        void _onMapPageClick()
        {
            if (_currentPageIndex == 2) return;
            SceneManager.LoadScene("MapPage");
            _currentPageIndex = 2;
        }
    
        void _onMyProfileClick()
        {
            if (_currentPageIndex == 3) return;
            SceneManager.LoadScene("ProfilePage");
            _currentPageIndex = 3;
        }
    }
}
