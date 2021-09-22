using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void LoadPrologue()
    {
        SceneManager.LoadScene("Prologue");
    }

    public void LoadStageOne()
    {

    }

    public void GameExit()
    {
        Application.Quit();
    }
}
