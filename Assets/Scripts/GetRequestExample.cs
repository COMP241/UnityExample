using System.Collections;
using UnityEngine;

public class GetRequestExample : MonoBehaviour
{
    // Start has to be a coroutine here so it can use yield
    IEnumerator Start()
    {
        int levelCode = 0;
        string url = string.Format("128.199.159.24/api/map/{0}", levelCode);

        var www = new WWW(url);
        yield return www; // Wait for request to complete

        Debug.Log(www.text); // Process returned text, in future should create object from returned json
    }
}
