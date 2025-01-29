using UnityEngine;

public class ScreenOrien : MonoBehaviour
{
    private void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;
    }
}