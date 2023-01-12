using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class UserInterface : MonoBehaviour
{
    public static UserInterface Instance = new UserInterface();

    public Image crosshair;
    public Image selection;
    public Image fade;
    public GameObject end;

    private void Awake()
    {
        if (UserInterface.Instance == null)
        {
            UserInterface.Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Fade()
    {
        fade.gameObject.SetActive(true);
        fade.color = new Color(1, 1, 1, 1);
        StartCoroutine(Fader());
    }

    IEnumerator Fader()
    {
        for (float i = 1; i > 0; i -= Time.deltaTime)
        {
            fade.color = new Color(1, 1, 1, i);
            yield return null;
        }
    }

    public void End()
    {
        fade.color = new Color(1, 1, 1, 1);
        end.SetActive(true);
    }

}
