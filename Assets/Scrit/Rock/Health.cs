using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class Health : MonoBehaviour
{

    [Header("Stats")]
    public float maxHealth = 10f;
    private float currentHealth;
    private bool isDead;

    [Header("UI")]
    public Slider healthBar;
    public TextMeshProUGUI healthText;
    public Canvas canvas;

    [Header("Respawn")]
    public float respawnTime = 5f;

    [Header("Sound")]
    public AudioClip deathSound;
    private AudioSource audioSource;

    private Renderer rend;
    private Collider col;
    private Drops drops;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateUI();

        rend = GetComponent<Renderer>();
        col = GetComponent<Collider>();
        drops = GetComponent<Drops>();

        audioSource = GetComponent<AudioSource>();
    }

    public void TakeDamage(float damage)
    {
        if (isDead) return;

        currentHealth -= damage;
        UpdateUI();

        if (currentHealth <= 0)
            Die();
    }

    void Die()
    {
        isDead = true;

        if (deathSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(deathSound);
        }

        if (drops != null)
            drops.DropResources();

        StartCoroutine(Respawn());
    }

    void UpdateUI()
    {
        if (healthBar != null)
        {
            healthBar.maxValue = maxHealth;
            healthBar.value = currentHealth;
        }

        if (healthText != null)
            healthText.text = $"{Mathf.CeilToInt(currentHealth)} / {maxHealth}";
    }

    IEnumerator Respawn()
    {
        if (rend != null) rend.enabled = false;
        if (col != null) col.enabled = false;
        if (canvas != null) canvas.enabled = false;

        yield return new WaitForSeconds(respawnTime);

        currentHealth = maxHealth;
        isDead = false;
        UpdateUI();

        if (rend != null) rend.enabled = true;
        if (col != null) col.enabled = true;
        if (canvas != null) canvas.enabled = true;
    }


 
    //[Header("Stats")]
    //public float maxHealth = 10f;
    //private float currentHealth;
    //private bool isDead;

    //[Header("UI")]
    //public Slider healthBar;
    //public TextMeshProUGUI healthText;
    //public Canvas canvas;

    //[Header("Respawn")]
    //public float respawnTime = 5f;

    //private Renderer rend;
    //private Collider col;
    //private Drops drops;

    //void Start()
    //{
    //    currentHealth = maxHealth;
    //    UpdateUI();

    //    rend = GetComponent<Renderer>();
    //    col = GetComponent<Collider>();
    //    drops = GetComponent<Drops>();
    //}

    //public void TakeDamage(float damage)
    //{
    //    if (isDead) return;

    //    currentHealth -= damage;
    //    UpdateUI();

    //    if (currentHealth <= 0)
    //        Die();
    //}

    //void Die()
    //{
    //    isDead = true;

    //    if (drops != null)
    //        drops.DropResources();

    //    StartCoroutine(Respawn());
    //}

    //void UpdateUI()
    //{
    //    if (healthBar != null)
    //    {
    //        healthBar.maxValue = maxHealth;
    //        healthBar.value = currentHealth;
    //    }

    //    if (healthText != null)
    //        healthText.text = $"{Mathf.CeilToInt(currentHealth)} / {maxHealth}";
    //}

    //IEnumerator Respawn()
    //{
    //    if (rend != null) rend.enabled = false;
    //    if (col != null) col.enabled = false;
    //    if (canvas != null) canvas.enabled = false;

    //    yield return new WaitForSeconds(respawnTime);

    //    currentHealth = maxHealth;
    //    isDead = false;
    //    UpdateUI();

    //    if (rend != null) rend.enabled = true;
    //    if (col != null) col.enabled = true;
    //    if (canvas != null) canvas.enabled = true;
    //}
}
