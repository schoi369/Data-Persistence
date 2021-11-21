using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public InputField playerNameInputField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame() {
        // Save Player Name in Game Manager (Singleton)
        GameManager.Instance.PlayerName = playerNameInputField.text;
        Debug.Log(GameManager.Instance.PlayerName.ToString());

        // Load main scene
        SceneManager.LoadScene(1);
    }
}
