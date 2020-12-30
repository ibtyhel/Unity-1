using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    public void Play()
    { SceneManager.LoadScene("JeuAR"); }
    public void Exit()
    { Application.Quit(); }
    public void Level()
    { SceneManager.LoadScene("Levels"); }
    public void PlayL1()
    { SceneManager.LoadScene("JeuAR Lvl1"); }
    public void PlayL3()
    { SceneManager.LoadScene("JeuAR Lvl3"); }
    public void MainMenu()
    { SceneManager.LoadScene("MenuScene"); }
}
