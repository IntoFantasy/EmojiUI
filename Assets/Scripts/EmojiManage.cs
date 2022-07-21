using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmojiManage : MonoBehaviour
{
    public GameObject heart_L;
    public GameObject heart_R;
    private SkinnedMeshRenderer skinnedMeshRenderers;
    // Start is called before the first frame update
    void Start()
    {
        skinnedMeshRenderers = GameObject.FindWithTag("BlendShape").GetComponent<SkinnedMeshRenderer>();
        Init();
    }

    private void Init()
    {
        heart_L.SetActive(false);
        heart_R.SetActive(false);
        for(int i=0;i<6;++i){
            skinnedMeshRenderers.SetBlendShapeWeight(i, 0);
        }
    }
    // Update is called once per frame
    public void Grinning()
    {
        Init();
        skinnedMeshRenderers.SetBlendShapeWeight(1, 66);
    }
    public void SlightlySmiling()
    {
        Init();
        skinnedMeshRenderers.SetBlendShapeWeight(1, 33);
    }
    public void SmilingWithHeartEyes()
    {
        Init();
        skinnedMeshRenderers.SetBlendShapeWeight(0, 100);
        skinnedMeshRenderers.SetBlendShapeWeight(1, 100);
        heart_L.SetActive(true);
        heart_R.SetActive(true);
    }
    public void SmilingWithSmilingEyes()
    {
        Init();
        skinnedMeshRenderers.SetBlendShapeWeight(1, 100);
    }
    public void WithOpenMouth()
    {
        Init();
        skinnedMeshRenderers.SetBlendShapeWeight(4, 100);
    }
    public void SlightlyFrowning()
    {
        Init();
        skinnedMeshRenderers.SetBlendShapeWeight(3, 100);
    }
    public void Angry()
    {
        Init();
        skinnedMeshRenderers.SetBlendShapeWeight(2, 100);
    }

}
