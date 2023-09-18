using UnityEngine;

public class RemoveTaptoPlay : MonoBehaviour
{
    // Reference to the Guide GameObject
    public GameObject TaptoPlayObject;

    // Function to hide the Guide GameObject
    public void HideTaptoPlayObject()
    {
        if (TaptoPlayObject != null)
        {
            TaptoPlayObject.SetActive(false);
        }
    }

    // Function to show the Guide GameObject
    public void ShowTaptoPlayObject()
    {
        if (TaptoPlayObject != null)
        {
            TaptoPlayObject.SetActive(true);
        }
    }
}
