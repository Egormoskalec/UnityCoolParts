using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private bool isActive = true;
    public GameObject MarkPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        if (!isActive) return;
        isActive = false;

        Debug.Log(collision.gameObject.name);
        GetComponent<Rigidbody>().useGravity = true;

        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy)
        {
            enemy.OnHit();
            if (collision.collider.GetComponent<EnemyHead>())
            {
                Debug.Log("HeadShot");
            }
        }

        if (collision.gameObject.tag == "BulletReceiver")
        {
            Vector3 position = collision.contacts[0].point;
            Quaternion rotation = Quaternion.LookRotation(collision.contacts[0].normal);
            Instantiate(MarkPrefab, position, rotation);
        }
    }

}
