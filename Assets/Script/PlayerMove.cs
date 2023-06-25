using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float xMax;
    [SerializeField] private float zMax;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && this.transform.position.x < xMax)
        {
            transform.Translate(new Vector3(moveSpeed, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) && this.transform.position.x > -xMax)
        {
            transform.Translate(new Vector3(-moveSpeed, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W) && this.transform.position.z < zMax)
        {
            transform.Translate(new Vector3(0, 0, moveSpeed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) && this.transform.position.z > -zMax)
        {
            transform.Translate(new Vector3(0, 0, -moveSpeed) * Time.deltaTime);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
            Debug.Log("Enemy");
        }
    }
    private void OnDestroy()
    {
        SceneManager.LoadScene("End");
    }
}
