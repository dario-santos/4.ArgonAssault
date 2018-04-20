using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    private void Update()
    {
        float horizontalThrow = CrossPlatformInputManager.GetAxis("Horizontal");

        float verticalThrow = CrossPlatformInputManager.GetAxis("Vertical");

        print(horizontalThrow);

    }
    
    
    
}
    
}