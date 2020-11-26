using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleLightEmission : MonoBehaviour {

    public Material lightMaterial;

    public void disableLight() {
        lightMaterial.DisableKeyword("_EMISSION");
    }

    public void enableLight() {
        lightMaterial.EnableKeyword("_EMISSION");
    }
}
