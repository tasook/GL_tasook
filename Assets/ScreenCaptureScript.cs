using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScreenCaptureScript : MonoBehaviour
{

    public Texture2D texture;
    public RenderTexture rTexture;
    int imageNumber = 0;
    // Start is called before the first frame update
    void OnEnable()

    {
        int sqr = 512;
        RenderTexture.active = rTexture;
        Texture2D virtualPhoto = new Texture2D(3000, 1660, TextureFormat.RGB24, false);
        virtualPhoto.ReadPixels(new Rect(0, 0, rTexture.width, rTexture.height), 0, 0);
        virtualPhoto.Apply();
        RenderTexture.active = null;
        texture = virtualPhoto;

        byte[] bytes;
        bytes = virtualPhoto.EncodeToPNG();

        System.IO.File.WriteAllBytes(Application.dataPath + "/../Assets/Resources/SavedScreen" + imageNumber.ToString() +".png", bytes);
        imageNumber += 1;
        Debug.Log("saved the image");
        //BuildPipeline.BuildAssetBundles("Assets/Materials/Textures", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
        AssetDatabase.Refresh();

    }

    // Update is called once per frame
    void Update()
    {


    }
}
