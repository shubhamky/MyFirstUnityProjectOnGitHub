using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    public string newScene;
    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnButtonClick()
    {
        Debug.Log("Button clicked");
        SceneManager.LoadScene(newScene);
    }
}
