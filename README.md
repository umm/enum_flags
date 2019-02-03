# Enum Flags

## What

![image](https://user-images.githubusercontent.com/838945/52180029-6d591880-2824-11e9-8eb3-d93b53199b86.png)

## Requirement

* Unity 2018.3 (or Incremental Compiler)

## Install

```shell
yarn add "umm/enum_flags#^1.0.0"
```

## Usage

### Mark as `[Flags]` into enum

```csharp
[System.Flags]
enum SomeType
{
    Foo = 1 << 0,
    Bar = 1 << 1,
    Buz = 1 << 2,
    Quz = 1 << 3,
}
```

### Mark as `[EnumFlags]` into serializable field

```csharp
[SerializaField]
[EnumFlags]
private SomeType someType;
```

## License

Copyright (c) 2019 Tetsuya Mori

Released under the MIT license, see [LICENSE.txt](LICENSE.txt)

