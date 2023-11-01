using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonController : MonoBehaviour
{

    [SerializeField] private string _startScene = "StartScene";

    public void BackSceneButton()
    {
        SceneManager.LoadScene(_startScene);
    }


}
