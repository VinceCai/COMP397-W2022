using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreenController : MonoBehaviour
{

    public void OnstartButton_Pressed()
    {
        SceneManager.LoadScene(("Main"));
    }
}