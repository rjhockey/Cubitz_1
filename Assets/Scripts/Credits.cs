using UnityEngine;

public class Credits : MonoBehaviour
{
    
    public void Quit ()
    {
        Debug.Log("Quit");   // will display in console
        Application.Quit();
    }

}

// script linked in Unity through CreditsPanel
// Quit function linked in Unity under 'On Click ()'
// Also link CreditsPanel under 'On Click ()'
// Will only work on Build, not inside Unity player