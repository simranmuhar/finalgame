using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Helpscene : MonoBehaviour
{
    public void SceneChange(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

}
