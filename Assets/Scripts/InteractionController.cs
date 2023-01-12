using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractionController : MonoBehaviour
{

    [SerializeField] private GameObject cam;
    
    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, 2, LayerMask.GetMask("Book")))
        {
            UserInterface.Instance.crosshair.gameObject.SetActive(false);
            UserInterface.Instance.selection.gameObject.SetActive(true);

            if (Input.GetMouseButtonDown(0))
            {
                

                if (SceneManager.GetActiveScene().name == "the past")
                {
                    UserInterface.Instance.Fade();
                    SceneManager.LoadScene("the present");
                }
                else if (SceneManager.GetActiveScene().name == "the present")
                {
                    UserInterface.Instance.Fade();
                    SceneManager.LoadScene("the future");
                }
                else if (SceneManager.GetActiveScene().name == "the future")
                {
                    UserInterface.Instance.End();
                    Destroy(this);
                }
                
            }
        }
        else
        {
            UserInterface.Instance.crosshair.gameObject.SetActive(true);
            UserInterface.Instance.selection.gameObject.SetActive(false);
        }
        


    }
    
    
}
