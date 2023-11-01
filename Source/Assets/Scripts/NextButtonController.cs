using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonController : MonoBehaviour
{
    [SerializeField] private string _newGameLevel = "NextScene";

    public void NewGameButton()
    {
        SceneManager.LoadScene(_newGameLevel);
    }


}
