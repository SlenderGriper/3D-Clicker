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

    private GameObject _menuCollection;

    public void Exit()
    {
        Application.Quit();
    }
   public void DeathMenu()
    {
        MenuMeneger(true);
        foreach (Transform child in _mainMenu.GetComponent<Transform>())
        {
            child.GetComponent<CloseButtonInFail>()?.Close();
        }
    }
    private void MenuMeneger(bool isMenuClose) {
        
        Time.timeScale = isMenuClose?0:1;
        _blurUI.SetActive(isMenuClose);
        _mainMenu.SetActive(isMenuClose);
        _backButton.SetActive(!isMenuClose);

    }
    public void OpenMenu()
    {
        if (_menuCollection == null) MenuMeneger(true);
        else CloseTab();
    }
    public void CloseMenu()
    {
         MenuMeneger(false);
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void OpenTab(GameObject menuCollection)
    {
        menuCollection.GetComponent<WriteInUIScore>()?.WriteInUI(GetComponent<Score>().CatchList);
        _menuCollection = menuCollection;
        TabMeneger(true);
        
    }

    
     private void CloseTab()
    {
        TabMeneger(false);
        _menuCollection = null;
    }
    private void TabMeneger(bool isTabOpen)
    {
        _menuCollection.SetActive(isTabOpen);
        _backButton.SetActive(isTabOpen);
        _mainMenu.SetActive(!isTabOpen);
    }

}
