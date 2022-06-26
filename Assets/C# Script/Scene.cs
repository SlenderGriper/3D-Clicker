using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public GameObject backButton;
    public GameObject mainMenu;
    private GameObject _menuCollection;
   public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void OpenMenu(GameObject menuCollection)
    {
        _menuCollection = menuCollection;
        _menuCollection.SetActive(true);
        backButton.SetActive(true);
        mainMenu.SetActive(false);
    }
     public void ExitMemu()
    {
        backButton.SetActive(false);
        _menuCollection.SetActive(false);
        mainMenu.SetActive(true);
    }
}
