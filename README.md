# kiwrious-unity-package
Kiwrious serial reader implementation as a unity package dependency

# Installation

## Step 1
Update Scripting Runtime Version to `.net 4.x Equivalent` from `Player Settings / Other / Configuration`

## Step 2
Import Kiwrious package

### Unity 2019 or later 
Add below dependency to `Packages/manifest.json`
```json
"com.kiwrious.sdk.unity": "https://github.com/augmented-human-lab/kiwrious-unity-package.git"
```

### Unity 2018 or older
Older versions of unity does not support resolving package dependency over git url. so you need to clone it manually.
Simply clone this repository inside `Packages/` folder of your unity project.


# Getting Started

- Add `Kiwrious Reader` prefab into your unity scene from `Packages/kiwrious-unity-package/Prefabs/` 

# Read Values

All sensor values are processed as float values.
```csharp
KiwriousSerialReader.instance.sensorData[sensorName].values[propertyName];
```

```csharp
  KiwriousSerialReader.instance.sensorData["EC"].values["conductivity"]
  KiwriousSerialReader.instance.sensorData["CLIMATE"].values["humidity"]
  KiwriousSerialReader.instance.sensorData["CLIMATE"].values["temperature"]
  KiwriousSerialReader.instance.sensorData["LIGHT"].values["uv"]
  KiwriousSerialReader.instance.sensorData["LIGHT"].values["lux"]
  KiwriousSerialReader.instance.sensorData["COLOR"].values["color_h"]
  KiwriousSerialReader.instance.sensorData["COLOR"].values["color_s"]
  KiwriousSerialReader.instance.sensorData["COLOR"].values["color_v"]
  KiwriousSerialReader.instance.sensorData["VOC"].values["voc"]
  KiwriousSerialReader.instance.sensorData["THERMAL2"].values["d_temperature"]
  KiwriousSerialReader.instance.sensorData["THERMAL2"].values["a_temperature"]
  KiwriousSerialReader.instance.sensorData["CARDIO"].values["heart_rate"]
```

# Android build

### Modify AndroidManifest.xml
```xml
<manifest>
   <application>
      <activity>
         <!-- add new intent filter -->
         <intent-filter>
            <action android:name="android.hardware.usb.action.USB_DEVICE_ATTACHED" />
         </intent-filter>
         <!-- add new meta data -->
         <meta-data
             android:name="android.hardware.usb.action.USB_DEVICE_ATTACHED"
             android:resource="@xml/device_filter" />
      </activity>
   </application>
</manifest>
```



