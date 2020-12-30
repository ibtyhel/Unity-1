using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpOpener : MonoBehaviour
{
    public GameObject Panel;
    public void OpenHelp()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }
  
}
