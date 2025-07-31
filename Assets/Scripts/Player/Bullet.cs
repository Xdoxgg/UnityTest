using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletLifeTime;

    private void Awake()
    {
        StartCoroutine(BulletDelete());
    }

    private IEnumerator BulletDelete()
    {
        yield return new WaitForSeconds(bulletLifeTime);
        Destroy(gameObject);
    }
}