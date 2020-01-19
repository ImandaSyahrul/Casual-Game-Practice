using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLoader : MonoBehaviour
{
    [SerializeField] private GameObject androidMenu;
    [SerializeField] private GameObject desktopMenu;
    //Awake is called even the object is not enabled yet
    private void Awake()
    {
        androidMenu.SetActive(false);
        desktopMenu.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
#if UNITY_ANDROID
        androidMenu.SetActive(true);
#else
        desktopMenu.SetActive(true);
#endif
    }

}
