using UnityEngine;

public class GameManager : MonoBehaviour
{
    // A static reference to the single instance of the class
    public static GameManager Instance { get; private set; }
    public bool huntsmanAxeitem = false; 

    
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            // If an instance already exists, destroy this duplicate
            Destroy(this.gameObject);
            return;
        }
        
        // Set the static reference to this instance
        Instance = this;
        
        // Optional: Keep the object alive when loading new scenes
        DontDestroyOnLoad(this.gameObject);
    }

    



}


