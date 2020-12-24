using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    public void Play()
    { SceneManager.LoadScene("JeuAR"); }
    public void Exit()
    { Application.Quit(); }
}
