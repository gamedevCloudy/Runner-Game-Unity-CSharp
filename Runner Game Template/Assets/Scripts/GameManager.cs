using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject joystick; 
    [SerializeField] private playerController movement; 
    [SerializeField] private GameObject startUI; 
    private void Awake() 
    {
        
    }
    public void StartGame()
    {
        startUI.SetActive(false); 
        joystick.SetActive(true); 
        movement.enabled = true; 

    }
    public void GameEnd()
    {
    
        Debug.Log("Game Over"); 
        Invoke("ReloadScene", 2f); 
    }
    public void LevelWin()
    {
        Debug.Log("Level Complete");
        Invoke("LoadNextLevel",2f);
    }

    private void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
    