using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

      public Animation Anim;    //动画
     public AnimationClip Clip;     //默认动画
    void Awake()
    {
        Anim = this.GetComponent<Animation>();   //初始化    获取Animation组件
       
    }
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Anim.Play();     //播放动画
        }
        if (Input.GetMouseButton(0))
        {
            //Anim.CrossFade("Capsule_Color");     // Animation.CrossFade 淡入淡出

            Anim.AddClip(Clip, "Capsule_Color");     //添加一个指定名称的动画剪辑为Capsule_Color
            Anim.clip = Clip;       //动画的默认的动画为Clip
            Anim.Play();    ////播放动画
        }
    }

}
