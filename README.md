# ScriptableObject_Architecture
![image](https://github.com/CreatNatoy/ScriptableObject_Architecture/assets/76531899/1e1c90df-9d4a-427a-a951-48b32735681b)
<p align="center">
    <img src="https://img.shields.io/badge/Engine-2021.3.1f1-blueviolet" alt="Unity Version">
    <img src="https://img.shields.io/badge/Version-0.1-blue" alt="Game Version">
    <img src="https://img.shields.io/badge/License-None-success" alt="License">
</p>

So here we will implement architecture using ScriptableObject.
ScriptableObject is not just a convenient data storage container optimized as a flyweight pattern. But the Unity folks have shown how to use it in Architecture.
The book is available at this link. 

[Create modular game architecture in Unity with ScriptableObjects.](https://resources.unity.com/games/create-modular-game-architecture-with-scriptable-objects-ebook?ungated=true)

## Assets
* [Odin.](https://assetstore.unity.com/packages/tools/utilities/odin-inspector-and-serializer-89041) It was used to avoid writing Editor scripts.

## Architecture
* Configuration
* Pattern: Extendable Enums
* Pattern: Delegate objects
* Pattern: Observer
* Pattern: Runtime Set

## Gif
#### Configuration
![Unity_2Owf0R99Zw](https://github.com/CreatNatoy/ScriptableObject_Architecture/assets/76531899/0b4293b7-389d-4754-be1c-7203cf02099d)
In this example, the Configuration demonstrates that data can be stored in a ScriptableObject, and it can be edited in Play Mode with all changes saved. The Configuration itself is present in the scene as a separate object. Additionally, you can create child objects to edit different sets of data. Isn't it convenient that you can edit all the data in one place instead of searching for them throughout the project or scene?

#### Pattern: Extendable Enums
![Unity_u4tviaZwK8](https://github.com/CreatNatoy/ScriptableObject_Architecture/assets/76531899/21c3a212-1496-465e-808d-ee172b98ba79)
In this example, Pattern: Extendable Enums, I demonstrated how ScriptableObjects can be conveniently used as Enums.

#### Pattern: Delegate objects
![Unity_8Azcp2OJUW](https://github.com/CreatNatoy/ScriptableObject_Architecture/assets/76531899/ee50628e-0343-4741-afc9-21269cf34afb)
In this example, Pattern: Delegate objects, I demonstrated how ScriptableObjects can execute code in different parameters. At the same time, you can always create more options. The book used sound reproduction, here I showed an example with text.

### Pattern: Observer
![Unity_JQ3UO9v8Fb](https://github.com/CreatNatoy/ScriptableObject_Architecture/assets/76531899/d7dd40c0-1438-4e89-beb5-5b91ee2b446e)
In this example, How easy it is to create an observer. In this example, we have 2 observers for Start and Stop, but you can also create any number. At the same time, you do not need to write additional code.

### Pattern: Runtime Set
![Unity_uLqwz5KBMp](https://github.com/CreatNatoy/ScriptableObject_Architecture/assets/76531899/ee077da7-67fa-4a9a-a7bc-b7ccff23ec3b)
In this example, How easy it is to create an container. And get a link to objects, without searching, static, singletons, and using scriptableObject. 

