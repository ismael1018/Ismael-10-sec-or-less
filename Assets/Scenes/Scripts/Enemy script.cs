using UnityEngine;

public class Enemyscript : MonoBehaviour
{
    public float speed = 5f;
     
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

   
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            FindFirstObjectByType<GameManager>().PlayerDied();
         
        }
    }
}
