using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class mainmenu : MonoBehaviour
{
    public GameObject paneloptions;
    public GameObject menu;
    // Start is called before the first frame update
    public void play()
    {
        SceneManager.LoadScene(1);
    }
    public void quit()
    {
        Application.Quit();
    }
    public void options()
    {
        paneloptions.SetActive(true);
        menu.SetActive(false);

    }
    public void back()
    {
        SceneManager.LoadScene(0);
    }
}
