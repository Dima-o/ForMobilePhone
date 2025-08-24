using UnityEngine;

public class LevelSwitch : MonoBehaviour
{
    [SerializeField] private GameObject menu;

    private BoxCollider collider;

    private void Start()
    {
        Time.timeScale = 1;
        collider = GetComponent<BoxCollider>();
        collider.enabled = true;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Time.timeScale = 0;
            menu.SetActive(true);
            collider.enabled = false;
        }
    }
}
