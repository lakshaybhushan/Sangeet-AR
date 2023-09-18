using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Exp_Script : MonoBehaviour
{
    public void StartExperience()
    {
        SceneManager.LoadScene("MainGame");
    }
}
