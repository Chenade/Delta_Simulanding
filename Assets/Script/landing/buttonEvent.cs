using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonEvent : MonoBehaviour
{
    public GameObject detailCanvas;
    public GameObject mainCanvas;
    public string scene;
    public void closeDetailCanvas() {
        detailCanvas.SetActive(false);
        mainCanvas.SetActive(false);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(scene);
    }
}
