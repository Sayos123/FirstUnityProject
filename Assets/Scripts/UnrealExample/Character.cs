using UnityEngine;

public class Character : MonoBehaviour
{
    public PlayerController playerController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerController.enhancedInput.AddMappingContext();
        Debug.Log(playerController.displayName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
