using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Build.Content;

public class GameControllerScene1 : MonoBehaviour

{

    [SerializeField]
    private TextMeshProUGUI txtGreenApple;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ShowGreenApple();
    }

    public void ShowGreenApple()
    {
        txtGreenApple.text= GameManager.Instance.AppleGreenCount.ToString();
    }
}
