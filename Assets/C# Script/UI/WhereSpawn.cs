using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhereSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _camera;
    [SerializeField] private GameObject _fatherCanvas;
    [SerializeField] private GameObject _prefabLeft;
    [SerializeField] private GameObject _prefabRight;

    public void CheackToCreate(float x)
    {
        var position = _camera.GetComponent<Transform>().position;
        if (position.x + 6 < x) StartCoroutine(Create(_prefabRight));
        else if (position.x - 6 > x) StartCoroutine(Create(_prefabLeft));
    }
    private IEnumerator Create(GameObject point)
    {
        var newpoint = Instantiate(point);
        newpoint.GetComponent<Transform>().SetParent(_fatherCanvas.GetComponent<Transform>());

        newpoint.GetComponent<RectTransform>().anchoredPosition3D = point.GetComponent<RectTransform>().anchoredPosition3D;

        newpoint.GetComponent<RectTransform>().localScale = point.GetComponent<RectTransform>().localScale;
        yield return new WaitForSeconds(0.5f);
        Destroy(newpoint);
    }
}