using UnityEngine;

public class HideGuide : MonoBehaviour
{
    // Reference to the Guide GameObject
    public GameObject guideObject;

    // Function to hide the Guide GameObject
    public void HideGuideObject()
    {
        if (guideObject != null)
        {
            guideObject.SetActive(false);
        }
    }

    // Function to show the Guide GameObject
    public void ShowGuideObject()
    {
        if (guideObject != null)
        {
            guideObject.SetActive(true);
        }
    }
}
