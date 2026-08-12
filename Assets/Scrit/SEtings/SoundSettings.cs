using UnityEngine;
 using UnityEngine;
using UnityEngine.UI;


public class SoundSettings : MonoBehaviour
{
    public Toggle soundToggle;

    void Start()
    {
        soundToggle.isOn = AudioListener.volume > 0;
    }

    public void ToggleSound(bool enabled)
    {
        if (enabled)
            AudioListener.volume = 1f;
        else
            AudioListener.volume = 0f;
    }

}
