using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DeleteAllEnemy : MonoBehaviour, IPointerClickHandler
{
    private Transform _enemyFather;
    [SerializeField] private GameObject effect;
    private void Start()
    {
        _enemyFather = GetComponent<Transform>().parent.GetComponent<Transform>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        foreach(Transform child in _enemyFather)
        {
            child.GetComponent<StatsChanger>()?.Dead();
        }
        var effPositon=new Vector3(transform.position.x,transform.position.y,transform.position.z);
        Instantiate(effect, effPositon, transform.rotation);
        Destroy(gameObject);
    }

}
