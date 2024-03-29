using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    MainMenu,
    Gameplay,
    Tutorial,
    GameOver
}

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance { get; private set; }

    public GameState CurrentGameState { get; private set; }
    public float stopwatchTime = 0f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        // Set the initial game state
        SetGameState(GameState.MainMenu);
    }

    public void SetGameState(GameState newState)
    {
        // Add any additional logic or transitions between states if needed

        // Set the new game state
        CurrentGameState = newState;

        // Perform actions based on the new state
        switch (newState)
        {
            case GameState.MainMenu:
                // Handle actions for the main menu state
                //SceneManager.LoadScene()
                break;

            case GameState.Gameplay:
                // Handle actions for the gameplay state
                Debug.Log("Switched to Gameplay");
                break;

            case GameState.Tutorial:
                // Handle actions for the pause menu state
                Debug.Log("Switched to Pause Menu");
                break;

            case GameState.GameOver:
                // Handle actions for the game over state
                SceneManager.LoadScene(2);
                Debug.Log("Switched to Game Over");
                break;
        }
    }

    // Example methods to switch states
    public void StartGame()
    {
        SetGameState(GameState.Gameplay);
    }

    public void Tutorial()
    {
        SetGameState(GameState.Tutorial);
    }

    public void ResumeGame()
    {
        SetGameState(GameState.Gameplay);
    }

    public void GameOver()
    {
        SetGameState(GameState.GameOver);
        
    }
}
