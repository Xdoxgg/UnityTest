using Interactive;
using UnityEngine;

public class SampleGun : MonoBehaviour
{
    private InteractiveObject _obj;
    private Outline _outline;
    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
    private Transform _bulletPosition;
    public Transform hand;
    public int bulletSpeed = 5;
    public HandInventory inventory;

    private void Awake()
    {
        _obj = GetComponent<InteractiveObject>();
        _obj.ObjectAction = PickObject;
    }

    private void PickObject()
    {
        _obj.transform.position = hand.position;
        _obj.GetComponent<Rigidbody>().isKinematic = true;
        transform.SetParent(hand);
        _obj.transform.rotation =new Quaternion(0,0,0,0);
        _obj.ObjectAction = Shoot;
        inventory._currentItem = gameObject;
    }

    private void Shoot()
    {
        GameObject tempBullet=Instantiate(_bullet, _bulletPosition.position, Quaternion.identity);
        tempBullet.GetComponent<Rigidbody>().AddForce(_bulletPosition.forward*bulletSpeed,ForceMode.Force);
    }
}
