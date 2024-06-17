using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConfirmExit : MonoBehaviour
{
    public void Confirm()
    {
        Application.Quit();
    }

    public void CancelExit()
    {
        SceneManager.LoadScene("Menu");
    }
}
