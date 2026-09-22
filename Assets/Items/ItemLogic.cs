using UnityEngine;

public class ItemLogic : MonoBehaviour
{
    public float spinSpeed = 40f;
    public float bobMaginitude = 0.5f;
    public float bobSpeed = 2f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime, Space.World);

        float newY = startPos.y + Mathf.Sin(Time.time * bobSpeed) * bobMaginitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z); 

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))

                Destroy(this.gameObject);
        }
    }
