using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    [SerializeField] private GameObject _backButton;
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _blurUI;
    [SerializeField] private GameObject _buttonToMenu;
    private bool _isMenuClose = true;
    private GameObject _menuCollection;

    public void Exit()
    {
        Application.Quit();
    }

    public void Menu() {
        
        Time.timeScale = _isMenuClose?0:1;
        _blurUI.SetActive(_isMenuClose);
        _mainMenu.SetActive(_isMenuClose);
        _isMenuClose = !_isMenuClose;
        Debug.Log(_isMenuClose);
    }


    public void OpenTab(GameObject menuCollection)
    {
        menuCollection.GetComponent<WriteInUIScore>()?.WriteInUI(GetComponent<Score>().CatchList);
        _menuCollection = menuCollection;
        _menuCollection.SetActive(true);
        _backButton.SetActive(true);
        _mainMenu.SetActive(false);
    }
     public void ExitTab()
    {
        _backButton.SetActive(false);
        _menuCollection.SetActive(false);
        _mainMenu.SetActive(true);
    }

}
