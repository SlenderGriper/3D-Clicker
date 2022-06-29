using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingDifficulty : MonoBehaviour
{
    private Spawn _change;
    void Start()
    {
        _change = GetComponent<Spawn>();
        StartCoroutine(Creator());
    }
    IEnumerator Creator()
    {
        int i = 0;
        while (TextChanger.current.NeedMoreEnemy)
        {
            yield return new WaitForSeconds(10f);
            _change.IncreaseDefficulty(1.1f);
            if (i <= 6)
            {
                _change.DecreaseSpawnSpeed(1.1f);
                i = 0;
            }
            else i++;
        }

    }
}
