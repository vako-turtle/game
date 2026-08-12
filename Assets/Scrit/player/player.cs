using TMPro;
using System.Collections;
using UnityEngine;

public class player : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private int Speed;

    [Header("Movement")]
    [SerializeField] private Rigidbody _Rigidbody;
    [SerializeField] private float _jump = 5f;



    //[Header("Inventory")]
    //[SerializeField] private GameObject inventoryUI;
    //private bool isInventoryOpen = false;

    //[SerializeField] private GameObject ChrossHEAR;
    //private bool isChrossHEAROpen = false;

    private int randomInt;

    private bool isGrounded;

    void Awake()
    {
        if (_Rigidbody == null)
            _Rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        //inventoryUI.SetActive(false);

        if (_Rigidbody == null)
        {
            Debug.LogError("NOT ALL FIELDS ARE ASSIGNED TO INSPECTOR!", this);
            enabled = false;
            return;
        }

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

    }

 

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move =
            transform.right * x +
            transform.forward * z;

        Vector3 velocity = new Vector3(
            move.x * Speed,
            _Rigidbody.linearVelocity.y,
            move.z * Speed
        );

        _Rigidbody.linearVelocity = velocity;
    }


    private void Jump()
    {
        if (!isGrounded) return;

        _Rigidbody.AddForce(Vector3.up * _jump, ForceMode.Impulse);
        isGrounded = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }



}