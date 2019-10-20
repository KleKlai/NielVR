using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BackMenu : MonoBehaviour
{
    public Button BackButton;
    // Start is called before the first frame update
    void Start()
    {
        BackButton.onClick.AddListener(Back);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
