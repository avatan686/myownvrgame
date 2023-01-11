using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractionController : MonoBehaviour
{

    public GameObject cam;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(cam.transform.position, Vector3.forward, 2, LayerMask.GetMask("Book")))
        {
            UserInterface.Instance.crosshair.gameObject.SetActive(false);
            UserInterface.Instance.selection.gameObject.SetActive(true);

            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("the present");
            }
        }
        else
        {
            UserInterface.Instance.crosshair.gameObject.SetActive(true);
            UserInterface.Instance.selection.gameObject.SetActive(false);
        }
        
        
    }
}
