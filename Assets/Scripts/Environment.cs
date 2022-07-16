using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_WEBGL
public class Environment : MonoBehaviour
{
    public void Start(){
        GameObject Canvas = GameObject.Find("Canvas");
        Text Account = Canvas.transform.GetChild(0).GetComponent<Text>();
        Account.text = PlayerPrefs.GetString("Account");
    }
}
#endif
