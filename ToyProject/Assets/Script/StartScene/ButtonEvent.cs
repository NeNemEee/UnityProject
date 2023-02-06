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
            UnityEditor.EditorApplication.isPlaying = false; //play��带 false��.
        #elif UNITY_WEBPLAYER
            Application.OpenURL("http://google.com"); //���������� ��ȯ
        #else
            Application.Quit(); //���ø����̼� ����
        #endif
    }
}
