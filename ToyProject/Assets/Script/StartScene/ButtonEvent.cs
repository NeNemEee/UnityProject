using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{

    public void ButtonStart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ButtonExit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; //play모드를 false로.
        #elif UNITY_WEBPLAYER
            Application.OpenURL("http://google.com"); //구글웹으로 전환
        #else
            Application.Quit(); //어플리케이션 종료
        #endif
    }
}
