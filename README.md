# VRMLipSyncContextMorphTarget
OVRLipSyncでVRMモデルのリップシンクをさせるシンプルなやつ。

## Dependency
* OVRLipSync https://developer.oculus.com/downloads/package/oculus-lipsync-unity/
* UniVRM https://github.com/dwango/UniVRM/releases

## Usage
OVRLipSyncのサンプルの**OVR**LipSyncContextMorphTargetの部分を、**VRM**LipSyncContextMorphTargetコンポーネントに入れ替えるだけ。

自動でヒエラルキーからVRMBlendShapeProxyを見つけてアタッチしてくれます。

手動で設定する場合は```SetVRMBlendShapeProxy(VRMBlendShapeProxy _proxy)```へVRMについているVRMBlendShapeProxyを投げる。

## Author
Teruaki Tsubokura [http://teruaki-tsubokura.com/](http://teruaki-tsubokura.com/)

[@kohack_v](https://twitter.com/kohack_v)

## License
[MIT](https://mit-license.org/)
