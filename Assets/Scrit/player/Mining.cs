  using UnityEngine;
public class Mining : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private float distance = 3f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, distance))
            {
                Health health = hit.collider.GetComponent<Health>();

                if (health != null)
                {
                    //health.TakeDamage(PlayerStats.Instance.damage);
                    health.TakeDamage(PlayerStats.Instance.damage);
                }
            }
        }
    }

    //    [SerializeField] private Camera cam;           
    //    [SerializeField] private float distance = 3f;  
    //    [SerializeField] private int playerData;  

    //    void Update()
    //    {
    //        if (Input.GetMouseButtonDown(0)) 
    //        {
    //            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
    //            RaycastHit hit;

    //            if (Physics.Raycast(ray, out hit, distance))
    //            {

    //                Health health = hit.collider.GetComponent<Health>();
    //                if (health != null)
    //                {

    //                    health.TakeDamage(playerData);
    //                }
    //            }
    //        }
    //    }
}

