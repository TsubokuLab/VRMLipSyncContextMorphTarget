# VRMLipSyncContextMorphTarget
OVRLipSyncでVRMモデルのリップシンクをさせるだけのやつ。

## Dependency
* OVRLipSync が必要。
[https://developer.oculus.com/downloads/package/oculus-lipsync-unity/](https://developer.oculus.com/downloads/package/oculus-lipsync-unity/)

## Usage
OVRLipSyncのサンプルの**OVR**LipSyncContextMorphTargetと同じ場所に**VRM**LipSyncContextMorphTargetコンポーネントを貼るだけ。

自動でヒエラルキーからVRMBlendShapeProxyを見つけてアタッチしてくれます。

手動で設定する場合は```SetVRMBlendShapeProxy(VRMBlendShapeProxy _proxy)```へVRMについているVRMBlendShapeProxyを投げる。

## Author
Teruaki Tsubokura [http://teruaki-tsubokura.com/](http://teruaki-tsubokura.com/)
[@kohack_v](https://twitter.com/kohack_v)

## License
[MIT](https://mit-license.org/)
