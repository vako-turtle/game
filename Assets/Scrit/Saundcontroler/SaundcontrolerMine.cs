using UnityEngine;
using UnityEngine.Audio;

public class SaundcontrolerMine : MonoBehaviour
{
    [SerializeField] private AudioSource audioSourcemine;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Stone"))
                {
                    audioSourcemine.Play();
                }
            }

        }
    }
}
