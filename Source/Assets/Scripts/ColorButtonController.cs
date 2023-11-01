using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButtonController : MonoBehaviour
{
    public GameObject button;
    public void ChangeColor()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        button.GetComponent<Image>().color = randomColor;
    }

}
