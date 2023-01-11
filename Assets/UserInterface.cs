using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class UserInterface : MonoBehaviour
{
    public static UserInterface Instance = new UserInterface();

    public Image crosshair;
    public Image selection;

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

}
