using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("BasementMain");
    }
    public void ExitGame()
    {
        SceneManager.LoadScene("ExitConfirmationScene");
    }



}
